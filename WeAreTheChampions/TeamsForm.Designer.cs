
namespace WeAreTheChampions
{
    partial class TeamsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnDeleteColor = new System.Windows.Forms.Button();
            this.btnAddColor = new System.Windows.Forms.Button();
            this.cboColors = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbColors = new System.Windows.Forms.ListBox();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOyuncular = new System.Windows.Forms.Button();
            this.btnEditTeam = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbTeams = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teams:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelEdit);
            this.groupBox1.Controls.Add(this.btnAddTeam);
            this.groupBox1.Controls.Add(this.btnDeleteColor);
            this.groupBox1.Controls.Add(this.btnAddColor);
            this.groupBox1.Controls.Add(this.cboColors);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbColors);
            this.groupBox1.Controls.Add(this.txtTeamName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(206, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 271);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit Team";
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEdit.Location = new System.Drawing.Point(136, 219);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(106, 37);
            this.btnCancelEdit.TabIndex = 10;
            this.btnCancelEdit.Text = "Cancel";
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            this.btnCancelEdit.Visible = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeam.Location = new System.Drawing.Point(262, 219);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(102, 37);
            this.btnAddTeam.TabIndex = 9;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // btnDeleteColor
            // 
            this.btnDeleteColor.Enabled = false;
            this.btnDeleteColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteColor.Location = new System.Drawing.Point(136, 92);
            this.btnDeleteColor.Name = "btnDeleteColor";
            this.btnDeleteColor.Size = new System.Drawing.Size(167, 26);
            this.btnDeleteColor.TabIndex = 7;
            this.btnDeleteColor.Text = "Delete Selected Color";
            this.btnDeleteColor.UseVisualStyleBackColor = true;
            // 
            // btnAddColor
            // 
            this.btnAddColor.Enabled = false;
            this.btnAddColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddColor.Location = new System.Drawing.Point(223, 63);
            this.btnAddColor.Name = "btnAddColor";
            this.btnAddColor.Size = new System.Drawing.Size(80, 23);
            this.btnAddColor.TabIndex = 6;
            this.btnAddColor.Text = "Add Color";
            this.btnAddColor.UseVisualStyleBackColor = true;
            this.btnAddColor.Click += new System.EventHandler(this.btnAddColor_Click);
            // 
            // cboColors
            // 
            this.cboColors.Enabled = false;
            this.cboColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboColors.FormattingEnabled = true;
            this.cboColors.Location = new System.Drawing.Point(137, 65);
            this.cboColors.Name = "cboColors";
            this.cboColors.Size = new System.Drawing.Size(80, 21);
            this.cboColors.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Add New Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Colors:";
            // 
            // lbColors
            // 
            this.lbColors.Enabled = false;
            this.lbColors.FormattingEnabled = true;
            this.lbColors.ItemHeight = 20;
            this.lbColors.Location = new System.Drawing.Point(6, 50);
            this.lbColors.Name = "lbColors";
            this.lbColors.Size = new System.Drawing.Size(120, 204);
            this.lbColors.TabIndex = 2;
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(136, 187);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(166, 26);
            this.txtTeamName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Team Name:";
            // 
            // btnOyuncular
            // 
            this.btnOyuncular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOyuncular.Location = new System.Drawing.Point(467, 313);
            this.btnOyuncular.Name = "btnOyuncular";
            this.btnOyuncular.Size = new System.Drawing.Size(120, 37);
            this.btnOyuncular.TabIndex = 8;
            this.btnOyuncular.Text = "Players";
            this.btnOyuncular.UseVisualStyleBackColor = true;
            // 
            // btnEditTeam
            // 
            this.btnEditTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTeam.Location = new System.Drawing.Point(196, 313);
            this.btnEditTeam.Name = "btnEditTeam";
            this.btnEditTeam.Size = new System.Drawing.Size(120, 37);
            this.btnEditTeam.TabIndex = 9;
            this.btnEditTeam.Text = "Edit Selected";
            this.btnEditTeam.UseVisualStyleBackColor = true;
            this.btnEditTeam.Click += new System.EventHandler(this.btnEditTeam_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(324, 313);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 37);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbTeams
            // 
            this.lbTeams.FormattingEnabled = true;
            this.lbTeams.ItemHeight = 20;
            this.lbTeams.Location = new System.Drawing.Point(17, 33);
            this.lbTeams.Name = "lbTeams";
            this.lbTeams.Size = new System.Drawing.Size(173, 324);
            this.lbTeams.TabIndex = 11;
            // 
            // TeamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 371);
            this.Controls.Add(this.lbTeams);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditTeam);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOyuncular);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TeamsForm";
            this.Text = "Teams";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOyuncular;
        private System.Windows.Forms.Button btnDeleteColor;
        private System.Windows.Forms.Button btnAddColor;
        private System.Windows.Forms.ComboBox cboColors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbColors;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Button btnEditTeam;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lbTeams;
    }
}