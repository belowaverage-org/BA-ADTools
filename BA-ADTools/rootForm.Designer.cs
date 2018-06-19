namespace BAADTools
{
    partial class rootForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rootForm));
            this.treeView = new System.Windows.Forms.TreeView();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.topBtn = new System.Windows.Forms.Button();
            this.windowIcon = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.windowBody = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.borderColor = new System.Windows.Forms.PictureBox();
            this.titleBar = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.windowIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBar)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView.HideSelection = false;
            this.treeView.Location = new System.Drawing.Point(5, 25);
            this.treeView.Name = "treeView";
            this.treeView.ShowNodeToolTips = true;
            this.treeView.Size = new System.Drawing.Size(307, 549);
            this.treeView.TabIndex = 2;
            this.treeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_BeforeExpand);
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // saveBtn
            // 
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.saveBtn.Location = new System.Drawing.Point(238, 578);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cancelBtn.Location = new System.Drawing.Point(161, 578);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // topBtn
            // 
            this.topBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.topBtn.Location = new System.Drawing.Point(4, 578);
            this.topBtn.Name = "topBtn";
            this.topBtn.Size = new System.Drawing.Size(98, 23);
            this.topBtn.TabIndex = 3;
            this.topBtn.Text = "Select top level";
            this.topBtn.UseVisualStyleBackColor = true;
            this.topBtn.Click += new System.EventHandler(this.topBtn_Click);
            // 
            // windowIcon
            // 
            this.windowIcon.BackColor = System.Drawing.Color.White;
            this.windowIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("windowIcon.BackgroundImage")));
            this.windowIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.windowIcon.Location = new System.Drawing.Point(4, 4);
            this.windowIcon.Name = "windowIcon";
            this.windowIcon.Size = new System.Drawing.Size(18, 18);
            this.windowIcon.TabIndex = 4;
            this.windowIcon.TabStop = false;
            // 
            // windowBody
            // 
            this.windowBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.windowBody.BackColor = System.Drawing.Color.White;
            this.windowBody.Location = new System.Drawing.Point(1, 1);
            this.windowBody.Margin = new System.Windows.Forms.Padding(0);
            this.windowBody.Name = "windowBody";
            this.windowBody.Size = new System.Drawing.Size(315, 603);
            this.windowBody.TabIndex = 5;
            this.windowBody.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select a root OU...";
            // 
            // borderColor
            // 
            this.borderColor.BackColor = System.Drawing.Color.Silver;
            this.borderColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borderColor.Location = new System.Drawing.Point(0, 0);
            this.borderColor.Margin = new System.Windows.Forms.Padding(0);
            this.borderColor.Name = "borderColor";
            this.borderColor.Size = new System.Drawing.Size(317, 605);
            this.borderColor.TabIndex = 7;
            this.borderColor.TabStop = false;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.White;
            this.titleBar.Location = new System.Drawing.Point(5, 4);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(307, 18);
            this.titleBar.TabIndex = 8;
            this.titleBar.TabStop = false;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            this.titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseMove);
            this.titleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseUp);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.IndianRed;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(294, 4);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(18, 18);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // rootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(317, 605);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.windowIcon);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.topBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.windowBody);
            this.Controls.Add(this.borderColor);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rootForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select a working OU...";
            this.Load += new System.EventHandler(this.rootForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.windowIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button topBtn;
        private System.Windows.Forms.PictureBox windowIcon;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox windowBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox borderColor;
        private System.Windows.Forms.PictureBox titleBar;
        private System.Windows.Forms.Button exitButton;
    }
}