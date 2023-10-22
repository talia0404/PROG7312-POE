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
			lbxDisplay = new ListBox();
			btnCheckOrder = new Button();
			btnRegen = new Button();
			lblPoint = new Label();
			panel1 = new Panel();
			label4 = new Label();
			lblHeader = new Label();
			lblHeader2 = new Label();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// lbxDisplay
			// 
			lbxDisplay.BackColor = Color.Salmon;
			lbxDisplay.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lbxDisplay.ForeColor = SystemColors.Window;
			lbxDisplay.FormattingEnabled = true;
			lbxDisplay.ItemHeight = 29;
			lbxDisplay.Location = new Point(122, 317);
			lbxDisplay.Name = "lbxDisplay";
			lbxDisplay.Size = new Size(853, 323);
			lbxDisplay.TabIndex = 0;
			// 
			// btnCheckOrder
			// 
			btnCheckOrder.BackColor = Color.MediumPurple;
			btnCheckOrder.Font = new Font("Cooper Black", 12F, FontStyle.Italic, GraphicsUnit.Point);
			btnCheckOrder.ForeColor = SystemColors.ButtonHighlight;
			btnCheckOrder.Location = new Point(414, 694);
			btnCheckOrder.Name = "btnCheckOrder";
			btnCheckOrder.Size = new Size(264, 152);
			btnCheckOrder.TabIndex = 3;
			btnCheckOrder.Text = "Check Order";
			btnCheckOrder.UseVisualStyleBackColor = false;
			btnCheckOrder.Click += btnCheckOrder_Click;
			// 
			// btnRegen
			// 
			btnRegen.BackColor = Color.MediumPurple;
			btnRegen.Font = new Font("Cooper Black", 12F, FontStyle.Italic, GraphicsUnit.Point);
			btnRegen.ForeColor = SystemColors.ButtonHighlight;
			btnRegen.Location = new Point(455, 890);
			btnRegen.Name = "btnRegen";
			btnRegen.Size = new Size(169, 100);
			btnRegen.TabIndex = 8;
			btnRegen.Text = "Regenerate Numbers";
			btnRegen.UseVisualStyleBackColor = false;
			btnRegen.Click += btnRegen_Click;
			// 
			// lblPoint
			// 
			lblPoint.AutoSize = true;
			lblPoint.Font = new Font("Cooper Black", 100F, FontStyle.Regular, GraphicsUnit.Point);
			lblPoint.ForeColor = SystemColors.ButtonHighlight;
			lblPoint.Location = new Point(125, 196);
			lblPoint.Name = "lblPoint";
			lblPoint.Size = new Size(217, 230);
			lblPoint.TabIndex = 15;
			lblPoint.Text = "0";
			// 
			// panel1
			// 
			panel1.BackColor = Color.PaleTurquoise;
			panel1.Controls.Add(label4);
			panel1.Controls.Add(lblPoint);
			panel1.Location = new Point(1362, 237);
			panel1.Name = "panel1";
			panel1.Size = new Size(441, 548);
			panel1.TabIndex = 16;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Cooper Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
			label4.ForeColor = SystemColors.ButtonHighlight;
			label4.Location = new Point(103, 91);
			label4.Name = "label4";
			label4.Size = new Size(239, 46);
			label4.TabIndex = 17;
			label4.Text = "Your score";
			// 
			// lblHeader
			// 
			lblHeader.AutoSize = true;
			lblHeader.Font = new Font("Cooper Black", 36F, FontStyle.Regular, GraphicsUnit.Point);
			lblHeader.ForeColor = SystemColors.ButtonHighlight;
			lblHeader.ImageAlign = ContentAlignment.MiddleLeft;
			lblHeader.Location = new Point(122, 61);
			lblHeader.Name = "lblHeader";
			lblHeader.Size = new Size(898, 82);
			lblHeader.TabIndex = 12;
			lblHeader.Text = "Order the numbers into";
			// 
			// lblHeader2
			// 
			lblHeader2.AutoSize = true;
			lblHeader2.Font = new Font("Cooper Black", 36F, FontStyle.Regular, GraphicsUnit.Point);
			lblHeader2.ForeColor = SystemColors.ButtonHighlight;
			lblHeader2.ImageAlign = ContentAlignment.MiddleLeft;
			lblHeader2.Location = new Point(221, 190);
			lblHeader2.Name = "lblHeader2";
			lblHeader2.Size = new Size(641, 82);
			lblHeader2.TabIndex = 17;
			lblHeader2.Text = "ascending order!";
			// 
			// ReplaceBook
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Plum;
			ClientSize = new Size(1924, 1050);
			Controls.Add(lblHeader2);
			Controls.Add(panel1);
			Controls.Add(lblHeader);
			Controls.Add(btnRegen);
			Controls.Add(btnCheckOrder);
			Controls.Add(lbxDisplay);
			Name = "ReplaceBook";
			Text = "ReplaceBook";
			Load += ReplaceBook_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListBox lbxDisplay;
		private Button btnCheckOrder;
		private Button btnRegen;
		//=======
		private Label lblHeader;
		private Label lblHeader2;
		//>>>>>>> Stashed changes
		private Label lblPoint;
		private Label label4;
		private Panel panel1;
	}
}