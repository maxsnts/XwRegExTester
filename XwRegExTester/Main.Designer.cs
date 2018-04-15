namespace XwRegExTester
{
	partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.checkMultiline = new System.Windows.Forms.CheckBox();
            this.checkSpaces = new System.Windows.Forms.CheckBox();
            this.checkExtended = new System.Windows.Forms.CheckBox();
            this.checkIgnoreCasa = new System.Windows.Forms.CheckBox();
            this.checkGlobal = new System.Windows.Forms.CheckBox();
            this.autoExec = new System.Windows.Forms.CheckBox();
            this.textRegEx = new System.Windows.Forms.RichTextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.comboEncoding = new System.Windows.Forms.ComboBox();
            this.butClean = new System.Windows.Forms.Button();
            this.textSource = new System.Windows.Forms.RichTextBox();
            this.butLoadUrl = new System.Windows.Forms.Button();
            this.textURL = new System.Windows.Forms.TextBox();
            this.treeResult = new XwRegExTester.MyTreeView();
            this.ToolbarUpdates = new System.Windows.Forms.ToolStripButton();
            this.ToolbarSite = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.checkMultiline);
            this.splitContainer1.Panel1.Controls.Add(this.checkSpaces);
            this.splitContainer1.Panel1.Controls.Add(this.checkExtended);
            this.splitContainer1.Panel1.Controls.Add(this.checkIgnoreCasa);
            this.splitContainer1.Panel1.Controls.Add(this.checkGlobal);
            this.splitContainer1.Panel1.Controls.Add(this.autoExec);
            this.splitContainer1.Panel1.Controls.Add(this.textRegEx);
            this.splitContainer1.Panel1.Controls.Add(this.btnExecute);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(958, 731);
            this.splitContainer1.SplitterDistance = 259;
            this.splitContainer1.TabIndex = 0;
            // 
            // checkMultiline
            // 
            this.checkMultiline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkMultiline.AutoSize = true;
            this.checkMultiline.Location = new System.Drawing.Point(817, 189);
            this.checkMultiline.Name = "checkMultiline";
            this.checkMultiline.Size = new System.Drawing.Size(81, 17);
            this.checkMultiline.TabIndex = 5;
            this.checkMultiline.Text = "Multiline (m)";
            this.checkMultiline.UseVisualStyleBackColor = true;
            this.checkMultiline.Visible = false;
            // 
            // checkSpaces
            // 
            this.checkSpaces.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkSpaces.AutoSize = true;
            this.checkSpaces.Location = new System.Drawing.Point(817, 166);
            this.checkSpaces.Name = "checkSpaces";
            this.checkSpaces.Size = new System.Drawing.Size(68, 17);
            this.checkSpaces.TabIndex = 5;
            this.checkSpaces.Text = "DotAll (s)";
            this.checkSpaces.UseVisualStyleBackColor = true;
            this.checkSpaces.Visible = false;
            // 
            // checkExtended
            // 
            this.checkExtended.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkExtended.AutoSize = true;
            this.checkExtended.Location = new System.Drawing.Point(817, 143);
            this.checkExtended.Name = "checkExtended";
            this.checkExtended.Size = new System.Drawing.Size(85, 17);
            this.checkExtended.TabIndex = 5;
            this.checkExtended.Text = "Extended (x)";
            this.checkExtended.UseVisualStyleBackColor = true;
            this.checkExtended.Visible = false;
            // 
            // checkIgnoreCasa
            // 
            this.checkIgnoreCasa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkIgnoreCasa.AutoSize = true;
            this.checkIgnoreCasa.Location = new System.Drawing.Point(817, 120);
            this.checkIgnoreCasa.Name = "checkIgnoreCasa";
            this.checkIgnoreCasa.Size = new System.Drawing.Size(94, 17);
            this.checkIgnoreCasa.TabIndex = 5;
            this.checkIgnoreCasa.Text = "Ignore Case (i)";
            this.checkIgnoreCasa.UseVisualStyleBackColor = true;
            this.checkIgnoreCasa.Visible = false;
            // 
            // checkGlobal
            // 
            this.checkGlobal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkGlobal.AutoSize = true;
            this.checkGlobal.Location = new System.Drawing.Point(817, 97);
            this.checkGlobal.Name = "checkGlobal";
            this.checkGlobal.Size = new System.Drawing.Size(71, 17);
            this.checkGlobal.TabIndex = 5;
            this.checkGlobal.Text = "Global (g)";
            this.checkGlobal.UseVisualStyleBackColor = true;
            this.checkGlobal.Visible = false;
            // 
            // autoExec
            // 
            this.autoExec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.autoExec.AutoSize = true;
            this.autoExec.Location = new System.Drawing.Point(817, 74);
            this.autoExec.Name = "autoExec";
            this.autoExec.Size = new System.Drawing.Size(90, 17);
            this.autoExec.TabIndex = 5;
            this.autoExec.Text = "Auto Execute";
            this.autoExec.UseVisualStyleBackColor = true;
            // 
            // textRegEx
            // 
            this.textRegEx.AcceptsTab = true;
            this.textRegEx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textRegEx.AutoWordSelection = true;
            this.textRegEx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textRegEx.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRegEx.HideSelection = false;
            this.textRegEx.Location = new System.Drawing.Point(12, 12);
            this.textRegEx.Name = "textRegEx";
            this.textRegEx.Size = new System.Drawing.Size(799, 244);
            this.textRegEx.TabIndex = 0;
            this.textRegEx.Text = "";
            this.textRegEx.WordWrap = false;
            this.textRegEx.TextChanged += new System.EventHandler(this.textRegEx_TextChanged);
            this.textRegEx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textRegEx_KeyDown);
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecute.Location = new System.Drawing.Point(817, 12);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(129, 56);
            this.btnExecute.TabIndex = 3;
            this.btnExecute.Text = "Execute (F5)";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.comboEncoding);
            this.splitContainer2.Panel1.Controls.Add(this.butClean);
            this.splitContainer2.Panel1.Controls.Add(this.textSource);
            this.splitContainer2.Panel1.Controls.Add(this.butLoadUrl);
            this.splitContainer2.Panel1.Controls.Add(this.textURL);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.treeResult);
            this.splitContainer2.Size = new System.Drawing.Size(958, 468);
            this.splitContainer2.SplitterDistance = 577;
            this.splitContainer2.TabIndex = 0;
            // 
            // comboEncoding
            // 
            this.comboEncoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEncoding.FormattingEnabled = true;
            this.comboEncoding.Location = new System.Drawing.Point(336, 436);
            this.comboEncoding.Name = "comboEncoding";
            this.comboEncoding.Size = new System.Drawing.Size(157, 21);
            this.comboEncoding.TabIndex = 5;
            // 
            // butClean
            // 
            this.butClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butClean.Location = new System.Drawing.Point(12, 405);
            this.butClean.Name = "butClean";
            this.butClean.Size = new System.Drawing.Size(185, 23);
            this.butClean.TabIndex = 4;
            this.butClean.Text = "Remove Text outside Matches";
            this.butClean.UseVisualStyleBackColor = true;
            this.butClean.Click += new System.EventHandler(this.butClean_Click);
            // 
            // textSource
            // 
            this.textSource.AcceptsTab = true;
            this.textSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSource.DetectUrls = false;
            this.textSource.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSource.HideSelection = false;
            this.textSource.Location = new System.Drawing.Point(12, 0);
            this.textSource.Name = "textSource";
            this.textSource.Size = new System.Drawing.Size(562, 400);
            this.textSource.TabIndex = 3;
            this.textSource.Text = "";
            this.textSource.WordWrap = false;
            this.textSource.TextChanged += new System.EventHandler(this.textSource_TextChanged);
            this.textSource.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textRegEx_KeyDown);
            // 
            // butLoadUrl
            // 
            this.butLoadUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butLoadUrl.Location = new System.Drawing.Point(499, 435);
            this.butLoadUrl.Name = "butLoadUrl";
            this.butLoadUrl.Size = new System.Drawing.Size(75, 23);
            this.butLoadUrl.TabIndex = 2;
            this.butLoadUrl.Text = "Load URL";
            this.butLoadUrl.UseVisualStyleBackColor = true;
            this.butLoadUrl.Click += new System.EventHandler(this.butLoadUrl_Click);
            // 
            // textURL
            // 
            this.textURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textURL.Location = new System.Drawing.Point(12, 436);
            this.textURL.Name = "textURL";
            this.textURL.Size = new System.Drawing.Size(318, 20);
            this.textURL.TabIndex = 1;
            this.textURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textURL_KeyDown);
            // 
            // treeResult
            // 
            this.treeResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeResult.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeResult.Location = new System.Drawing.Point(0, 0);
            this.treeResult.Name = "treeResult";
            this.treeResult.Size = new System.Drawing.Size(365, 456);
            this.treeResult.TabIndex = 0;
            this.treeResult.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeResult_AfterSelect);
            this.treeResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textRegEx_KeyDown);
            this.treeResult.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeResult_MouseClick);
            // 
            // ToolbarUpdates
            // 
            this.ToolbarUpdates.Name = "ToolbarUpdates";
            this.ToolbarUpdates.Size = new System.Drawing.Size(23, 23);
            // 
            // ToolbarSite
            // 
            this.ToolbarSite.Name = "ToolbarSite";
            this.ToolbarSite.Size = new System.Drawing.Size(23, 23);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 731);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "XwRegExTester";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textRegEx_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button btnExecute;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.Button butLoadUrl;
		private System.Windows.Forms.TextBox textURL;
		private System.Windows.Forms.RichTextBox textSource;
		private System.Windows.Forms.RichTextBox textRegEx;
		MyTreeView treeResult;
		private System.Windows.Forms.Button butClean;
		private System.Windows.Forms.ComboBox comboEncoding;
        private System.Windows.Forms.CheckBox autoExec;
        private System.Windows.Forms.ToolStripButton ToolbarUpdates;
        private System.Windows.Forms.ToolStripButton ToolbarSite;
        private System.Windows.Forms.CheckBox checkMultiline;
        private System.Windows.Forms.CheckBox checkSpaces;
        private System.Windows.Forms.CheckBox checkExtended;
        private System.Windows.Forms.CheckBox checkIgnoreCasa;
        private System.Windows.Forms.CheckBox checkGlobal;

	}
}

