namespace ABCreator
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.TxtDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmdSelectDirectory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtABCategoryName = new System.Windows.Forms.TextBox();
            this.LBCategories = new System.Windows.Forms.ListBox();
            this.CmdRemove = new System.Windows.Forms.Button();
            this.CmdRename = new System.Windows.Forms.Button();
            this.CmdExecute = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCADTemplate = new System.Windows.Forms.TextBox();
            this.CmdTemplateSelect = new System.Windows.Forms.Button();
            this.CmdATSelect = new System.Windows.Forms.Button();
            this.TxtATTemplate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LblEventLogTitle = new System.Windows.Forms.Label();
            this.LblLog = new System.Windows.Forms.TextBox();
            this.CmdAddStandard = new System.Windows.Forms.Button();
            this.TxtJobName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmdAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtDirectory
            // 
            this.TxtDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDirectory.Location = new System.Drawing.Point(15, 47);
            this.TxtDirectory.Name = "TxtDirectory";
            this.TxtDirectory.Size = new System.Drawing.Size(336, 22);
            this.TxtDirectory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parent Directory:";
            // 
            // CmdSelectDirectory
            // 
            this.CmdSelectDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdSelectDirectory.Location = new System.Drawing.Point(357, 47);
            this.CmdSelectDirectory.Name = "CmdSelectDirectory";
            this.CmdSelectDirectory.Size = new System.Drawing.Size(31, 22);
            this.CmdSelectDirectory.TabIndex = 2;
            this.CmdSelectDirectory.Text = "...";
            this.CmdSelectDirectory.UseVisualStyleBackColor = true;
            this.CmdSelectDirectory.Click += new System.EventHandler(this.DirectorySelection);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "As-Built Categories:";
            // 
            // TxtABCategoryName
            // 
            this.TxtABCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtABCategoryName.Location = new System.Drawing.Point(8, 185);
            this.TxtABCategoryName.Name = "TxtABCategoryName";
            this.TxtABCategoryName.Size = new System.Drawing.Size(299, 22);
            this.TxtABCategoryName.TabIndex = 4;
            this.TxtABCategoryName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CategoryKeyPress);
            // 
            // LBCategories
            // 
            this.LBCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBCategories.FormattingEnabled = true;
            this.LBCategories.ItemHeight = 16;
            this.LBCategories.Location = new System.Drawing.Point(8, 213);
            this.LBCategories.Name = "LBCategories";
            this.LBCategories.Size = new System.Drawing.Size(380, 164);
            this.LBCategories.TabIndex = 5;
            // 
            // CmdRemove
            // 
            this.CmdRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdRemove.Location = new System.Drawing.Point(313, 385);
            this.CmdRemove.Name = "CmdRemove";
            this.CmdRemove.Size = new System.Drawing.Size(75, 23);
            this.CmdRemove.TabIndex = 6;
            this.CmdRemove.Text = "Remove";
            this.CmdRemove.UseVisualStyleBackColor = true;
            this.CmdRemove.Click += new System.EventHandler(this.RemoveItem);
            // 
            // CmdRename
            // 
            this.CmdRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdRename.Location = new System.Drawing.Point(232, 385);
            this.CmdRename.Name = "CmdRename";
            this.CmdRename.Size = new System.Drawing.Size(75, 23);
            this.CmdRename.TabIndex = 7;
            this.CmdRename.Text = "Rename";
            this.CmdRename.UseVisualStyleBackColor = true;
            this.CmdRename.Click += new System.EventHandler(this.RenameItem);
            // 
            // CmdExecute
            // 
            this.CmdExecute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdExecute.Location = new System.Drawing.Point(12, 587);
            this.CmdExecute.Name = "CmdExecute";
            this.CmdExecute.Size = new System.Drawing.Size(380, 50);
            this.CmdExecute.TabIndex = 9;
            this.CmdExecute.Text = "Create As-Built Folders";
            this.CmdExecute.UseVisualStyleBackColor = true;
            this.CmdExecute.Click += new System.EventHandler(this.CreateFolders);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "CAD Template:";
            // 
            // TxtCADTemplate
            // 
            this.TxtCADTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCADTemplate.Location = new System.Drawing.Point(114, 103);
            this.TxtCADTemplate.Name = "TxtCADTemplate";
            this.TxtCADTemplate.Size = new System.Drawing.Size(237, 22);
            this.TxtCADTemplate.TabIndex = 12;
            // 
            // CmdTemplateSelect
            // 
            this.CmdTemplateSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdTemplateSelect.Location = new System.Drawing.Point(357, 103);
            this.CmdTemplateSelect.Name = "CmdTemplateSelect";
            this.CmdTemplateSelect.Size = new System.Drawing.Size(31, 22);
            this.CmdTemplateSelect.TabIndex = 13;
            this.CmdTemplateSelect.Text = "...";
            this.CmdTemplateSelect.UseVisualStyleBackColor = true;
            this.CmdTemplateSelect.Click += new System.EventHandler(this.DirectorySelection);
            // 
            // CmdATSelect
            // 
            this.CmdATSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdATSelect.Location = new System.Drawing.Point(357, 131);
            this.CmdATSelect.Name = "CmdATSelect";
            this.CmdATSelect.Size = new System.Drawing.Size(31, 22);
            this.CmdATSelect.TabIndex = 16;
            this.CmdATSelect.Text = "...";
            this.CmdATSelect.UseVisualStyleBackColor = true;
            this.CmdATSelect.Click += new System.EventHandler(this.DirectorySelection);
            // 
            // TxtATTemplate
            // 
            this.TxtATTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtATTemplate.Location = new System.Drawing.Point(114, 131);
            this.TxtATTemplate.Name = "TxtATTemplate";
            this.TxtATTemplate.Size = new System.Drawing.Size(237, 22);
            this.TxtATTemplate.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Asset Table:";
            // 
            // LblEventLogTitle
            // 
            this.LblEventLogTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblEventLogTitle.AutoSize = true;
            this.LblEventLogTitle.Location = new System.Drawing.Point(12, 398);
            this.LblEventLogTitle.Name = "LblEventLogTitle";
            this.LblEventLogTitle.Size = new System.Drawing.Size(71, 16);
            this.LblEventLogTitle.TabIndex = 17;
            this.LblEventLogTitle.Text = "Event Log:";
            // 
            // LblLog
            // 
            this.LblLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LblLog.Location = new System.Drawing.Point(12, 417);
            this.LblLog.Multiline = true;
            this.LblLog.Name = "LblLog";
            this.LblLog.ReadOnly = true;
            this.LblLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LblLog.Size = new System.Drawing.Size(380, 164);
            this.LblLog.TabIndex = 18;
            // 
            // CmdAddStandard
            // 
            this.CmdAddStandard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdAddStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAddStandard.Location = new System.Drawing.Point(313, 184);
            this.CmdAddStandard.Name = "CmdAddStandard";
            this.CmdAddStandard.Size = new System.Drawing.Size(75, 23);
            this.CmdAddStandard.TabIndex = 19;
            this.CmdAddStandard.Text = "Typical";
            this.CmdAddStandard.UseVisualStyleBackColor = true;
            this.CmdAddStandard.Click += new System.EventHandler(this.AddTypicalItems);
            // 
            // TxtJobName
            // 
            this.TxtJobName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtJobName.Location = new System.Drawing.Point(114, 75);
            this.TxtJobName.Name = "TxtJobName";
            this.TxtJobName.Size = new System.Drawing.Size(274, 22);
            this.TxtJobName.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Job Name:";
            // 
            // CmdAbout
            // 
            this.CmdAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAbout.Location = new System.Drawing.Point(317, 12);
            this.CmdAbout.Name = "CmdAbout";
            this.CmdAbout.Size = new System.Drawing.Size(75, 23);
            this.CmdAbout.TabIndex = 22;
            this.CmdAbout.Text = "About";
            this.CmdAbout.UseVisualStyleBackColor = true;
            this.CmdAbout.Click += new System.EventHandler(this.ShowAbout);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 649);
            this.Controls.Add(this.CmdAbout);
            this.Controls.Add(this.TxtJobName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmdAddStandard);
            this.Controls.Add(this.LblLog);
            this.Controls.Add(this.LblEventLogTitle);
            this.Controls.Add(this.CmdATSelect);
            this.Controls.Add(this.TxtATTemplate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmdTemplateSelect);
            this.Controls.Add(this.TxtCADTemplate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmdExecute);
            this.Controls.Add(this.CmdRename);
            this.Controls.Add(this.CmdRemove);
            this.Controls.Add(this.LBCategories);
            this.Controls.Add(this.TxtABCategoryName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmdSelectDirectory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDirectory);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InitForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdSelectDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtABCategoryName;
        private System.Windows.Forms.ListBox LBCategories;
        private System.Windows.Forms.Button CmdRemove;
        private System.Windows.Forms.Button CmdRename;
        private System.Windows.Forms.Button CmdExecute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCADTemplate;
        private System.Windows.Forms.Button CmdTemplateSelect;
        private System.Windows.Forms.Button CmdATSelect;
        private System.Windows.Forms.TextBox TxtATTemplate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblEventLogTitle;
        private System.Windows.Forms.TextBox LblLog;
        private System.Windows.Forms.Button CmdAddStandard;
        private System.Windows.Forms.TextBox TxtJobName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CmdAbout;
    }
}

