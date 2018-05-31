namespace BAADTools
{
    partial class groupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(groupForm));
            this.groupsList1 = new System.Windows.Forms.ListView();
            this.cnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupList2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.applyBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.filterBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.bgInit = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // groupsList1
            // 
            this.groupsList1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.groupsList1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cnHeader,
            this.descHeader});
            this.groupsList1.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupsList1.FullRowSelect = true;
            this.groupsList1.Location = new System.Drawing.Point(7, 35);
            this.groupsList1.MultiSelect = false;
            this.groupsList1.Name = "groupsList1";
            this.groupsList1.ShowItemToolTips = true;
            this.groupsList1.Size = new System.Drawing.Size(332, 348);
            this.groupsList1.TabIndex = 0;
            this.groupsList1.UseCompatibleStateImageBehavior = false;
            this.groupsList1.View = System.Windows.Forms.View.Details;
            // 
            // cnHeader
            // 
            this.cnHeader.Text = "Name";
            this.cnHeader.Width = 150;
            // 
            // descHeader
            // 
            this.descHeader.Text = "Description";
            this.descHeader.Width = 160;
            // 
            // groupList2
            // 
            this.groupList2.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.groupList2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.groupList2.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupList2.FullRowSelect = true;
            this.groupList2.Location = new System.Drawing.Point(382, 35);
            this.groupList2.MultiSelect = false;
            this.groupList2.Name = "groupList2";
            this.groupList2.ShowItemToolTips = true;
            this.groupList2.Size = new System.Drawing.Size(330, 348);
            this.groupList2.TabIndex = 1;
            this.groupList2.UseCompatibleStateImageBehavior = false;
            this.groupList2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 160;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(345, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(345, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // applyBtn
            // 
            this.applyBtn.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyBtn.Location = new System.Drawing.Point(648, 388);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(64, 23);
            this.applyBtn.TabIndex = 4;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(578, 388);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(64, 23);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(508, 388);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(64, 23);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(7, 390);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(121, 21);
            this.progressBar.TabIndex = 7;
            // 
            // filterBox
            // 
            this.filterBox.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterBox.Location = new System.Drawing.Point(43, 6);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(669, 23);
            this.filterBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filter";
            // 
            // reloadBtn
            // 
            this.reloadBtn.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadBtn.Location = new System.Drawing.Point(382, 388);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(64, 23);
            this.reloadBtn.TabIndex = 10;
            this.reloadBtn.Text = "Reload";
            this.reloadBtn.UseVisualStyleBackColor = true;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Count:";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCount.Location = new System.Drawing.Point(176, 393);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(13, 15);
            this.lbCount.TabIndex = 12;
            this.lbCount.Text = "0";
            // 
            // bgInit
            // 
            this.bgInit.WorkerReportsProgress = true;
            this.bgInit.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgInit_DoWork);
            this.bgInit.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgInit_ProgressChanged);
            this.bgInit.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgInit_RunWorkerCompleted);
            // 
            // groupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(719, 417);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reloadBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupList2);
            this.Controls.Add(this.groupsList1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "groupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Group Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.groupForm_FormClosed);
            this.Load += new System.EventHandler(this.groupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView groupsList1;
        private System.Windows.Forms.ColumnHeader cnHeader;
        private System.Windows.Forms.ColumnHeader descHeader;
        private System.Windows.Forms.ListView groupList2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox filterBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCount;
        private System.ComponentModel.BackgroundWorker bgInit;
    }
}