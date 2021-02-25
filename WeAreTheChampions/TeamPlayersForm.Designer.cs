
namespace WeAreTheChampions
{
    partial class TeamPlayersForm
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
            this.lblTeamName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTeamPlayers = new System.Windows.Forms.ListBox();
            this.btnDeletePlayer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddPayer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbAllplayers = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team Name:";
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTeamName.Location = new System.Drawing.Point(117, 9);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(53, 22);
            this.lblTeamName.TabIndex = 1;
            this.lblTeamName.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Team Players:";
            // 
            // lbTeamPlayers
            // 
            this.lbTeamPlayers.FormattingEnabled = true;
            this.lbTeamPlayers.ItemHeight = 20;
            this.lbTeamPlayers.Location = new System.Drawing.Point(16, 65);
            this.lbTeamPlayers.Name = "lbTeamPlayers";
            this.lbTeamPlayers.Size = new System.Drawing.Size(154, 244);
            this.lbTeamPlayers.TabIndex = 3;
            // 
            // btnDeletePlayer
            // 
            this.btnDeletePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePlayer.Location = new System.Drawing.Point(16, 315);
            this.btnDeletePlayer.Name = "btnDeletePlayer";
            this.btnDeletePlayer.Size = new System.Drawing.Size(154, 30);
            this.btnDeletePlayer.TabIndex = 4;
            this.btnDeletePlayer.Text = "Delete Selected";
            this.btnDeletePlayer.UseVisualStyleBackColor = true;
            this.btnDeletePlayer.Click += new System.EventHandler(this.btnDeletePlayer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.btnAddPayer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbAllplayers);
            this.groupBox1.Location = new System.Drawing.Point(176, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 315);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Player";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(69, 33);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(183, 20);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAddPayer
            // 
            this.btnAddPayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPayer.Location = new System.Drawing.Point(53, 275);
            this.btnAddPayer.Name = "btnAddPayer";
            this.btnAddPayer.Size = new System.Drawing.Size(154, 30);
            this.btnAddPayer.TabIndex = 6;
            this.btnAddPayer.Text = "Add Selected";
            this.btnAddPayer.UseVisualStyleBackColor = true;
            this.btnAddPayer.Click += new System.EventHandler(this.btnAddPayer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Search:";
            // 
            // lbAllplayers
            // 
            this.lbAllplayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAllplayers.FormattingEnabled = true;
            this.lbAllplayers.ItemHeight = 16;
            this.lbAllplayers.Location = new System.Drawing.Point(7, 57);
            this.lbAllplayers.Name = "lbAllplayers";
            this.lbAllplayers.Size = new System.Drawing.Size(245, 212);
            this.lbAllplayers.TabIndex = 0;
            // 
            // TeamPlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 383);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeletePlayer);
            this.Controls.Add(this.lbTeamPlayers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TeamPlayersForm";
            this.Text = "Team Players";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbTeamPlayers;
        private System.Windows.Forms.Button btnDeletePlayer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddPayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbAllplayers;
    }
}