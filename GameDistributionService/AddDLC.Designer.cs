
namespace GameDistributionService
{
    partial class AddDLC
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
            this.btnAddDLC = new System.Windows.Forms.Button();
            this.txtDLCName = new System.Windows.Forms.TextBox();
            this.lblDLCName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.combGame = new System.Windows.Forms.ComboBox();
            this.lblGameName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddDLC
            // 
            this.btnAddDLC.Location = new System.Drawing.Point(102, 256);
            this.btnAddDLC.Name = "btnAddDLC";
            this.btnAddDLC.Size = new System.Drawing.Size(120, 23);
            this.btnAddDLC.TabIndex = 0;
            this.btnAddDLC.Text = "Add DLC";
            this.btnAddDLC.UseVisualStyleBackColor = true;
            this.btnAddDLC.Click += new System.EventHandler(this.btnAddDLC_Click);
            // 
            // txtDLCName
            // 
            this.txtDLCName.Location = new System.Drawing.Point(102, 64);
            this.txtDLCName.Name = "txtDLCName";
            this.txtDLCName.Size = new System.Drawing.Size(120, 20);
            this.txtDLCName.TabIndex = 1;
            // 
            // lblDLCName
            // 
            this.lblDLCName.AutoSize = true;
            this.lblDLCName.Location = new System.Drawing.Point(102, 27);
            this.lblDLCName.Name = "lblDLCName";
            this.lblDLCName.Size = new System.Drawing.Size(59, 13);
            this.lblDLCName.TabIndex = 4;
            this.lblDLCName.Text = "DLC Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(102, 165);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPrice.Location = new System.Drawing.Point(102, 194);
            this.nudPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(120, 20);
            this.nudPrice.TabIndex = 6;
            this.nudPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // combGame
            // 
            this.combGame.FormattingEnabled = true;
            this.combGame.Location = new System.Drawing.Point(102, 130);
            this.combGame.Name = "combGame";
            this.combGame.Size = new System.Drawing.Size(120, 21);
            this.combGame.TabIndex = 21;
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Location = new System.Drawing.Point(102, 104);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(66, 13);
            this.lblGameName.TabIndex = 22;
            this.lblGameName.Text = "Game Name";
            // 
            // AddDLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 325);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.combGame);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDLCName);
            this.Controls.Add(this.txtDLCName);
            this.Controls.Add(this.btnAddDLC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDLC";
            this.Text = "AddDLC";
            this.Load += new System.EventHandler(this.AddDLC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddDLC;
        private System.Windows.Forms.TextBox txtDLCName;
        private System.Windows.Forms.Label lblDLCName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.ComboBox combGame;
        private System.Windows.Forms.Label lblGameName;
    }
}