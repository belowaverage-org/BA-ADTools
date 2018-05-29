namespace BAADTools
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.filterBox = new System.Windows.Forms.TextBox();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusSpace = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutBelowAverageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutBAADToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.commonNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birthDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telephoneNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telephoneNumberToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.telephoneNumberToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mobileNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streetAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zipCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectADisplayAttributeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commonNameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.displayNameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.userNameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.distinguishedNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userPrincipleNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryServer = new System.ComponentModel.BackgroundWorker();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.statusBar.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.Location = new System.Drawing.Point(3, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(243, 351);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 3;
            // 
            // filterBox
            // 
            this.filterBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterBox.Location = new System.Drawing.Point(3, 28);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(243, 20);
            this.filterBox.TabIndex = 5;
            this.filterBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterBox_KeyPress);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbCount,
            this.statusSpace,
            this.progressBar});
            this.statusBar.Location = new System.Drawing.Point(0, 405);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(249, 22);
            this.statusBar.SizingGrip = false;
            this.statusBar.TabIndex = 6;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel1.Text = "Count:";
            // 
            // lbCount
            // 
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(13, 17);
            this.lbCount.Text = "0";
            // 
            // statusSpace
            // 
            this.statusSpace.Name = "statusSpace";
            this.statusSpace.Size = new System.Drawing.Size(76, 17);
            this.statusSpace.Spring = true;
            // 
            // progressBar
            // 
            this.progressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            this.progressBar.Step = 1;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 1);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(249, 24);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.documentationToolStripMenuItem,
            this.toolStripSeparator4,
            this.aboutBelowAverageToolStripMenuItem,
            this.aboutBAADToolsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Info";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(197, 22);
            this.toolStripMenuItem2.Text = "Status...";
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.documentationToolStripMenuItem.Text = "Documentation...";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(194, 6);
            // 
            // aboutBelowAverageToolStripMenuItem
            // 
            this.aboutBelowAverageToolStripMenuItem.Name = "aboutBelowAverageToolStripMenuItem";
            this.aboutBelowAverageToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.aboutBelowAverageToolStripMenuItem.Text = "About Below Average...";
            this.aboutBelowAverageToolStripMenuItem.Click += new System.EventHandler(this.aboutBelowAverageToolStripMenuItem_Click);
            // 
            // aboutBAADToolsToolStripMenuItem
            // 
            this.aboutBAADToolsToolStripMenuItem.Name = "aboutBAADToolsToolStripMenuItem";
            this.aboutBAADToolsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.aboutBAADToolsToolStripMenuItem.Text = "About BA-ADTools...";
            this.aboutBAADToolsToolStripMenuItem.Click += new System.EventHandler(this.aboutBAADToolsToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterOptionsToolStripMenuItem,
            this.displayOptionsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // filterOptionsToolStripMenuItem
            // 
            this.filterOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripMenuItem1,
            this.toolStripSeparator3,
            this.commonNameToolStripMenuItem,
            this.displayNameToolStripMenuItem,
            this.userNameToolStripMenuItem,
            this.emailAddressToolStripMenuItem,
            this.birthDateToolStripMenuItem,
            this.homePageToolStripMenuItem,
            this.telephoneNumberToolStripMenuItem,
            this.addressToolStripMenuItem,
            this.organizationToolStripMenuItem});
            this.filterOptionsToolStripMenuItem.Name = "filterOptionsToolStripMenuItem";
            this.filterOptionsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.filterOptionsToolStripMenuItem.Text = "Filter Options...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(195, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.toolStripMenuItem1.Text = "Select a filter attribute...";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(195, 6);
            // 
            // commonNameToolStripMenuItem
            // 
            this.commonNameToolStripMenuItem.Name = "commonNameToolStripMenuItem";
            this.commonNameToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.commonNameToolStripMenuItem.Text = "Common Name";
            // 
            // displayNameToolStripMenuItem
            // 
            this.displayNameToolStripMenuItem.Name = "displayNameToolStripMenuItem";
            this.displayNameToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.displayNameToolStripMenuItem.Text = "Display Name";
            // 
            // userNameToolStripMenuItem
            // 
            this.userNameToolStripMenuItem.Name = "userNameToolStripMenuItem";
            this.userNameToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.userNameToolStripMenuItem.Text = "User Name";
            // 
            // emailAddressToolStripMenuItem
            // 
            this.emailAddressToolStripMenuItem.Name = "emailAddressToolStripMenuItem";
            this.emailAddressToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.emailAddressToolStripMenuItem.Text = "Email Address";
            // 
            // birthDateToolStripMenuItem
            // 
            this.birthDateToolStripMenuItem.Name = "birthDateToolStripMenuItem";
            this.birthDateToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.birthDateToolStripMenuItem.Text = "Birth Date";
            // 
            // homePageToolStripMenuItem
            // 
            this.homePageToolStripMenuItem.Name = "homePageToolStripMenuItem";
            this.homePageToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.homePageToolStripMenuItem.Text = "Home Page";
            // 
            // telephoneNumberToolStripMenuItem
            // 
            this.telephoneNumberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.telephoneNumberToolStripMenuItem2,
            this.telephoneNumberToolStripMenuItem1,
            this.mobileNumberToolStripMenuItem});
            this.telephoneNumberToolStripMenuItem.Name = "telephoneNumberToolStripMenuItem";
            this.telephoneNumberToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.telephoneNumberToolStripMenuItem.Text = "Phone...";
            // 
            // telephoneNumberToolStripMenuItem2
            // 
            this.telephoneNumberToolStripMenuItem2.Name = "telephoneNumberToolStripMenuItem2";
            this.telephoneNumberToolStripMenuItem2.Size = new System.Drawing.Size(176, 22);
            this.telephoneNumberToolStripMenuItem2.Text = "Telephone Number";
            // 
            // telephoneNumberToolStripMenuItem1
            // 
            this.telephoneNumberToolStripMenuItem1.Name = "telephoneNumberToolStripMenuItem1";
            this.telephoneNumberToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.telephoneNumberToolStripMenuItem1.Text = "Home Number";
            // 
            // mobileNumberToolStripMenuItem
            // 
            this.mobileNumberToolStripMenuItem.Name = "mobileNumberToolStripMenuItem";
            this.mobileNumberToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.mobileNumberToolStripMenuItem.Text = "Mobile Number";
            // 
            // addressToolStripMenuItem
            // 
            this.addressToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countryToolStripMenuItem,
            this.stateToolStripMenuItem,
            this.streetAddressToolStripMenuItem,
            this.zipCodeToolStripMenuItem});
            this.addressToolStripMenuItem.Name = "addressToolStripMenuItem";
            this.addressToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.addressToolStripMenuItem.Text = "Address...";
            // 
            // countryToolStripMenuItem
            // 
            this.countryToolStripMenuItem.Name = "countryToolStripMenuItem";
            this.countryToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.countryToolStripMenuItem.Text = "Country";
            // 
            // stateToolStripMenuItem
            // 
            this.stateToolStripMenuItem.Name = "stateToolStripMenuItem";
            this.stateToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.stateToolStripMenuItem.Text = "State";
            // 
            // streetAddressToolStripMenuItem
            // 
            this.streetAddressToolStripMenuItem.Name = "streetAddressToolStripMenuItem";
            this.streetAddressToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.streetAddressToolStripMenuItem.Text = "Street Address";
            // 
            // zipCodeToolStripMenuItem
            // 
            this.zipCodeToolStripMenuItem.Name = "zipCodeToolStripMenuItem";
            this.zipCodeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.zipCodeToolStripMenuItem.Text = "Postal Code";
            // 
            // organizationToolStripMenuItem
            // 
            this.organizationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeIDToolStripMenuItem,
            this.departmentToolStripMenuItem,
            this.managerToolStripMenuItem,
            this.titleToolStripMenuItem});
            this.organizationToolStripMenuItem.Name = "organizationToolStripMenuItem";
            this.organizationToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.organizationToolStripMenuItem.Text = "Organization...";
            // 
            // employeeIDToolStripMenuItem
            // 
            this.employeeIDToolStripMenuItem.Name = "employeeIDToolStripMenuItem";
            this.employeeIDToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.employeeIDToolStripMenuItem.Text = "Employee ID";
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.departmentToolStripMenuItem.Text = "Department";
            // 
            // managerToolStripMenuItem
            // 
            this.managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            this.managerToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.managerToolStripMenuItem.Text = "Manager";
            // 
            // titleToolStripMenuItem
            // 
            this.titleToolStripMenuItem.Name = "titleToolStripMenuItem";
            this.titleToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.titleToolStripMenuItem.Text = "Title";
            // 
            // displayOptionsToolStripMenuItem
            // 
            this.displayOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectADisplayAttributeToolStripMenuItem,
            this.toolStripSeparator2,
            this.nameToolStripMenuItem,
            this.commonNameToolStripMenuItem1,
            this.displayNameToolStripMenuItem1,
            this.userNameToolStripMenuItem1,
            this.distinguishedNameToolStripMenuItem,
            this.userPrincipleNameToolStripMenuItem});
            this.displayOptionsToolStripMenuItem.Name = "displayOptionsToolStripMenuItem";
            this.displayOptionsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.displayOptionsToolStripMenuItem.Text = "Display Options...";
            // 
            // selectADisplayAttributeToolStripMenuItem
            // 
            this.selectADisplayAttributeToolStripMenuItem.Enabled = false;
            this.selectADisplayAttributeToolStripMenuItem.Name = "selectADisplayAttributeToolStripMenuItem";
            this.selectADisplayAttributeToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.selectADisplayAttributeToolStripMenuItem.Text = "Select a display attribute...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(208, 6);
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.nameToolStripMenuItem.Text = "Name";
            // 
            // commonNameToolStripMenuItem1
            // 
            this.commonNameToolStripMenuItem1.Name = "commonNameToolStripMenuItem1";
            this.commonNameToolStripMenuItem1.Size = new System.Drawing.Size(211, 22);
            this.commonNameToolStripMenuItem1.Text = "Common Name";
            // 
            // displayNameToolStripMenuItem1
            // 
            this.displayNameToolStripMenuItem1.Name = "displayNameToolStripMenuItem1";
            this.displayNameToolStripMenuItem1.Size = new System.Drawing.Size(211, 22);
            this.displayNameToolStripMenuItem1.Text = "Display Name";
            // 
            // userNameToolStripMenuItem1
            // 
            this.userNameToolStripMenuItem1.Name = "userNameToolStripMenuItem1";
            this.userNameToolStripMenuItem1.Size = new System.Drawing.Size(211, 22);
            this.userNameToolStripMenuItem1.Text = "User Name";
            // 
            // distinguishedNameToolStripMenuItem
            // 
            this.distinguishedNameToolStripMenuItem.Name = "distinguishedNameToolStripMenuItem";
            this.distinguishedNameToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.distinguishedNameToolStripMenuItem.Text = "Distinguished Name";
            // 
            // userPrincipleNameToolStripMenuItem
            // 
            this.userPrincipleNameToolStripMenuItem.Name = "userPrincipleNameToolStripMenuItem";
            this.userPrincipleNameToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.userPrincipleNameToolStripMenuItem.Text = "User Principle Name";
            // 
            // queryServer
            // 
            this.queryServer.WorkerReportsProgress = true;
            this.queryServer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.queryServer_DoWork);
            this.queryServer.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.queryServer_ProgressChanged);
            this.queryServer.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.queryServer_RunWorkerCompleted);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(249, 427);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BA-ADTools";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox filterBox;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lbCount;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel statusSpace;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.ComponentModel.BackgroundWorker queryServer;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem commonNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birthDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telephoneNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telephoneNumberToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem telephoneNumberToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mobileNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streetAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zipCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectADisplayAttributeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commonNameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem displayNameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem userNameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem distinguishedNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userPrincipleNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem aboutBelowAverageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutBAADToolsToolStripMenuItem;
    }
}

