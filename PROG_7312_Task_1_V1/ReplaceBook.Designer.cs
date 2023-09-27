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
			this.tbxReOrder = new System.Windows.Forms.TextBox();
			this.btnCheckOrder = new System.Windows.Forms.Button();
			this.btnOrder = new System.Windows.Forms.Button();
			this.lbxSort = new System.Windows.Forms.ListBox();
			this.lblResult = new System.Windows.Forms.Label();
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
			// tbxReOrder
			// 
			this.tbxReOrder.BackColor = System.Drawing.Color.Khaki;
			this.tbxReOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tbxReOrder.ForeColor = System.Drawing.Color.Black;
			this.tbxReOrder.Location = new System.Drawing.Point(620, 424);
			this.tbxReOrder.Name = "tbxReOrder";
			this.tbxReOrder.Size = new System.Drawing.Size(457, 35);
			this.tbxReOrder.TabIndex = 2;
			// 
			// btnCheckOrder
			// 
			this.btnCheckOrder.BackColor = System.Drawing.Color.MediumPurple;
			this.btnCheckOrder.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.btnCheckOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCheckOrder.Location = new System.Drawing.Point(1039, 560);
			this.btnCheckOrder.Name = "btnCheckOrder";
			this.btnCheckOrder.Size = new System.Drawing.Size(264, 152);
			this.btnCheckOrder.TabIndex = 3;
			this.btnCheckOrder.Text = "Check Order";
			this.btnCheckOrder.UseVisualStyleBackColor = false;
			this.btnCheckOrder.Click += new System.EventHandler(this.btnCheckOrder_Click);
			// 
			// btnOrder
			// 
			this.btnOrder.BackColor = System.Drawing.Color.MediumPurple;
			this.btnOrder.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.btnOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnOrder.Location = new System.Drawing.Point(420, 560);
			this.btnOrder.Name = "btnOrder";
			this.btnOrder.Size = new System.Drawing.Size(264, 152);
			this.btnOrder.TabIndex = 4;
			this.btnOrder.Text = "Re-Order";
			this.btnOrder.UseVisualStyleBackColor = false;
			this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
			// 
			// lbxSort
			// 
			this.lbxSort.BackColor = System.Drawing.Color.Salmon;
			this.lbxSort.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbxSort.ForeColor = System.Drawing.SystemColors.Window;
			this.lbxSort.FormattingEnabled = true;
			this.lbxSort.ItemHeight = 29;
			this.lbxSort.Location = new System.Drawing.Point(1039, 58);
			this.lbxSort.Name = "lbxSort";
			this.lbxSort.Size = new System.Drawing.Size(614, 265);
			this.lbxSort.TabIndex = 5;
			// 
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.Location = new System.Drawing.Point(832, 177);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(0, 25);
			this.lblResult.TabIndex = 6;
			// 
			// ReplaceBook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Plum;
			this.ClientSize = new System.Drawing.Size(1709, 809);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.lbxSort);
			this.Controls.Add(this.btnOrder);
			this.Controls.Add(this.btnCheckOrder);
			this.Controls.Add(this.tbxReOrder);
			this.Controls.Add(this.lbxDisplay);
			this.Name = "ReplaceBook";
			this.Text = "ReplaceBook";
			this.Load += new System.EventHandler(this.ReplaceBook_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ListBox lbxDisplay;
		private TextBox tbxReOrder;
		private Button btnCheckOrder;
		private Button btnOrder;
		private ListBox lbxSort;
		private Label lblResult;
	}
}