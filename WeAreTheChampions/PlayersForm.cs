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
    public partial class PlayersForm : Form
    {
        WATCDbContext db;
        public PlayersForm(WATCDbContext _db)
        {
            db = _db;
            InitializeComponent();
            dgvPlayers.AutoGenerateColumns = false;
            cboTeams.DataSource = db.Teams.ToList();
            CleanForm();
            ShowPlayers();
        }

        private void ShowPlayers()
        {
            dgvPlayers.DataSource = null;
            dgvPlayers.DataSource = db.Players.ToList();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            Player player;
            if (txtPlayerName.Text.Trim() == "")
            {
                MessageBox.Show("Please Fill the Player Name space");
                return;
            }
            if (btnAddPlayer.Text == "Add Player")
            {
                player = new Player();
                PlayerProps(player);

                db.Players.Add(player);               
            }
            else if (btnAddPlayer.Text == "Edit Player")
            {
                player = (Player)dgvPlayers.SelectedRows[0].DataBoundItem;
                PlayerProps(player);
            }
            db.SaveChanges();
            CleanForm();
            ShowPlayers();
        }

        private void PlayerProps(Player player)
        {
            player.PlayerName = txtPlayerName.Text.Trim();
            if (cboTeams.SelectedIndex != -1)
            {
                player.Team = (Team)cboTeams.SelectedItem;
            }
        }

        private void CleanForm()
        {
            cboTeams.SelectedIndex = 0;
            txtPlayerName.Clear();
            btnAddPlayer.Text = "Add Player";
            btnCancelEdit.Visible = false;
            dgvPlayers.Enabled = true;
        }

        private void btnEditPlayer_Click(object sender, EventArgs e)
        {
            Player player = (Player)dgvPlayers.SelectedRows[0].DataBoundItem;
            txtPlayerName.Text = player.PlayerName;
            cboTeams.SelectedItem = player.Team;
            btnCancelEdit.Visible = true;
            dgvPlayers.Enabled = false;
            btnAddPlayer.Text = "Edit Player";
        }

        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            Player player = (Player)dgvPlayers.SelectedRows[0].DataBoundItem;
            db.Players.Remove(player);
            db.SaveChanges();
            ShowPlayers();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                ShowPlayers();
            }
            else
            {
                dgvPlayers.DataSource = db.Players.Where(x => x.Team.TeamName.Contains(txtSearch.Text.Trim())).ToList();
            }
        }
    }
}
