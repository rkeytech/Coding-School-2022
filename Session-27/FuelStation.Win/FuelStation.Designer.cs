namespace FuelStation.Win
{
    partial class FuelStation
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuButtonCustomersAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuButtonCustomersShow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuButtonItemsAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuButtonItemsShow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuButtonTransactionsAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuButtonTransactionsShow = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersToolStripMenuItem,
            this.itemsToolStripMenuItem,
            this.transactionsToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(126, 761);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuButtonCustomersAdd,
            this.menuButtonCustomersShow});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuButtonItemsAdd,
            this.menuButtonItemsShow});
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.itemsToolStripMenuItem.Text = "Items";
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuButtonTransactionsAdd,
            this.menuButtonTransactionsShow});
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // menuButtonCustomersAdd
            // 
            this.menuButtonCustomersAdd.Name = "menuButtonCustomersAdd";
            this.menuButtonCustomersAdd.Size = new System.Drawing.Size(103, 22);
            this.menuButtonCustomersAdd.Text = "Add";
            // 
            // menuButtonCustomersShow
            // 
            this.menuButtonCustomersShow.Name = "menuButtonCustomersShow";
            this.menuButtonCustomersShow.Size = new System.Drawing.Size(180, 22);
            this.menuButtonCustomersShow.Text = "Show";
            this.menuButtonCustomersShow.Click += new System.EventHandler(this.menuButtonCustomersShow_Click);
            // 
            // menuButtonItemsAdd
            // 
            this.menuButtonItemsAdd.Name = "menuButtonItemsAdd";
            this.menuButtonItemsAdd.Size = new System.Drawing.Size(180, 22);
            this.menuButtonItemsAdd.Text = "Add";
            // 
            // menuButtonItemsShow
            // 
            this.menuButtonItemsShow.Name = "menuButtonItemsShow";
            this.menuButtonItemsShow.Size = new System.Drawing.Size(180, 22);
            this.menuButtonItemsShow.Text = "Show";
            // 
            // menuButtonTransactionsAdd
            // 
            this.menuButtonTransactionsAdd.Name = "menuButtonTransactionsAdd";
            this.menuButtonTransactionsAdd.Size = new System.Drawing.Size(180, 22);
            this.menuButtonTransactionsAdd.Text = "Add";
            // 
            // menuButtonTransactionsShow
            // 
            this.menuButtonTransactionsShow.Name = "menuButtonTransactionsShow";
            this.menuButtonTransactionsShow.Size = new System.Drawing.Size(180, 22);
            this.menuButtonTransactionsShow.Text = "Show";
            // 
            // FuelStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "FuelStation";
            this.Text = "Fuel Station";
            this.Load += new System.EventHandler(this.FuelStation_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip mainMenu;
        private ToolStripMenuItem customersToolStripMenuItem;
        private ToolStripMenuItem itemsToolStripMenuItem;
        private ToolStripMenuItem transactionsToolStripMenuItem;
        private ToolStripMenuItem menuButtonCustomersAdd;
        private ToolStripMenuItem menuButtonCustomersShow;
        private ToolStripMenuItem menuButtonItemsAdd;
        private ToolStripMenuItem menuButtonItemsShow;
        private ToolStripMenuItem menuButtonTransactionsAdd;
        private ToolStripMenuItem menuButtonTransactionsShow;
    }
}