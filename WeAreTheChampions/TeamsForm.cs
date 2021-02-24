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
            lbTeams.DataSource = db.Teams.ToList();
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
        }

        private void btnEditTeam_Click(object sender, EventArgs e)
        {
            if (lbTeams.SelectedItem != null)
            {
                lbColors.Enabled = true;
                cboColors.Enabled = true;
                btnAddColor.Enabled = true;
                btnDeleteColor.Enabled = true;
                btnAddTeam.Text = "Edit Team";
                btnCancelEdit.Visible = true;
                teamEditing = (Team)lbTeams.SelectedItem;
                txtTeamName.Text = teamEditing.TeamName;
                if (teamEditing.TeamColors.Count > 0)
                {
                    lbColors.DataSource = teamEditing.TeamColors;
                }

            }
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var teamDeleting = (Team)lbTeams.SelectedItem;
            db.Teams.Remove(teamDeleting);
            db.SaveChanges();
            ShowTeams();
        }

        private void btnAddColor_Click(object sender, EventArgs e)
        {
            var editingTeam = (Team)lbTeams.SelectedItem;
            teamEditing.TeamColors.Add((Models.Color)cboColors.SelectedItem);
            db.SaveChanges();
            cboColors.SelectedIndex = -1;
            lbColors.DataSource = null;
            lbColors.DataSource = db.Colors.ToList();
        }
    }
}
