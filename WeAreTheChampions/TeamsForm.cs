using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampions.Models;

namespace WeAreTheChampions
{
    public partial class TeamsForm : Form
    {
        WATCDbContext db;
        Team teamEditing;
        public TeamsForm(WATCDbContext _db)
        {
            db = _db;
            InitializeComponent();
            ShowTeams();
            cboColors.DataSource = db.Colors.ToList();
        }

        private void ShowTeams()
        {
            lbTeams.DataSource = null;
            lbTeams.DataSource = db.Teams.Where(x => x.TeamName != "unspecified").ToList();
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            if (txtTeamName.Text.Trim() == "")
            {
                MessageBox.Show("Please Fill the Team Name");
                return;
            }
            if (btnAddTeam.Text == "Add Team")
            {
                db.Teams.Add(new Team() { TeamName = txtTeamName.Text });
                db.SaveChanges();
                CleanForm();
                ShowTeams();
            }
            else if (btnAddTeam.Text == "Edit Team")
            {
                teamEditing = (Team)lbTeams.SelectedItem;
                teamEditing.TeamName = txtTeamName.Text;
                db.SaveChanges();
                ShowTeams();
                CleanForm();
                lbTeams.Enabled = true;               
            }
        }

        private void CleanForm()
        {
            lbColors.Enabled = false;
            cboColors.Enabled = false;
            btnAddColor.Enabled = false;
            btnDeleteColor.Enabled = false;
            btnAddTeam.Text = "Add Team";
            btnCancelEdit.Visible = false;
            txtTeamName.Clear();
            lbColors.DataSource = null;
            for (int i = 0; i < lbColors.Items.Count; i++)
            {
                lbColors.Items.RemoveAt(i);
            }
        }

        private void btnEditTeam_Click(object sender, EventArgs e)
        {
            CleanForm();
            if (lbTeams.SelectedItem != null)
            {
                lbTeams.Enabled = false;
                lbColors.Enabled = true;
                cboColors.Enabled = true;
                btnAddColor.Enabled = true;
                btnDeleteColor.Enabled = true;
                btnAddTeam.Text = "Edit Team";
                btnCancelEdit.Visible = true;
                teamEditing = (Team)lbTeams.SelectedItem;
                txtTeamName.Text = teamEditing.TeamName;
                //if (teamEditing.TeamColors.Count > 0)
                //{
                foreach (var item in db.TeamColors)
                {
                    if (item.TeamId == teamEditing.Id)
                    {
                        lbColors.Items.Add(item);
                    }
                }
                //lbColors.DataSource = db.TeamColors.Where(x => x.TeamId == teamEditing.Id);
                //}
            }
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            CleanForm();
            for (int i = 0; i < lbColors.Items.Count; i++)
            {
                lbColors.Items.RemoveAt(i);
            }
            lbTeams.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var teamDeleting = (Team)lbTeams.SelectedItem;
            if (teamDeleting.TeamPlayers.Count > 0)
            {
                MessageBox.Show("There is some player in this team. Please change this players team before deleting process");
                return;
            }
            if (db.Matches.Any(x => x.Team1.Id == teamDeleting.Id) || db.Matches.Any(x => x.Team2.Id == teamDeleting.Id))
            {
                MessageBox.Show("There is some shown matches for this team. Please delete this matches before deleting process");
                return;
            }
            db.Teams.Remove(teamDeleting);
            db.SaveChanges();
            ShowTeams();
        }

        private void btnAddColor_Click(object sender, EventArgs e)
        {
            var editingTeam = (Team)lbTeams.SelectedItem;
            Models.Color newColor = (Models.Color)cboColors.SelectedItem;
            if(teamEditing.TeamColors.Any(x => x.ColorId == newColor.Id))
            {
                MessageBox.Show("This team has already this color");
                return;
            }
            teamEditing.TeamColors.Add(new TeamColor() { Team = editingTeam, Color = (Models.Color)cboColors.SelectedItem });
            db.SaveChanges();
            cboColors.SelectedIndex = -1;
            lbColors.DataSource = null;
            lbColors.DataSource = teamEditing.TeamColors.ToList();
        }

        private void btnDeleteColor_Click(object sender, EventArgs e)
        {
            var team = (Team)lbTeams.SelectedItem;
            TeamColor deletingColor = (TeamColor)lbColors.SelectedItem;
            team.TeamColors.Remove(deletingColor);
            lbColors.DataSource = team.TeamColors.ToList();
        }

        private void btnOyuncular_Click(object sender, EventArgs e)
        {
            if (lbTeams.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir takım seçin");
                return;
            }
            Team team = (Team)lbTeams.SelectedItem;
            TeamPlayersForm frmTeamPlayers = new TeamPlayersForm(db, team);
            frmTeamPlayers.ShowDialog();
        }
    }
}
