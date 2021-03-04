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
    public partial class Form1 : Form
    {
        WATCDbContext db = new WATCDbContext();

        public Form1()
        {
            InitializeComponent();
            UnspecifiedTeam();
            dgvMatches.AutoGenerateColumns = false;
            CheckResults();
            FillDataGridView();
        }


        //https://stackoverflow.com/questions/10073319/returning-anonymous-type-in-c-sharp
        private void FillDataGridView()
        {
            var matches = db.Matches.ToList().Select(
                x => new
                {
                    MatchId = x.Id,
                    Team1 = x.Team1,
                    Team2 = x.Team2,
                    Date = x.MatchTime?.ToShortDateString(),
                    Time = x.MatchTime?.ToShortTimeString(),
                    Score = x.Score1 + "-" + x.Score2 + " (" + (x.MatchTime > DateTime.Now ? "Not start" : "Over") + ")",
                    MatchResult = x.Result
                });
            dgvMatches.DataSource = matches.ToList();
        }

        private void CheckResults()
        {
            var matches = db.Matches.ToList();
            foreach (Match match in matches)
            {
                if (match.Score1 > match.Score2)
                {
                    match.Result = Result.Team1;
                }
                else if (match.Score2 > match.Score1)
                {
                    match.Result = Result.Team2;
                }
                else if (match.Score2 == match.Score1)
                {
                    match.Result = Result.Tie;
                }
                else
                {
                    match.Result = null;
                }
                db.SaveChanges();
            }
        }

        private void UnspecifiedTeam()
        {
            if (db.Teams.Any(x => x.TeamName == "unspecified"))
            {
                return;
            }
            else
            {
                db.Teams.Add(new Team() { TeamName = "unspecified" });
                db.SaveChanges();
            }
            
        }

        private void tsmiTeams_Click(object sender, EventArgs e)
        {
            TeamsForm frmTeams = new TeamsForm(db);
            frmTeams.ShowDialog();
        }

        private void tsmiColors_Click(object sender, EventArgs e)
        {
            ColorsForm frmColors = new ColorsForm(db);
            frmColors.ShowDialog();
        }

        private void tsmiPlayers_Click(object sender, EventArgs e)
        {
            PlayersForm frmPlayers = new PlayersForm(db);
            frmPlayers.ShowDialog();
        }

        private void btnNewMatch_Click(object sender, EventArgs e)
        {
            NewMatchForm frmNewMatch = new NewMatchForm(db);
            frmNewMatch.ShowDialog();
            FillDataGridView();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMatches.SelectedRows.Count == 0)
            {
                return;
            }
            int matchId = (int)dgvMatches.SelectedRows[0].Cells[0].Value;
            Match match = db.Matches.ToList().FirstOrDefault(x => x.Id == matchId);
            db.Matches.Remove(match);
            db.SaveChanges();
            FillDataGridView();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMatches.SelectedRows.Count == 0)
            {
                return;
            }
            int matchId = (int)dgvMatches.SelectedRows[0].Cells[0].Value;
            Match match = db.Matches.ToList().FirstOrDefault(x => x.Id == matchId);
            EditMatchForm frmEditMatch = new EditMatchForm(db, match);
            frmEditMatch.ShowDialog();
            FillDataGridView();

        }
    }
}
