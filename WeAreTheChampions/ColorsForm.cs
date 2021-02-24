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
    public partial class ColorsForm : Form
    {
        WATCDbContext db;
        Models.Color changingColor;
        public ColorsForm(WATCDbContext _db)
        {
            db = _db;
            InitializeComponent();
            ShowColors();

        }

        private void ShowColors()
        {
            lbColors.DataSource = null;
            lbColors.DataSource = db.Colors.ToList();

        }

        private void btnAddColor_Click(object sender, EventArgs e)
        {
            if (txtColorName.Text.Trim() == "")
            {
                MessageBox.Show("Please Fill the Color Name.");
                return;
            }
            if (btnAddColor.Text == "Add Color")
            {
                db.Colors.Add(new Models.Color() { ColorName = txtColorName.Text.Trim(), Red = (int)nudRed.Value, Green = (int)nudGreen.Value, Blue = (int)nudBlue.Value });
            }
            else if (btnAddColor.Text == "Edit Color")
            {
                changingColor.ColorName = txtColorName.Text;
                changingColor.Red = (int)nudRed.Value;
                changingColor.Green = (int)nudGreen.Value;
                changingColor.Blue = (int)nudBlue.Value;
            }
            db.SaveChanges();
            CleanForm();
            ShowColors();
        }

        private void CleanForm()
        {
            btnAddColor.Text = "Add Color";
            nudRed.Value = 0;
            nudGreen.Value = 0;
            nudBlue.Value = 0;
            btnCancelEdit.Visible = false;
            txtColorName.Clear();
        }

        private void nudBlue_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown changingNud = (NumericUpDown)sender;
            pbPreview.BackColor = System.Drawing.Color.FromArgb((int)nudRed.Value, (int)nudGreen.Value, (int)nudBlue.Value);
        }

        private void btnEditColor_Click(object sender, EventArgs e)
        {
            btnAddColor.Text = "Edit Color";
            btnCancelEdit.Visible = true;
            changingColor = (Models.Color)lbColors.SelectedItem;
            txtColorName.Text = changingColor.ColorName;
            nudRed.Value = (decimal)changingColor.Red;
            nudGreen.Value = (decimal)changingColor.Green;
            nudBlue.Value = (decimal)changingColor.Blue;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var deletingColor = (Models.Color)lbColors.SelectedItem;
            db.Colors.Remove(deletingColor);
            db.SaveChanges();
            ShowColors();
            CleanForm();
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            CleanForm();
        }
    }
}
