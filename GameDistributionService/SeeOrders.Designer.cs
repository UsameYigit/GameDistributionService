
namespace GameDistributionService
{
    partial class SeeOrders
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
            this.gbTotalIncome = new System.Windows.Forms.GroupBox();
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.gbDLCIncome = new System.Windows.Forms.GroupBox();
            this.lblDLCIncome = new System.Windows.Forms.Label();
            this.gbProductsSold = new System.Windows.Forms.GroupBox();
            this.lblProductsSold = new System.Windows.Forms.Label();
            this.lblAllOrders = new System.Windows.Forms.Label();
            this.lvAllOrders = new System.Windows.Forms.ListView();
            this.clmQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmGameName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmGameEdition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmOrderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmGamePublisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDLCs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmOrderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbTotalIncome.SuspendLayout();
            this.gbDLCIncome.SuspendLayout();
            this.gbProductsSold.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTotalIncome
            // 
            this.gbTotalIncome.Controls.Add(this.lblTotalIncome);
            this.gbTotalIncome.Location = new System.Drawing.Point(512, 35);
            this.gbTotalIncome.Name = "gbTotalIncome";
            this.gbTotalIncome.Size = new System.Drawing.Size(176, 89);
            this.gbTotalIncome.TabIndex = 1;
            this.gbTotalIncome.TabStop = false;
            this.gbTotalIncome.Text = "Total Income";
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.Location = new System.Drawing.Point(38, 34);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(0, 13);
            this.lblTotalIncome.TabIndex = 0;
            // 
            // gbDLCIncome
            // 
            this.gbDLCIncome.Controls.Add(this.lblDLCIncome);
            this.gbDLCIncome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbDLCIncome.Location = new System.Drawing.Point(512, 154);
            this.gbDLCIncome.Name = "gbDLCIncome";
            this.gbDLCIncome.Size = new System.Drawing.Size(176, 89);
            this.gbDLCIncome.TabIndex = 2;
            this.gbDLCIncome.TabStop = false;
            this.gbDLCIncome.Text = "DLC Income";
            // 
            // lblDLCIncome
            // 
            this.lblDLCIncome.AutoSize = true;
            this.lblDLCIncome.Location = new System.Drawing.Point(38, 46);
            this.lblDLCIncome.Name = "lblDLCIncome";
            this.lblDLCIncome.Size = new System.Drawing.Size(0, 13);
            this.lblDLCIncome.TabIndex = 1;
            // 
            // gbProductsSold
            // 
            this.gbProductsSold.Controls.Add(this.lblProductsSold);
            this.gbProductsSold.Location = new System.Drawing.Point(512, 278);
            this.gbProductsSold.Name = "gbProductsSold";
            this.gbProductsSold.Size = new System.Drawing.Size(176, 89);
            this.gbProductsSold.TabIndex = 3;
            this.gbProductsSold.TabStop = false;
            this.gbProductsSold.Text = "Products Sold";
            // 
            // lblProductsSold
            // 
            this.lblProductsSold.AutoSize = true;
            this.lblProductsSold.Location = new System.Drawing.Point(38, 43);
            this.lblProductsSold.Name = "lblProductsSold";
            this.lblProductsSold.Size = new System.Drawing.Size(0, 13);
            this.lblProductsSold.TabIndex = 2;
            // 
            // lblAllOrders
            // 
            this.lblAllOrders.AutoSize = true;
            this.lblAllOrders.Location = new System.Drawing.Point(37, 13);
            this.lblAllOrders.Name = "lblAllOrders";
            this.lblAllOrders.Size = new System.Drawing.Size(52, 13);
            this.lblAllOrders.TabIndex = 4;
            this.lblAllOrders.Text = "All Orders";
            // 
            // lvAllOrders
            // 
            this.lvAllOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmQuantity,
            this.clmGameName,
            this.clmGameEdition,
            this.clmOrderPrice,
            this.clmGamePublisher,
            this.clmDLCs,
            this.clmOrderTime});
            this.lvAllOrders.FullRowSelect = true;
            this.lvAllOrders.Location = new System.Drawing.Point(40, 35);
            this.lvAllOrders.MultiSelect = false;
            this.lvAllOrders.Name = "lvAllOrders";
            this.lvAllOrders.Size = new System.Drawing.Size(424, 329);
            this.lvAllOrders.TabIndex = 17;
            this.lvAllOrders.UseCompatibleStateImageBehavior = false;
            this.lvAllOrders.View = System.Windows.Forms.View.Details;
            // 
            // clmQuantity
            // 
            this.clmQuantity.Text = "Quantity";
            // 
            // clmGameName
            // 
            this.clmGameName.Text = "Game Name";
            // 
            // clmGameEdition
            // 
            this.clmGameEdition.Text = "Game Edition";
            // 
            // clmOrderPrice
            // 
            this.clmOrderPrice.Text = "Order Price";
            // 
            // clmGamePublisher
            // 
            this.clmGamePublisher.Text = "Publisher";
            // 
            // clmDLCs
            // 
            this.clmDLCs.Text = "DLCs";
            // 
            // clmOrderTime
            // 
            this.clmOrderTime.Text = "Order Time";
            // 
            // SeeOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvAllOrders);
            this.Controls.Add(this.lblAllOrders);
            this.Controls.Add(this.gbProductsSold);
            this.Controls.Add(this.gbDLCIncome);
            this.Controls.Add(this.gbTotalIncome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeeOrders";
            this.Text = "SeeOrders";
            this.Load += new System.EventHandler(this.SeeOrders_Load);
            this.gbTotalIncome.ResumeLayout(false);
            this.gbTotalIncome.PerformLayout();
            this.gbDLCIncome.ResumeLayout(false);
            this.gbDLCIncome.PerformLayout();
            this.gbProductsSold.ResumeLayout(false);
            this.gbProductsSold.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbTotalIncome;
        private System.Windows.Forms.GroupBox gbDLCIncome;
        private System.Windows.Forms.GroupBox gbProductsSold;
        private System.Windows.Forms.Label lblTotalIncome;
        private System.Windows.Forms.Label lblDLCIncome;
        private System.Windows.Forms.Label lblProductsSold;
        private System.Windows.Forms.Label lblAllOrders;
        private System.Windows.Forms.ListView lvAllOrders;
        private System.Windows.Forms.ColumnHeader clmQuantity;
        private System.Windows.Forms.ColumnHeader clmGameName;
        private System.Windows.Forms.ColumnHeader clmGameEdition;
        private System.Windows.Forms.ColumnHeader clmOrderPrice;
        private System.Windows.Forms.ColumnHeader clmGamePublisher;
        private System.Windows.Forms.ColumnHeader clmDLCs;
        private System.Windows.Forms.ColumnHeader clmOrderTime;
    }
}