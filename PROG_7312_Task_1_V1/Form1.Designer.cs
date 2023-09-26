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
			this.btnReplace = new System.Windows.Forms.Button();
			this.btnIdentify = new System.Windows.Forms.Button();
			this.btnNumbers = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnReplace
			// 
			this.btnReplace.BackColor = System.Drawing.Color.MediumPurple;
			this.btnReplace.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.btnReplace.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnReplace.Location = new System.Drawing.Point(45, 101);
			this.btnReplace.Name = "btnReplace";
			this.btnReplace.Size = new System.Drawing.Size(415, 469);
			this.btnReplace.TabIndex = 0;
			this.btnReplace.Text = "Replace Books";
			this.btnReplace.UseVisualStyleBackColor = false;
			this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
			// 
			// btnIdentify
			// 
			this.btnIdentify.BackColor = System.Drawing.Color.MediumPurple;
			this.btnIdentify.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.btnIdentify.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnIdentify.Location = new System.Drawing.Point(527, 101);
			this.btnIdentify.Name = "btnIdentify";
			this.btnIdentify.Size = new System.Drawing.Size(407, 469);
			this.btnIdentify.TabIndex = 1;
			this.btnIdentify.Text = "Identify Area";
			this.btnIdentify.UseVisualStyleBackColor = false;
			// 
			// btnNumbers
			// 
			this.btnNumbers.BackColor = System.Drawing.Color.MediumPurple;
			this.btnNumbers.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.btnNumbers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnNumbers.Location = new System.Drawing.Point(1001, 101);
			this.btnNumbers.Name = "btnNumbers";
			this.btnNumbers.Size = new System.Drawing.Size(425, 469);
			this.btnNumbers.TabIndex = 2;
			this.btnNumbers.Text = "Find Call Number";
			this.btnNumbers.UseVisualStyleBackColor = false;
			// 
			// PROG7312_V1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Plum;
			this.ClientSize = new System.Drawing.Size(1487, 664);
			this.Controls.Add(this.btnNumbers);
			this.Controls.Add(this.btnIdentify);
			this.Controls.Add(this.btnReplace);
			this.Name = "PROG7312_V1";
			this.Text = "PROG7312_V1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Button btnReplace;
		private Button btnIdentify;
		private Button btnNumbers;
	}
}