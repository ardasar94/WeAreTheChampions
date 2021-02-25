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
    public partial class NewMatchForm : Form
    {
        WATCDbContext db;
        public NewMatchForm(WATCDbContext _db)
        {
            db = _db;
            InitializeComponent();

            cbTeam1.SelectedIndex = -1;
            cbTeam2.SelectedIndex = -1;
            cbTeam1.DataSource = db.Teams.Where(x => x.TeamName != "unspecified").ToList();
            cbTeam2.DataSource = db.Teams.Where(x => x.TeamName != "unspecified").ToList();
        }

        private void btnAddMatch_Click(object sender, EventArgs e)
        {
            if (cbTeam1.SelectedIndex == -1 || cbTeam2.SelectedIndex == -1 || cbTeam2.SelectedItem == cbTeam1.SelectedItem)
            {
                MessageBox.Show("Please choose the teams correctly");
                return;
            }

            else
            {
                DateTime date = new DateTime((int)nudYear.Value, (int)nudMonth.Value, (int)nudDay.Value, (int)nudHour.Value, (int)nudMinute.Value, 0);
                if (date < DateTime.Now)
                {
                    MessageBox.Show("Date is unacceptable");
                    return;
                }
                db.Matches.Add(new Match() { MatchTime = date, Team1 = (Team)cbTeam1.SelectedItem, Team2 = (Team)cbTeam2.SelectedItem });
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
