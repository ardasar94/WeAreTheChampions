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
    public partial class TeamPlayersForm : Form
    {
        WATCDbContext db;
        Team team;
        public TeamPlayersForm(WATCDbContext _db, Team _team)
        {
            team = _team;
            db = _db;
            InitializeComponent();
            lblTeamName.Text = team.TeamName;
            FillListBoxes();
        }

        private void FillListBoxes()
        {
            lbTeamPlayers.DataSource = db.Players.Where(x => x.Team.TeamName == team.TeamName).ToList();
            lbAllplayers.DataSource = db.Players.Where(x => x.Team.TeamName != team.TeamName).ToList();
        }

        private void btnAddPayer_Click(object sender, EventArgs e)
        {
            Player player = (Player)lbAllplayers.SelectedItem;
            player.Team = team;
            db.SaveChanges();
            FillListBoxes();
        }

        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            Player player = (Player)lbTeamPlayers.SelectedItem;
            player.Team = db.Teams.FirstOrDefault(x => x.TeamName == "unspecified");
            db.SaveChanges();
            FillListBoxes();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                FillListBoxes();
            }
            else
            {
                lbAllplayers.DataSource = db.Players.Where(x => x.Team.TeamName != team.TeamName && x.PlayerName.Contains(txtSearch.Text.Trim())).ToList();;
            }
        }
    }
}
