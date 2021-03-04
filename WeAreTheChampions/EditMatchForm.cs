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
    public partial class EditMatchForm : Form
    {
        WATCDbContext db;
        Match match;
        public EditMatchForm(WATCDbContext _db, Match _match)
        {
            db = _db;
            match = _match;
            InitializeComponent();
            FillForm();
        }

        private void FillForm()
        {
            cbTeam1.DataSource = db.Teams.Where(x => x.TeamName != "unspecified").ToList();
            cbTeam2.DataSource = db.Teams.Where(x => x.TeamName != "unspecified").ToList();
            DateTime date = (DateTime)match.MatchTime;
            cbTeam1.SelectedItem = match.Team1;
            cbTeam2.SelectedItem = match.Team2;
            nudHour.Value = (decimal)date.Hour;
            nudMinute.Value = (decimal)date.Minute;
            nudMonth.Value = (decimal)date.Month;
            nudDay.Value = (decimal)date.Day;
            nudYear.Value = (decimal)date.Year;
            nudTeam1Score.Value = (decimal)match.Score1;
            nudTeam2Score.Value = (decimal)match.Score2;

        }

        private void btnEditMatch_Click(object sender, EventArgs e)
        {
            if (cbTeam1.SelectedIndex == -1 || cbTeam2.SelectedIndex == -1 || cbTeam2.SelectedItem == cbTeam1.SelectedItem)
            {
                MessageBox.Show("Please choose the teams correctly");
                return;
            }

            DateTime date = new DateTime((int)nudYear.Value, (int)nudMonth.Value, (int)nudDay.Value, (int)nudHour.Value, (int)nudMinute.Value, 0);
            //if (date < DateTime.Now)
            //{
            //    MessageBox.Show("Date is unacceptable");
            //    return;
            //}
            match.Team1 = (Team)cbTeam1.SelectedItem;
            match.Team2 = (Team)cbTeam2.SelectedItem;
            match.Score1 = (int)nudTeam1Score.Value;
            match.Score2 = (int)nudTeam2Score.Value;
            match.MatchTime = date;
            db.SaveChanges();
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void cbTime_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTime.Checked)
            {
                nudDay.Enabled = true;
                nudMonth.Enabled = true;
                nudYear.Enabled = true;
                nudHour.Enabled = true;
                nudMinute.Enabled = true;
            }
            else if (!cbTime.Checked)
            {
                nudDay.Enabled = false;
                nudMonth.Enabled = false;
                nudYear.Enabled = false;
                nudHour.Enabled = false;
                nudMinute.Enabled = false;
            }
        }
    }
}
