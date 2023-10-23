namespace PROG_7312_Task_1_V1
{
	partial class PROG7312_V1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnReplace = new Button();
			btnIdentify = new Button();
			btnNumbers = new Button();
			SuspendLayout();
			// 
			// btnReplace
			// 
			btnReplace.BackColor = Color.MediumPurple;
			btnReplace.Font = new Font("Cooper Black", 16F, FontStyle.Italic, GraphicsUnit.Point);
			btnReplace.ForeColor = SystemColors.ControlLightLight;
			btnReplace.Location = new Point(45, 101);
			btnReplace.Name = "btnReplace";
			btnReplace.Size = new Size(415, 469);
			btnReplace.TabIndex = 0;
			btnReplace.Text = "Replace Books";
			btnReplace.UseVisualStyleBackColor = false;
			btnReplace.Click += btnReplace_Click;
			// 
			// btnIdentify
			// 
			btnIdentify.BackColor = Color.MediumPurple;
			btnIdentify.Font = new Font("Cooper Black", 16F, FontStyle.Italic, GraphicsUnit.Point);
			btnIdentify.ForeColor = SystemColors.ControlLightLight;
			btnIdentify.Location = new Point(527, 101);
			btnIdentify.Name = "btnIdentify";
			btnIdentify.Size = new Size(407, 469);
			btnIdentify.TabIndex = 1;
			btnIdentify.Text = "Identify Area";
			btnIdentify.UseVisualStyleBackColor = false;
			btnIdentify.Click += btnIdentify_Click;
			// 
			// btnNumbers
			// 
			btnNumbers.BackColor = Color.MediumPurple;
			btnNumbers.Font = new Font("Cooper Black", 16F, FontStyle.Italic, GraphicsUnit.Point);
			btnNumbers.ForeColor = SystemColors.ControlLightLight;
			btnNumbers.Location = new Point(1001, 101);
			btnNumbers.Name = "btnNumbers";
			btnNumbers.Size = new Size(425, 469);
			btnNumbers.TabIndex = 2;
			btnNumbers.Text = "Find Call Number";
			btnNumbers.UseVisualStyleBackColor = false;
			// 
			// PROG7312_V1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Plum;
			ClientSize = new Size(1487, 664);
			Controls.Add(btnNumbers);
			Controls.Add(btnIdentify);
			Controls.Add(btnReplace);
			Name = "PROG7312_V1";
			Text = "PROG7312_V1";
			Load += Form1_Load;
			ResumeLayout(false);
		}

		#endregion

		private Button btnReplace;
		private Button btnIdentify;
		private Button btnNumbers;
	}
}