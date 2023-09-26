namespace PROG_7312_Task_1_V1
{
	partial class ReplaceBook
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
			this.lbxDisplay = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbxDisplay
			// 
			this.lbxDisplay.BackColor = System.Drawing.Color.Salmon;
			this.lbxDisplay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbxDisplay.ForeColor = System.Drawing.SystemColors.Window;
			this.lbxDisplay.FormattingEnabled = true;
			this.lbxDisplay.ItemHeight = 29;
			this.lbxDisplay.Location = new System.Drawing.Point(57, 58);
			this.lbxDisplay.Name = "lbxDisplay";
			this.lbxDisplay.Size = new System.Drawing.Size(614, 265);
			this.lbxDisplay.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.MediumPurple;
			this.button1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Location = new System.Drawing.Point(178, 363);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(336, 152);
			this.button1.TabIndex = 1;
			this.button1.Text = "Generate Call";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// ReplaceBook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Plum;
			this.ClientSize = new System.Drawing.Size(727, 609);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lbxDisplay);
			this.Name = "ReplaceBook";
			this.Text = "ReplaceBook";
			this.Load += new System.EventHandler(this.ReplaceBook_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private ListBox lbxDisplay;
		private Button button1;
	}
}