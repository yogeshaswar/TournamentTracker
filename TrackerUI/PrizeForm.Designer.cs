namespace TrackerUI
{
    partial class PrizeForm
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
            this.labelCreatePrize = new System.Windows.Forms.Label();
            this.labelPlaceNumber = new System.Windows.Forms.Label();
            this.textBoxPlaceNumber = new System.Windows.Forms.TextBox();
            this.labelPlaceName = new System.Windows.Forms.Label();
            this.textBoxPlaceName = new System.Windows.Forms.TextBox();
            this.labelPrizeAmount = new System.Windows.Forms.Label();
            this.textBoxPrizeAmount = new System.Windows.Forms.TextBox();
            this.labelPrizePercentage = new System.Windows.Forms.Label();
            this.textBoxPrizePercentage = new System.Windows.Forms.TextBox();
            this.labelOr = new System.Windows.Forms.Label();
            this.buttonCreatePrize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCreatePrize
            // 
            this.labelCreatePrize.AutoSize = true;
            this.labelCreatePrize.Location = new System.Drawing.Point(24, 18);
            this.labelCreatePrize.Name = "labelCreatePrize";
            this.labelCreatePrize.Size = new System.Drawing.Size(112, 24);
            this.labelCreatePrize.TabIndex = 0;
            this.labelCreatePrize.Text = "Create Prize";
            // 
            // labelPlaceNumber
            // 
            this.labelPlaceNumber.AutoSize = true;
            this.labelPlaceNumber.Location = new System.Drawing.Point(24, 79);
            this.labelPlaceNumber.Name = "labelPlaceNumber";
            this.labelPlaceNumber.Size = new System.Drawing.Size(131, 24);
            this.labelPlaceNumber.TabIndex = 0;
            this.labelPlaceNumber.Text = "Place Number";
            // 
            // textBoxPlaceNumber
            // 
            this.textBoxPlaceNumber.Location = new System.Drawing.Point(204, 76);
            this.textBoxPlaceNumber.Name = "textBoxPlaceNumber";
            this.textBoxPlaceNumber.Size = new System.Drawing.Size(229, 29);
            this.textBoxPlaceNumber.TabIndex = 1;
            // 
            // labelPlaceName
            // 
            this.labelPlaceName.AutoSize = true;
            this.labelPlaceName.Location = new System.Drawing.Point(24, 129);
            this.labelPlaceName.Name = "labelPlaceName";
            this.labelPlaceName.Size = new System.Drawing.Size(113, 24);
            this.labelPlaceName.TabIndex = 0;
            this.labelPlaceName.Text = "Place Name";
            // 
            // textBoxPlaceName
            // 
            this.textBoxPlaceName.Location = new System.Drawing.Point(204, 126);
            this.textBoxPlaceName.Name = "textBoxPlaceName";
            this.textBoxPlaceName.Size = new System.Drawing.Size(229, 29);
            this.textBoxPlaceName.TabIndex = 1;
            // 
            // labelPrizeAmount
            // 
            this.labelPrizeAmount.AutoSize = true;
            this.labelPrizeAmount.Location = new System.Drawing.Point(24, 189);
            this.labelPrizeAmount.Name = "labelPrizeAmount";
            this.labelPrizeAmount.Size = new System.Drawing.Size(123, 24);
            this.labelPrizeAmount.TabIndex = 0;
            this.labelPrizeAmount.Text = "Prize Amount";
            // 
            // textBoxPrizeAmount
            // 
            this.textBoxPrizeAmount.Location = new System.Drawing.Point(204, 186);
            this.textBoxPrizeAmount.Name = "textBoxPrizeAmount";
            this.textBoxPrizeAmount.Size = new System.Drawing.Size(229, 29);
            this.textBoxPrizeAmount.TabIndex = 1;
            this.textBoxPrizeAmount.Text = "0";
            // 
            // labelPrizePercentage
            // 
            this.labelPrizePercentage.AutoSize = true;
            this.labelPrizePercentage.Location = new System.Drawing.Point(24, 284);
            this.labelPrizePercentage.Name = "labelPrizePercentage";
            this.labelPrizePercentage.Size = new System.Drawing.Size(154, 24);
            this.labelPrizePercentage.TabIndex = 0;
            this.labelPrizePercentage.Text = "Prize Percentage";
            // 
            // textBoxPrizePercentage
            // 
            this.textBoxPrizePercentage.Location = new System.Drawing.Point(204, 281);
            this.textBoxPrizePercentage.Name = "textBoxPrizePercentage";
            this.textBoxPrizePercentage.Size = new System.Drawing.Size(229, 29);
            this.textBoxPrizePercentage.TabIndex = 1;
            this.textBoxPrizePercentage.Text = "0";
            // 
            // labelOr
            // 
            this.labelOr.AutoSize = true;
            this.labelOr.Location = new System.Drawing.Point(200, 243);
            this.labelOr.Name = "labelOr";
            this.labelOr.Size = new System.Drawing.Size(50, 24);
            this.labelOr.TabIndex = 0;
            this.labelOr.Text = "-OR-";
            // 
            // buttonCreatePrize
            // 
            this.buttonCreatePrize.Location = new System.Drawing.Point(162, 361);
            this.buttonCreatePrize.Name = "buttonCreatePrize";
            this.buttonCreatePrize.Size = new System.Drawing.Size(145, 51);
            this.buttonCreatePrize.TabIndex = 2;
            this.buttonCreatePrize.Text = "Create Prize";
            this.buttonCreatePrize.UseVisualStyleBackColor = true;
            this.buttonCreatePrize.Click += new System.EventHandler(this.buttonCreatePrize_Click);
            // 
            // PrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 458);
            this.Controls.Add(this.buttonCreatePrize);
            this.Controls.Add(this.textBoxPrizePercentage);
            this.Controls.Add(this.labelPrizePercentage);
            this.Controls.Add(this.textBoxPrizeAmount);
            this.Controls.Add(this.labelOr);
            this.Controls.Add(this.labelPrizeAmount);
            this.Controls.Add(this.textBoxPlaceName);
            this.Controls.Add(this.labelPlaceName);
            this.Controls.Add(this.textBoxPlaceNumber);
            this.Controls.Add(this.labelPlaceNumber);
            this.Controls.Add(this.labelCreatePrize);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "PrizeForm";
            this.Text = "Prize Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCreatePrize;
        private System.Windows.Forms.Label labelPlaceNumber;
        private System.Windows.Forms.TextBox textBoxPlaceNumber;
        private System.Windows.Forms.Label labelPlaceName;
        private System.Windows.Forms.TextBox textBoxPlaceName;
        private System.Windows.Forms.Label labelPrizeAmount;
        private System.Windows.Forms.TextBox textBoxPrizeAmount;
        private System.Windows.Forms.Label labelPrizePercentage;
        private System.Windows.Forms.TextBox textBoxPrizePercentage;
        private System.Windows.Forms.Label labelOr;
        private System.Windows.Forms.Button buttonCreatePrize;
    }
}