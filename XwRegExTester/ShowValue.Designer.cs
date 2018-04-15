namespace XwRegExTester
{
	partial class ShowValue
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
			this.textValue = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// textValue
			// 
			this.textValue.AcceptsTab = true;
			this.textValue.AutoWordSelection = true;
			this.textValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textValue.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textValue.Location = new System.Drawing.Point(0, 0);
			this.textValue.Name = "textValue";
			this.textValue.ReadOnly = true;
			this.textValue.Size = new System.Drawing.Size(978, 546);
			this.textValue.TabIndex = 0;
			this.textValue.Text = "";
			this.textValue.WordWrap = false;
			// 
			// ShowValue
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(978, 546);
			this.Controls.Add(this.textValue);
			this.MinimizeBox = false;
			this.Name = "ShowValue";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ShowValue";
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.RichTextBox textValue;
	}
}