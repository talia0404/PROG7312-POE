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
			this.lbxSort = new System.Windows.Forms.ListBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnRegen = new System.Windows.Forms.Button();
			this.lblInstruct1 = new System.Windows.Forms.Label();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnGenClear = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblPoint = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbxDisplay
			// 
			this.lbxDisplay.BackColor = System.Drawing.Color.Salmon;
			this.lbxDisplay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbxDisplay.ForeColor = System.Drawing.SystemColors.Window;
			this.lbxDisplay.FormattingEnabled = true;
			this.lbxDisplay.ItemHeight = 29;
			this.lbxDisplay.Location = new System.Drawing.Point(226, 154);
			this.lbxDisplay.Name = "lbxDisplay";
			this.lbxDisplay.Size = new System.Drawing.Size(447, 323);
			this.lbxDisplay.TabIndex = 0;
			// 
			// tbxReOrder
			// 
			this.tbxReOrder.BackColor = System.Drawing.Color.Khaki;
			this.tbxReOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tbxReOrder.ForeColor = System.Drawing.Color.Black;
			this.tbxReOrder.Location = new System.Drawing.Point(226, 608);
			this.tbxReOrder.Name = "tbxReOrder";
			this.tbxReOrder.Size = new System.Drawing.Size(457, 35);
			this.tbxReOrder.TabIndex = 2;
			this.tbxReOrder.TextChanged += new System.EventHandler(this.tbxReOrder_TextChanged);
			// 
			// btnCheckOrder
			// 
			this.btnCheckOrder.BackColor = System.Drawing.Color.MediumPurple;
			this.btnCheckOrder.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.btnCheckOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCheckOrder.Location = new System.Drawing.Point(898, 694);
			this.btnCheckOrder.Name = "btnCheckOrder";
			this.btnCheckOrder.Size = new System.Drawing.Size(264, 152);
			this.btnCheckOrder.TabIndex = 3;
			this.btnCheckOrder.Text = "Check Order";
			this.btnCheckOrder.UseVisualStyleBackColor = false;
			this.btnCheckOrder.Click += new System.EventHandler(this.btnCheckOrder_Click);
			// 
			// lbxSort
			// 
			this.lbxSort.BackColor = System.Drawing.Color.Salmon;
			this.lbxSort.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbxSort.ForeColor = System.Drawing.SystemColors.Window;
			this.lbxSort.FormattingEnabled = true;
			this.lbxSort.ItemHeight = 29;
			this.lbxSort.Location = new System.Drawing.Point(814, 154);
			this.lbxSort.Name = "lbxSort";
			this.lbxSort.Size = new System.Drawing.Size(447, 323);
			this.lbxSort.TabIndex = 5;
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.MediumPurple;
			this.btnAdd.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnAdd.Location = new System.Drawing.Point(304, 694);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(264, 152);
			this.btnAdd.TabIndex = 7;
			this.btnAdd.Text = "Add To List";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnRegen
			// 
			this.btnRegen.BackColor = System.Drawing.Color.MediumPurple;
			this.btnRegen.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.btnRegen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRegen.Location = new System.Drawing.Point(504, 296);
			this.btnRegen.Name = "btnRegen";
			this.btnRegen.Size = new System.Drawing.Size(169, 100);
			this.btnRegen.TabIndex = 8;
			this.btnRegen.Text = "Regenerate Numbers";
			this.btnRegen.UseVisualStyleBackColor = false;
			this.btnRegen.Click += new System.EventHandler(this.btnRegen_Click);
			// 
			// lblInstruct1
			// 
			this.lblInstruct1.AutoSize = true;
			this.lblInstruct1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblInstruct1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblInstruct1.Location = new System.Drawing.Point(209, 556);
			this.lblInstruct1.Name = "lblInstruct1";
			this.lblInstruct1.Size = new System.Drawing.Size(501, 27);
			this.lblInstruct1.TabIndex = 9;
			this.lblInstruct1.Text = "Only add spaces or \',\' after each number!";
			this.lblInstruct1.Click += new System.EventHandler(this.lblInstruct1_Click);
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.MediumPurple;
			this.btnClear.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClear.Location = new System.Drawing.Point(1092, 393);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(169, 84);
			this.btnClear.TabIndex = 10;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnGenClear
			// 
			this.btnGenClear.BackColor = System.Drawing.Color.MediumPurple;
			this.btnGenClear.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.btnGenClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnGenClear.Location = new System.Drawing.Point(504, 393);
			this.btnGenClear.Name = "btnGenClear";
			this.btnGenClear.Size = new System.Drawing.Size(169, 84);
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
			this.label2.Location = new System.Drawing.Point(235, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(438, 46);
			this.label2.TabIndex = 13;
			this.label2.Text = "into ascending order";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(861, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(340, 46);
			this.label3.TabIndex = 14;
			this.label3.Text = "Your sorted list";
			// 
			// lblPoint
			// 
			this.lblPoint.AutoSize = true;
			this.lblPoint.Font = new System.Drawing.Font("Cooper Black", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblPoint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblPoint.Location = new System.Drawing.Point(1411, 171);
			this.lblPoint.Name = "lblPoint";
			this.lblPoint.Size = new System.Drawing.Size(217, 230);
			this.lblPoint.TabIndex = 15;
			this.lblPoint.Text = "0";
			// 
			// ReplaceBook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Plum;
			this.ClientSize = new System.Drawing.Size(1754, 1050);
			this.Controls.Add(this.lblPoint);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnGenClear);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.lblInstruct1);
			this.Controls.Add(this.btnRegen);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lbxSort);
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
		private ListBox lbxSort;
		private Button btnAdd;
		private Button btnRegen;
		private Label lblInstruct1;
		private Button btnClear;
		private Button btnGenClear;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label lblPoint;
	}
}