
namespace GameDistributionService
{
    partial class StorePage
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
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddToCard = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnDiscardOrder = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblGameName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPlatinium = new System.Windows.Forms.RadioButton();
            this.rbGold = new System.Windows.Forms.RadioButton();
            this.rbStandard = new System.Windows.Forms.RadioButton();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lvGameList = new System.Windows.Forms.ListView();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPublisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPublisDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flpDLCs = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDLCs = new System.Windows.Forms.Label();
            this.lvOrders = new System.Windows.Forms.ListView();
            this.clmQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmGameName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmGameEdition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmOrderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmGamePublisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDLCs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmOrderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(458, 317);
            this.nudQuantity.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(120, 20);
            this.nudQuantity.TabIndex = 0;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnAddToCard
            // 
            this.btnAddToCard.Location = new System.Drawing.Point(470, 374);
            this.btnAddToCard.Name = "btnAddToCard";
            this.btnAddToCard.Size = new System.Drawing.Size(96, 23);
            this.btnAddToCard.TabIndex = 2;
            this.btnAddToCard.Text = "Add To Card";
            this.btnAddToCard.UseVisualStyleBackColor = true;
            this.btnAddToCard.Click += new System.EventHandler(this.btnAddToCard_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(975, 374);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(96, 23);
            this.btnPlaceOrder.TabIndex = 3;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnDiscardOrder
            // 
            this.btnDiscardOrder.Location = new System.Drawing.Point(699, 374);
            this.btnDiscardOrder.Name = "btnDiscardOrder";
            this.btnDiscardOrder.Size = new System.Drawing.Size(96, 23);
            this.btnDiscardOrder.TabIndex = 4;
            this.btnDiscardOrder.Text = "Discard Order";
            this.btnDiscardOrder.UseVisualStyleBackColor = true;
            this.btnDiscardOrder.Click += new System.EventHandler(this.btnDiscardOrder_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.Location = new System.Drawing.Point(474, 346);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 16);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price:";
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGameName.Location = new System.Drawing.Point(393, 23);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(108, 20);
            this.lblGameName.TabIndex = 7;
            this.lblGameName.Text = "Game Name";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuantity.Location = new System.Drawing.Point(458, 293);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(64, 16);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Quantity";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPlatinium);
            this.groupBox1.Controls.Add(this.rbGold);
            this.groupBox1.Controls.Add(this.rbStandard);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(397, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 91);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editions";
            // 
            // rbPlatinium
            // 
            this.rbPlatinium.AutoSize = true;
            this.rbPlatinium.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPlatinium.Location = new System.Drawing.Point(145, 44);
            this.rbPlatinium.Name = "rbPlatinium";
            this.rbPlatinium.Size = new System.Drawing.Size(67, 17);
            this.rbPlatinium.TabIndex = 2;
            this.rbPlatinium.Text = "Platinium";
            this.rbPlatinium.UseVisualStyleBackColor = true;
            this.rbPlatinium.CheckedChanged += new System.EventHandler(this.rbPlatinium_CheckedChanged);
            // 
            // rbGold
            // 
            this.rbGold.AutoSize = true;
            this.rbGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbGold.Location = new System.Drawing.Point(92, 44);
            this.rbGold.Name = "rbGold";
            this.rbGold.Size = new System.Drawing.Size(47, 17);
            this.rbGold.TabIndex = 1;
            this.rbGold.Text = "Gold";
            this.rbGold.UseVisualStyleBackColor = true;
            this.rbGold.CheckedChanged += new System.EventHandler(this.rbGold_CheckedChanged);
            // 
            // rbStandard
            // 
            this.rbStandard.AutoSize = true;
            this.rbStandard.Checked = true;
            this.rbStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbStandard.Location = new System.Drawing.Point(21, 44);
            this.rbStandard.Name = "rbStandard";
            this.rbStandard.Size = new System.Drawing.Size(68, 17);
            this.rbStandard.TabIndex = 0;
            this.rbStandard.TabStop = true;
            this.rbStandard.Text = "Standard";
            this.rbStandard.UseVisualStyleBackColor = true;
            this.rbStandard.CheckedChanged += new System.EventHandler(this.rbStandard_CheckedChanged);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPrice.Location = new System.Drawing.Point(816, 377);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(92, 16);
            this.lblTotalPrice.TabIndex = 12;
            this.lblTotalPrice.Text = "Total Price: ";
            // 
            // lvGameList
            // 
            this.lvGameList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmName,
            this.clmPrice,
            this.clmPublisher,
            this.clmPublisDate});
            this.lvGameList.FullRowSelect = true;
            this.lvGameList.HideSelection = false;
            this.lvGameList.Location = new System.Drawing.Point(12, 23);
            this.lvGameList.MultiSelect = false;
            this.lvGameList.Name = "lvGameList";
            this.lvGameList.Size = new System.Drawing.Size(362, 374);
            this.lvGameList.TabIndex = 13;
            this.lvGameList.UseCompatibleStateImageBehavior = false;
            this.lvGameList.View = System.Windows.Forms.View.Details;
            this.lvGameList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvGameList_ColumnClick);
            this.lvGameList.SelectedIndexChanged += new System.EventHandler(this.lvGameList_SelectedIndexChanged);
            // 
            // clmName
            // 
            this.clmName.Text = "Name";
            // 
            // clmPrice
            // 
            this.clmPrice.Text = "Price";
            // 
            // clmPublisher
            // 
            this.clmPublisher.Text = "Publisher";
            // 
            // clmPublisDate
            // 
            this.clmPublisDate.Text = "Publish Date";
            // 
            // flpDLCs
            // 
            this.flpDLCs.AutoScroll = true;
            this.flpDLCs.Location = new System.Drawing.Point(397, 190);
            this.flpDLCs.Name = "flpDLCs";
            this.flpDLCs.Size = new System.Drawing.Size(238, 100);
            this.flpDLCs.TabIndex = 14;
            // 
            // lblDLCs
            // 
            this.lblDLCs.AutoSize = true;
            this.lblDLCs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDLCs.Location = new System.Drawing.Point(405, 171);
            this.lblDLCs.Name = "lblDLCs";
            this.lblDLCs.Size = new System.Drawing.Size(45, 16);
            this.lblDLCs.TabIndex = 15;
            this.lblDLCs.Text = "DLCs";
            // 
            // lvOrders
            // 
            this.lvOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmQuantity,
            this.clmGameName,
            this.clmGameEdition,
            this.clmOrderPrice,
            this.clmGamePublisher,
            this.clmDLCs,
            this.clmOrderTime});
            this.lvOrders.FullRowSelect = true;
            this.lvOrders.HideSelection = false;
            this.lvOrders.Location = new System.Drawing.Point(669, 23);
            this.lvOrders.MultiSelect = false;
            this.lvOrders.Name = "lvOrders";
            this.lvOrders.Size = new System.Drawing.Size(424, 329);
            this.lvOrders.TabIndex = 16;
            this.lvOrders.UseCompatibleStateImageBehavior = false;
            this.lvOrders.View = System.Windows.Forms.View.Details;
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
            // StorePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 453);
            this.Controls.Add(this.lvOrders);
            this.Controls.Add(this.lblDLCs);
            this.Controls.Add(this.flpDLCs);
            this.Controls.Add(this.lvGameList);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnDiscardOrder);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnAddToCard);
            this.Controls.Add(this.nudQuantity);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StorePage";
            this.Text = "StorePage";
            this.Load += new System.EventHandler(this.StorePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Button btnAddToCard;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnDiscardOrder;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPlatinium;
        private System.Windows.Forms.RadioButton rbGold;
        private System.Windows.Forms.RadioButton rbStandard;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.ListView lvGameList;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmPrice;
        private System.Windows.Forms.ColumnHeader clmPublisher;
        private System.Windows.Forms.ColumnHeader clmPublisDate;
        private System.Windows.Forms.FlowLayoutPanel flpDLCs;
        private System.Windows.Forms.Label lblDLCs;
        private System.Windows.Forms.ListView lvOrders;
        private System.Windows.Forms.ColumnHeader clmQuantity;
        private System.Windows.Forms.ColumnHeader clmGameName;
        private System.Windows.Forms.ColumnHeader clmOrderPrice;
        private System.Windows.Forms.ColumnHeader clmOrderTime;
        private System.Windows.Forms.ColumnHeader clmDLCs;
        private System.Windows.Forms.ColumnHeader clmGameEdition;
        private System.Windows.Forms.ColumnHeader clmGamePublisher;
    }
}