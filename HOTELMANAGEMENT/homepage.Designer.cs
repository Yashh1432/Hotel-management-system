namespace HOTELMANAGEMENT
{
    partial class homepage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mangeRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addroomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.mangeRoomToolStripMenuItem,
            this.manageCustomerToolStripMenuItem,
            this.checkoutToolStripMenuItem,
            this.viewBillToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(57, 26);
            this.loginToolStripMenuItem.Text = "login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // mangeRoomToolStripMenuItem
            // 
            this.mangeRoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addroomToolStripMenuItem,
            this.deleteRoomToolStripMenuItem,
            this.updateDetailsToolStripMenuItem});
            this.mangeRoomToolStripMenuItem.Name = "mangeRoomToolStripMenuItem";
            this.mangeRoomToolStripMenuItem.Size = new System.Drawing.Size(109, 26);
            this.mangeRoomToolStripMenuItem.Text = "mange room";
            this.mangeRoomToolStripMenuItem.Click += new System.EventHandler(this.mangeRoomToolStripMenuItem_Click);
            // 
            // addroomToolStripMenuItem
            // 
            this.addroomToolStripMenuItem.Name = "addroomToolStripMenuItem";
            this.addroomToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addroomToolStripMenuItem.Text = "addroom";
            // 
            // deleteRoomToolStripMenuItem
            // 
            this.deleteRoomToolStripMenuItem.Name = "deleteRoomToolStripMenuItem";
            this.deleteRoomToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deleteRoomToolStripMenuItem.Text = "delete room";
            // 
            // updateDetailsToolStripMenuItem
            // 
            this.updateDetailsToolStripMenuItem.Name = "updateDetailsToolStripMenuItem";
            this.updateDetailsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.updateDetailsToolStripMenuItem.Text = "update details";
            // 
            // manageCustomerToolStripMenuItem
            // 
            this.manageCustomerToolStripMenuItem.Name = "manageCustomerToolStripMenuItem";
            this.manageCustomerToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.manageCustomerToolStripMenuItem.Text = "manage customer";
            this.manageCustomerToolStripMenuItem.Click += new System.EventHandler(this.manageCustomerToolStripMenuItem_Click);
            // 
            // checkoutToolStripMenuItem
            // 
            this.checkoutToolStripMenuItem.Name = "checkoutToolStripMenuItem";
            this.checkoutToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.checkoutToolStripMenuItem.Text = "checkout";
            // 
            // viewBillToolStripMenuItem
            // 
            this.viewBillToolStripMenuItem.Name = "viewBillToolStripMenuItem";
            this.viewBillToolStripMenuItem.Size = new System.Drawing.Size(78, 26);
            this.viewBillToolStripMenuItem.Text = "view bill";
            // 
            // homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "homepage";
            this.Text = "homepage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mangeRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addroomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBillToolStripMenuItem;
    }
}