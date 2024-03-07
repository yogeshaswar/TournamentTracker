namespace TrackerUI
{
    partial class TournamentViewer
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
            this.lableTournmentName = new System.Windows.Forms.Label();
            this.lableTournamentName = new System.Windows.Forms.Label();
            this.lableRound = new System.Windows.Forms.Label();
            this.comboBoxRoundList = new System.Windows.Forms.ComboBox();
            this.checkBoxUnplayed = new System.Windows.Forms.CheckBox();
            this.listBoxMatchup = new System.Windows.Forms.ListBox();
            this.labelTeamOneScore = new System.Windows.Forms.Label();
            this.labelS = new System.Windows.Forms.Label();
            this.textBoxTeamOneScore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lableTournmentName
            // 
            this.lableTournmentName.AutoSize = true;
            this.lableTournmentName.Location = new System.Drawing.Point(12, 9);
            this.lableTournmentName.Name = "lableTournmentName";
            this.lableTournmentName.Size = new System.Drawing.Size(128, 24);
            this.lableTournmentName.TabIndex = 0;
            this.lableTournmentName.Text = "Tournament : ";
            // 
            // lableTournamentName
            // 
            this.lableTournamentName.AutoSize = true;
            this.lableTournamentName.Location = new System.Drawing.Point(146, 9);
            this.lableTournamentName.Name = "lableTournamentName";
            this.lableTournamentName.Size = new System.Drawing.Size(80, 24);
            this.lableTournamentName.TabIndex = 0;
            this.lableTournamentName.Text = "<name>";
            // 
            // lableRound
            // 
            this.lableRound.AutoSize = true;
            this.lableRound.Location = new System.Drawing.Point(12, 46);
            this.lableRound.Name = "lableRound";
            this.lableRound.Size = new System.Drawing.Size(67, 24);
            this.lableRound.TabIndex = 0;
            this.lableRound.Text = "Round";
            // 
            // comboBoxRoundList
            // 
            this.comboBoxRoundList.FormattingEnabled = true;
            this.comboBoxRoundList.Location = new System.Drawing.Point(85, 43);
            this.comboBoxRoundList.Name = "comboBoxRoundList";
            this.comboBoxRoundList.Size = new System.Drawing.Size(211, 32);
            this.comboBoxRoundList.TabIndex = 2;
            // 
            // checkBoxUnplayed
            // 
            this.checkBoxUnplayed.AutoSize = true;
            this.checkBoxUnplayed.Location = new System.Drawing.Point(85, 81);
            this.checkBoxUnplayed.Name = "checkBoxUnplayed";
            this.checkBoxUnplayed.Size = new System.Drawing.Size(153, 28);
            this.checkBoxUnplayed.TabIndex = 3;
            this.checkBoxUnplayed.Text = "Unplayed Only";
            this.checkBoxUnplayed.UseVisualStyleBackColor = true;
            // 
            // listBoxMatchup
            // 
            this.listBoxMatchup.FormattingEnabled = true;
            this.listBoxMatchup.ItemHeight = 24;
            this.listBoxMatchup.Location = new System.Drawing.Point(20, 124);
            this.listBoxMatchup.Name = "listBoxMatchup";
            this.listBoxMatchup.Size = new System.Drawing.Size(276, 196);
            this.listBoxMatchup.TabIndex = 4;
            // 
            // labelTeamOneScore
            // 
            this.labelTeamOneScore.AutoSize = true;
            this.labelTeamOneScore.Location = new System.Drawing.Point(361, 124);
            this.labelTeamOneScore.Name = "labelTeamOneScore";
            this.labelTeamOneScore.Size = new System.Drawing.Size(111, 24);
            this.labelTeamOneScore.TabIndex = 0;
            this.labelTeamOneScore.Text = "<team one>";
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Location = new System.Drawing.Point(357, 165);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(60, 24);
            this.labelS.TabIndex = 0;
            this.labelS.Text = "Score";
            // 
            // textBoxTeamOneScore
            // 
            this.textBoxTeamOneScore.Location = new System.Drawing.Point(423, 165);
            this.textBoxTeamOneScore.Name = "textBoxTeamOneScore";
            this.textBoxTeamOneScore.Size = new System.Drawing.Size(119, 29);
            this.textBoxTeamOneScore.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "<team one>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Score";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(423, 291);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 29);
            this.textBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "-VS-";
            // 
            // buttonScore
            // 
            this.buttonScore.Location = new System.Drawing.Point(542, 207);
            this.buttonScore.Name = "buttonScore";
            this.buttonScore.Size = new System.Drawing.Size(85, 36);
            this.buttonScore.TabIndex = 6;
            this.buttonScore.Text = "Score";
            this.buttonScore.UseVisualStyleBackColor = true;
            // 
            // TournamentViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(809, 492);
            this.Controls.Add(this.buttonScore);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxTeamOneScore);
            this.Controls.Add(this.listBoxMatchup);
            this.Controls.Add(this.checkBoxUnplayed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelS);
            this.Controls.Add(this.comboBoxRoundList);
            this.Controls.Add(this.lableRound);
            this.Controls.Add(this.lableTournamentName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTeamOneScore);
            this.Controls.Add(this.lableTournmentName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TournamentViewer";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lableTournmentName;
        private System.Windows.Forms.Label lableTournamentName;
        private System.Windows.Forms.Label lableRound;
        private System.Windows.Forms.ComboBox comboBoxRoundList;
        private System.Windows.Forms.CheckBox checkBoxUnplayed;
        private System.Windows.Forms.ListBox listBoxMatchup;
        private System.Windows.Forms.Label labelTeamOneScore;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.TextBox textBoxTeamOneScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonScore;
    }
}

