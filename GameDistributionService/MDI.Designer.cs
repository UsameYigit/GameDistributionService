
namespace GameDistributionService
{
    partial class MDI
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
            this.storePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPublisherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDLCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // storePageToolStripMenuItem
            // 
            this.storePageToolStripMenuItem.Name = "storePageToolStripMenuItem";
            this.storePageToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.storePageToolStripMenuItem.Text = "Store Page";
            this.storePageToolStripMenuItem.Click += new System.EventHandler(this.storePageToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storePageToolStripMenuItem,
            this.editGameToolStripMenuItem,
            this.seeOrdersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1164, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editGameToolStripMenuItem
            // 
            this.editGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addGameToolStripMenuItem,
            this.addPublisherToolStripMenuItem,
            this.addDLCToolStripMenuItem});
            this.editGameToolStripMenuItem.Name = "editGameToolStripMenuItem";
            this.editGameToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.editGameToolStripMenuItem.Text = "Edit Game";
            // 
            // addGameToolStripMenuItem
            // 
            this.addGameToolStripMenuItem.Name = "addGameToolStripMenuItem";
            this.addGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addGameToolStripMenuItem.Text = "Add Game";
            this.addGameToolStripMenuItem.Click += new System.EventHandler(this.addGameToolStripMenuItem_Click);
            // 
            // addPublisherToolStripMenuItem
            // 
            this.addPublisherToolStripMenuItem.Name = "addPublisherToolStripMenuItem";
            this.addPublisherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addPublisherToolStripMenuItem.Text = "Add Publisher";
            this.addPublisherToolStripMenuItem.Click += new System.EventHandler(this.addPublisherToolStripMenuItem_Click);
            // 
            // addDLCToolStripMenuItem
            // 
            this.addDLCToolStripMenuItem.Name = "addDLCToolStripMenuItem";
            this.addDLCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addDLCToolStripMenuItem.Text = "Add DLC";
            this.addDLCToolStripMenuItem.Click += new System.EventHandler(this.addDLCToolStripMenuItem_Click);
            // 
            // seeOrdersToolStripMenuItem
            // 
            this.seeOrdersToolStripMenuItem.Name = "seeOrdersToolStripMenuItem";
            this.seeOrdersToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.seeOrdersToolStripMenuItem.Text = "See Orders";
            this.seeOrdersToolStripMenuItem.Click += new System.EventHandler(this.seeOrdersToolStripMenuItem_Click);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 507);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem storePageToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPublisherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDLCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seeOrdersToolStripMenuItem;
    }
}

