﻿namespace PROG_7312_Task_1_V1
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
			this.btnCheckOrder = new System.Windows.Forms.Button();
			this.btnRegen = new System.Windows.Forms.Button();
			this.btnGenClear = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblPoint = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.btnDelete = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbxDisplay
			// 
			this.lbxDisplay.BackColor = System.Drawing.Color.Salmon;
			this.lbxDisplay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbxDisplay.ForeColor = System.Drawing.SystemColors.Window;
			this.lbxDisplay.FormattingEnabled = true;
			this.lbxDisplay.ItemHeight = 29;
			this.lbxDisplay.Location = new System.Drawing.Point(170, 167);
			this.lbxDisplay.Name = "lbxDisplay";
			this.lbxDisplay.Size = new System.Drawing.Size(853, 323);
			this.lbxDisplay.TabIndex = 0;
			// 
			// btnCheckOrder
			// 
			this.btnCheckOrder.BackColor = System.Drawing.Color.MediumPurple;
			this.btnCheckOrder.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.btnCheckOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCheckOrder.Location = new System.Drawing.Point(435, 541);
			this.btnCheckOrder.Name = "btnCheckOrder";
			this.btnCheckOrder.Size = new System.Drawing.Size(264, 152);
			this.btnCheckOrder.TabIndex = 3;
			this.btnCheckOrder.Text = "Check Order";
			this.btnCheckOrder.UseVisualStyleBackColor = false;
			this.btnCheckOrder.Click += new System.EventHandler(this.btnCheckOrder_Click);
			// 
			// btnRegen
			// 
			this.btnRegen.BackColor = System.Drawing.Color.MediumPurple;
			this.btnRegen.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.btnRegen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRegen.Location = new System.Drawing.Point(220, 791);
			this.btnRegen.Name = "btnRegen";
			this.btnRegen.Size = new System.Drawing.Size(169, 100);
			this.btnRegen.TabIndex = 8;
			this.btnRegen.Text = "Regenerate Numbers";
			this.btnRegen.UseVisualStyleBackColor = false;
			this.btnRegen.Click += new System.EventHandler(this.btnRegen_Click);
			// 
			// btnGenClear
			// 
			this.btnGenClear.BackColor = System.Drawing.Color.MediumPurple;
			this.btnGenClear.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.btnGenClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnGenClear.Location = new System.Drawing.Point(730, 791);
			this.btnGenClear.Name = "btnGenClear";
			this.btnGenClear.Size = new System.Drawing.Size(169, 100);
			this.btnGenClear.TabIndex = 11;
			this.btnGenClear.Text = "Clear";
			this.btnGenClear.UseVisualStyleBackColor = false;
			this.btnGenClear.Click += new System.EventHandler(this.btnGenClear_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(249, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(406, 46);
			this.label1.TabIndex = 12;
			this.label1.Text = "Order the numbers";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(528, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(438, 46);
			this.label2.TabIndex = 13;
			this.label2.Text = "into ascending order";
			// 
			// lblPoint
			// 
			this.lblPoint.AutoSize = true;
			this.lblPoint.Font = new System.Drawing.Font("Cooper Black", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblPoint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblPoint.Location = new System.Drawing.Point(81, 144);
			this.lblPoint.Name = "lblPoint";
			this.lblPoint.Size = new System.Drawing.Size(217, 230);
			this.lblPoint.TabIndex = 15;
			this.lblPoint.Text = "0";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.lblPoint);
			this.panel1.Location = new System.Drawing.Point(1339, 116);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(340, 548);
			this.panel1.TabIndex = 16;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(59, 55);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(239, 46);
			this.label4.TabIndex = 17;
			this.label4.Text = "Your score";
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.MediumPurple;
			this.btnDelete.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnDelete.Location = new System.Drawing.Point(479, 791);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(169, 100);
			this.btnDelete.TabIndex = 17;
			this.btnDelete.Text = "Delete Item";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// ReplaceBook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Plum;
			this.ClientSize = new System.Drawing.Size(1754, 1050);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnGenClear);
			this.Controls.Add(this.btnRegen);
			this.Controls.Add(this.btnCheckOrder);
			this.Controls.Add(this.lbxDisplay);
			this.Name = "ReplaceBook";
			this.Text = "ReplaceBook";
			this.Load += new System.EventHandler(this.ReplaceBook_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ListBox lbxDisplay;
		private Button btnCheckOrder;
		private Button btnRegen;
		private Button btnGenClear;
		private Label label1;
		private Label label2;
		private Label lblPoint;
		private Panel panel1;
		private Label label4;
		private Button btnDelete;
	}
}