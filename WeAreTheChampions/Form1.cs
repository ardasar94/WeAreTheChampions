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
    }
}
