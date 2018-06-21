namespace BAADTools
{
    partial class userForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.DNLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requirePassChangeNextLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expirationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setExpirationDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearExpirationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lockoutStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePhoneNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameLb = new System.Windows.Forms.Label();
            this.usernameLb = new System.Windows.Forms.Label();
            this.backgroundProc = new System.ComponentModel.BackgroundWorker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pChangeLight = new System.Windows.Forms.Label();
            this.expiredLight = new System.Windows.Forms.Label();
            this.lockoutLight = new System.Windows.Forms.Label();
            this.enabledLight = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.countryBox = new System.Windows.Forms.TextBox();
            this.stateBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.snBox = new System.Windows.Forms.TextBox();
            this.initialsBox = new System.Windows.Forms.TextBox();
            this.givenNameBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.logonCountBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.badLogonBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lastLogonBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lastPwBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lastModifiedBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.creationDateBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DNLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 407);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(914, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 0;
            // 
            // DNLabel
            // 
            this.DNLabel.AutoToolTip = true;
            this.DNLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DNLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNLabel.Name = "DNLabel";
            this.DNLabel.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.DNLabel.Size = new System.Drawing.Size(899, 17);
            this.DNLabel.Spring = true;
            this.DNLabel.Text = "...";
            this.DNLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.ErrorImage = null;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(827, 7);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(80, 80);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.groupToolStripMenuItem,
            this.manageToolStripMenuItem,
            this.personalToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(384, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.Visible = false;
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.refreshToolStripMenuItem.Text = "Refresh... (F5)";
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.groupToolStripMenuItem.Text = "Group Management...";
            this.groupToolStripMenuItem.Click += new System.EventHandler(this.groupToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disableUserToolStripMenuItem,
            this.passwordToolStripMenuItem,
            this.expirationToolStripMenuItem,
            this.lockoutStatusToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.manageToolStripMenuItem.Text = "Account";
            // 
            // disableUserToolStripMenuItem
            // 
            this.disableUserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableAccountToolStripMenuItem,
            this.disableAccountToolStripMenuItem});
            this.disableUserToolStripMenuItem.Name = "disableUserToolStripMenuItem";
            this.disableUserToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.disableUserToolStripMenuItem.Text = "Account Status";
            // 
            // enableAccountToolStripMenuItem
            // 
            this.enableAccountToolStripMenuItem.Name = "enableAccountToolStripMenuItem";
            this.enableAccountToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.enableAccountToolStripMenuItem.Text = "Enable Account...";
            // 
            // disableAccountToolStripMenuItem
            // 
            this.disableAccountToolStripMenuItem.Name = "disableAccountToolStripMenuItem";
            this.disableAccountToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.disableAccountToolStripMenuItem.Text = "Disable Account...";
            // 
            // passwordToolStripMenuItem
            // 
            this.passwordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetPasswordToolStripMenuItem,
            this.requirePassChangeNextLoginToolStripMenuItem});
            this.passwordToolStripMenuItem.Name = "passwordToolStripMenuItem";
            this.passwordToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.passwordToolStripMenuItem.Text = "Password";
            // 
            // resetPasswordToolStripMenuItem
            // 
            this.resetPasswordToolStripMenuItem.Name = "resetPasswordToolStripMenuItem";
            this.resetPasswordToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.resetPasswordToolStripMenuItem.Text = "Reset Password...";
            // 
            // requirePassChangeNextLoginToolStripMenuItem
            // 
            this.requirePassChangeNextLoginToolStripMenuItem.Name = "requirePassChangeNextLoginToolStripMenuItem";
            this.requirePassChangeNextLoginToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.requirePassChangeNextLoginToolStripMenuItem.Text = "Require password change...";
            // 
            // expirationToolStripMenuItem
            // 
            this.expirationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setExpirationDateToolStripMenuItem,
            this.clearExpirationToolStripMenuItem});
            this.expirationToolStripMenuItem.Name = "expirationToolStripMenuItem";
            this.expirationToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.expirationToolStripMenuItem.Text = "Expiration";
            // 
            // setExpirationDateToolStripMenuItem
            // 
            this.setExpirationDateToolStripMenuItem.Name = "setExpirationDateToolStripMenuItem";
            this.setExpirationDateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setExpirationDateToolStripMenuItem.Text = "Set expiration date...";
            // 
            // clearExpirationToolStripMenuItem
            // 
            this.clearExpirationToolStripMenuItem.Name = "clearExpirationToolStripMenuItem";
            this.clearExpirationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearExpirationToolStripMenuItem.Text = "Clear expiration...";
            // 
            // lockoutStatusToolStripMenuItem
            // 
            this.lockoutStatusToolStripMenuItem.Name = "lockoutStatusToolStripMenuItem";
            this.lockoutStatusToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.lockoutStatusToolStripMenuItem.Text = "Unlock Account...";
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeNameToolStripMenuItem,
            this.changePhoneNumberToolStripMenuItem,
            this.changeEmailToolStripMenuItem,
            this.changeAddressToolStripMenuItem});
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.personalToolStripMenuItem.Text = "Personal";
            // 
            // changeNameToolStripMenuItem
            // 
            this.changeNameToolStripMenuItem.Name = "changeNameToolStripMenuItem";
            this.changeNameToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.changeNameToolStripMenuItem.Text = "Change name...";
            // 
            // changePhoneNumberToolStripMenuItem
            // 
            this.changePhoneNumberToolStripMenuItem.Name = "changePhoneNumberToolStripMenuItem";
            this.changePhoneNumberToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.changePhoneNumberToolStripMenuItem.Text = "Change phone number...";
            // 
            // changeEmailToolStripMenuItem
            // 
            this.changeEmailToolStripMenuItem.Name = "changeEmailToolStripMenuItem";
            this.changeEmailToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.changeEmailToolStripMenuItem.Text = "Change email...";
            // 
            // changeAddressToolStripMenuItem
            // 
            this.changeAddressToolStripMenuItem.Name = "changeAddressToolStripMenuItem";
            this.changeAddressToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.changeAddressToolStripMenuItem.Text = "Change address...";
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nameLb.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLb.Location = new System.Drawing.Point(4, 9);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(159, 37);
            this.nameLb.TabIndex = 3;
            this.nameLb.Text = "Please wait...";
            // 
            // usernameLb
            // 
            this.usernameLb.AutoSize = true;
            this.usernameLb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usernameLb.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLb.Location = new System.Drawing.Point(7, 49);
            this.usernameLb.Name = "usernameLb";
            this.usernameLb.Size = new System.Drawing.Size(102, 30);
            this.usernameLb.TabIndex = 7;
            this.usernameLb.Text = "Loading...";
            // 
            // backgroundProc
            // 
            this.backgroundProc.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundProc_DoWork);
            this.backgroundProc.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundProc_RunWorkerCompleted);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(870, 296);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pChangeLight);
            this.groupBox1.Controls.Add(this.expiredLight);
            this.groupBox1.Controls.Add(this.lockoutLight);
            this.groupBox1.Controls.Add(this.enabledLight);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 243);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Status";
            // 
            // pChangeLight
            // 
            this.pChangeLight.AutoSize = true;
            this.pChangeLight.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.pChangeLight.ForeColor = System.Drawing.Color.Silver;
            this.pChangeLight.Location = new System.Drawing.Point(240, 185);
            this.pChangeLight.Name = "pChangeLight";
            this.pChangeLight.Size = new System.Drawing.Size(25, 19);
            this.pChangeLight.TabIndex = 15;
            this.pChangeLight.Text = "n";
            // 
            // expiredLight
            // 
            this.expiredLight.AutoSize = true;
            this.expiredLight.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.expiredLight.ForeColor = System.Drawing.Color.Silver;
            this.expiredLight.Location = new System.Drawing.Point(240, 138);
            this.expiredLight.Name = "expiredLight";
            this.expiredLight.Size = new System.Drawing.Size(25, 19);
            this.expiredLight.TabIndex = 14;
            this.expiredLight.Text = "n";
            // 
            // lockoutLight
            // 
            this.lockoutLight.AutoSize = true;
            this.lockoutLight.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lockoutLight.ForeColor = System.Drawing.Color.Silver;
            this.lockoutLight.Location = new System.Drawing.Point(240, 92);
            this.lockoutLight.Name = "lockoutLight";
            this.lockoutLight.Size = new System.Drawing.Size(25, 19);
            this.lockoutLight.TabIndex = 13;
            this.lockoutLight.Text = "n";
            // 
            // enabledLight
            // 
            this.enabledLight.AutoSize = true;
            this.enabledLight.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.enabledLight.ForeColor = System.Drawing.Color.Silver;
            this.enabledLight.Location = new System.Drawing.Point(240, 42);
            this.enabledLight.Name = "enabledLight";
            this.enabledLight.Size = new System.Drawing.Size(25, 19);
            this.enabledLight.TabIndex = 12;
            this.enabledLight.Text = "n";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(8, 189);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(146, 15);
            this.label17.TabIndex = 9;
            this.label17.Text = "Password Expiration Status";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(8, 142);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(94, 15);
            this.label18.TabIndex = 8;
            this.label18.Text = "Expiration Status";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(8, 96);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 15);
            this.label19.TabIndex = 7;
            this.label19.Text = "Lockout Status";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(8, 46);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 15);
            this.label20.TabIndex = 6;
            this.label20.Text = "Enabled Status";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.countryBox);
            this.groupBox2.Controls.Add(this.stateBox);
            this.groupBox2.Controls.Add(this.addressBox);
            this.groupBox2.Controls.Add(this.emailBox);
            this.groupBox2.Controls.Add(this.numberBox);
            this.groupBox2.Controls.Add(this.snBox);
            this.groupBox2.Controls.Add(this.initialsBox);
            this.groupBox2.Controls.Add(this.givenNameBox);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(300, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 286);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personal";
            // 
            // countryBox
            // 
            this.countryBox.BackColor = System.Drawing.Color.White;
            this.countryBox.Location = new System.Drawing.Point(102, 249);
            this.countryBox.Name = "countryBox";
            this.countryBox.ReadOnly = true;
            this.countryBox.Size = new System.Drawing.Size(163, 25);
            this.countryBox.TabIndex = 15;
            // 
            // stateBox
            // 
            this.stateBox.BackColor = System.Drawing.Color.White;
            this.stateBox.Location = new System.Drawing.Point(102, 218);
            this.stateBox.Name = "stateBox";
            this.stateBox.ReadOnly = true;
            this.stateBox.Size = new System.Drawing.Size(163, 25);
            this.stateBox.TabIndex = 14;
            // 
            // addressBox
            // 
            this.addressBox.BackColor = System.Drawing.Color.White;
            this.addressBox.Location = new System.Drawing.Point(102, 186);
            this.addressBox.Name = "addressBox";
            this.addressBox.ReadOnly = true;
            this.addressBox.Size = new System.Drawing.Size(163, 25);
            this.addressBox.TabIndex = 13;
            // 
            // emailBox
            // 
            this.emailBox.BackColor = System.Drawing.Color.White;
            this.emailBox.Location = new System.Drawing.Point(102, 154);
            this.emailBox.Name = "emailBox";
            this.emailBox.ReadOnly = true;
            this.emailBox.Size = new System.Drawing.Size(163, 25);
            this.emailBox.TabIndex = 12;
            // 
            // numberBox
            // 
            this.numberBox.BackColor = System.Drawing.Color.White;
            this.numberBox.Location = new System.Drawing.Point(102, 122);
            this.numberBox.Name = "numberBox";
            this.numberBox.ReadOnly = true;
            this.numberBox.Size = new System.Drawing.Size(163, 25);
            this.numberBox.TabIndex = 11;
            // 
            // snBox
            // 
            this.snBox.BackColor = System.Drawing.Color.White;
            this.snBox.Location = new System.Drawing.Point(102, 90);
            this.snBox.Name = "snBox";
            this.snBox.ReadOnly = true;
            this.snBox.Size = new System.Drawing.Size(163, 25);
            this.snBox.TabIndex = 10;
            // 
            // initialsBox
            // 
            this.initialsBox.BackColor = System.Drawing.Color.White;
            this.initialsBox.Location = new System.Drawing.Point(102, 58);
            this.initialsBox.Name = "initialsBox";
            this.initialsBox.ReadOnly = true;
            this.initialsBox.Size = new System.Drawing.Size(163, 25);
            this.initialsBox.TabIndex = 9;
            // 
            // givenNameBox
            // 
            this.givenNameBox.BackColor = System.Drawing.Color.White;
            this.givenNameBox.Location = new System.Drawing.Point(102, 27);
            this.givenNameBox.Name = "givenNameBox";
            this.givenNameBox.ReadOnly = true;
            this.givenNameBox.Size = new System.Drawing.Size(163, 25);
            this.givenNameBox.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 252);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 15);
            this.label13.TabIndex = 7;
            this.label13.Text = "Country";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 15);
            this.label12.TabIndex = 6;
            this.label12.Text = "State";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 15);
            this.label11.TabIndex = 5;
            this.label11.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Initials";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.logonCountBox);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.badLogonBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lastLogonBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lastPwBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lastModifiedBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.creationDateBox);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(590, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 225);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Details";
            // 
            // logonCountBox
            // 
            this.logonCountBox.BackColor = System.Drawing.Color.White;
            this.logonCountBox.Location = new System.Drawing.Point(100, 186);
            this.logonCountBox.Name = "logonCountBox";
            this.logonCountBox.ReadOnly = true;
            this.logonCountBox.Size = new System.Drawing.Size(165, 25);
            this.logonCountBox.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 157);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 15);
            this.label14.TabIndex = 5;
            this.label14.Text = "Last Bad Logon";
            // 
            // badLogonBox
            // 
            this.badLogonBox.BackColor = System.Drawing.Color.White;
            this.badLogonBox.Location = new System.Drawing.Point(100, 154);
            this.badLogonBox.Name = "badLogonBox";
            this.badLogonBox.ReadOnly = true;
            this.badLogonBox.Size = new System.Drawing.Size(165, 25);
            this.badLogonBox.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Logon Count";
            // 
            // lastLogonBox
            // 
            this.lastLogonBox.BackColor = System.Drawing.Color.White;
            this.lastLogonBox.Location = new System.Drawing.Point(100, 122);
            this.lastLogonBox.Name = "lastLogonBox";
            this.lastLogonBox.ReadOnly = true;
            this.lastLogonBox.Size = new System.Drawing.Size(165, 25);
            this.lastLogonBox.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Last Logon";
            // 
            // lastPwBox
            // 
            this.lastPwBox.BackColor = System.Drawing.Color.White;
            this.lastPwBox.Location = new System.Drawing.Point(100, 90);
            this.lastPwBox.Name = "lastPwBox";
            this.lastPwBox.ReadOnly = true;
            this.lastPwBox.Size = new System.Drawing.Size(165, 25);
            this.lastPwBox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Last PW Change";
            // 
            // lastModifiedBox
            // 
            this.lastModifiedBox.BackColor = System.Drawing.Color.White;
            this.lastModifiedBox.Location = new System.Drawing.Point(100, 58);
            this.lastModifiedBox.Name = "lastModifiedBox";
            this.lastModifiedBox.ReadOnly = true;
            this.lastModifiedBox.Size = new System.Drawing.Size(165, 25);
            this.lastModifiedBox.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Last Modified";
            // 
            // creationDateBox
            // 
            this.creationDateBox.BackColor = System.Drawing.Color.White;
            this.creationDateBox.Location = new System.Drawing.Point(100, 27);
            this.creationDateBox.Name = "creationDateBox";
            this.creationDateBox.ReadOnly = true;
            this.creationDateBox.Size = new System.Drawing.Size(165, 25);
            this.creationDateBox.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Creation Date";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 102);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 302F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(914, 305);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(914, 94);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // userForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 429);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.usernameLb);
            this.Controls.Add(this.nameLb);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "userForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Please wait...";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requirePassChangeNextLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expirationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setExpirationDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearExpirationToolStripMenuItem;
        private System.Windows.Forms.Label nameLb;
        private System.Windows.Forms.Label usernameLb;
        private System.Windows.Forms.ToolStripMenuItem lockoutStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePhoneNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel DNLabel;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundProc;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label pChangeLight;
        private System.Windows.Forms.Label expiredLight;
        private System.Windows.Forms.Label lockoutLight;
        private System.Windows.Forms.Label enabledLight;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox countryBox;
        private System.Windows.Forms.TextBox stateBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.TextBox snBox;
        private System.Windows.Forms.TextBox initialsBox;
        private System.Windows.Forms.TextBox givenNameBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox logonCountBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox badLogonBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lastLogonBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lastPwBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox lastModifiedBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox creationDateBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}