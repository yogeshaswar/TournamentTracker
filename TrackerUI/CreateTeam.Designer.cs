namespace TrackerUI
{
    partial class CreateTeam
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
            this.textBoxPlaceNumber = new System.Windows.Forms.TextBox();
            this.labelPlaceNumber = new System.Windows.Forms.Label();
            this.labelCreatePrize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPlaceNumber
            // 
            this.textBoxPlaceNumber.Location = new System.Drawing.Point(202, 144);
            this.textBoxPlaceNumber.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxPlaceNumber.Name = "textBoxPlaceNumber";
            this.textBoxPlaceNumber.Size = new System.Drawing.Size(416, 29);
            this.textBoxPlaceNumber.TabIndex = 4;
            this.textBoxPlaceNumber.TextChanged += new System.EventHandler(this.textBoxPlaceNumber_TextChanged);
            // 
            // labelPlaceNumber
            // 
            this.labelPlaceNumber.AutoSize = true;
            this.labelPlaceNumber.Location = new System.Drawing.Point(50, 144);
            this.labelPlaceNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPlaceNumber.Name = "labelPlaceNumber";
            this.labelPlaceNumber.Size = new System.Drawing.Size(131, 24);
            this.labelPlaceNumber.TabIndex = 2;
            this.labelPlaceNumber.Text = "Place Number";
            // 
            // labelCreatePrize
            // 
            this.labelCreatePrize.AutoSize = true;
            this.labelCreatePrize.Location = new System.Drawing.Point(50, 31);
            this.labelCreatePrize.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCreatePrize.Name = "labelCreatePrize";
            this.labelCreatePrize.Size = new System.Drawing.Size(112, 24);
            this.labelCreatePrize.TabIndex = 3;
            this.labelCreatePrize.Text = "Create Prize";
            // 
            // CreateTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 499);
            this.Controls.Add(this.textBoxPlaceNumber);
            this.Controls.Add(this.labelPlaceNumber);
            this.Controls.Add(this.labelCreatePrize);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CreateTeam";
            this.Text = "Create Team";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPlaceNumber;
        private System.Windows.Forms.Label labelPlaceNumber;
        private System.Windows.Forms.Label labelCreatePrize;
    }
}