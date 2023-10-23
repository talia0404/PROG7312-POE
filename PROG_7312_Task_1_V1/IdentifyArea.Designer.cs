namespace PROG_7312_Task_1_V1
{
	partial class IdentifyArea
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
			lblHeader = new Label();
			SuspendLayout();
			// 
			// lblHeader
			// 
			lblHeader.AutoSize = true;
			lblHeader.Font = new Font("Cooper Black", 36F, FontStyle.Regular, GraphicsUnit.Point);
			lblHeader.ForeColor = SystemColors.ButtonHighlight;
			lblHeader.ImageAlign = ContentAlignment.MiddleLeft;
			lblHeader.Location = new Point(487, 74);
			lblHeader.Name = "lblHeader";
			lblHeader.Size = new Size(898, 82);
			lblHeader.TabIndex = 13;
			lblHeader.Text = "Order the numbers into";
			// 
			// IdentifyArea
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.PowderBlue;
			ClientSize = new Size(1823, 933);
			Controls.Add(lblHeader);
			Name = "IdentifyArea";
			Text = "IdentifyArea";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblHeader;
	}
}