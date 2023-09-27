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
			this.lblResult = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnRegen = new System.Windows.Forms.Button();
			this.lblInstruct1 = new System.Windows.Forms.Label();
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
			this.tbxReOrder.Location = new System.Drawing.Point(832, 433);
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
			this.btnCheckOrder.Location = new System.Drawing.Point(229, 717);
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
			this.lbxSort.Location = new System.Drawing.Point(57, 400);
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
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.MediumPurple;
			this.btnAdd.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnAdd.Location = new System.Drawing.Point(935, 513);
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
			this.btnRegen.Location = new System.Drawing.Point(944, 97);
			this.btnRegen.Name = "btnRegen";
			this.btnRegen.Size = new System.Drawing.Size(264, 152);
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
			this.lblInstruct1.Location = new System.Drawing.Point(823, 365);
			this.lblInstruct1.Name = "lblInstruct1";
			this.lblInstruct1.Size = new System.Drawing.Size(86, 27);
			this.lblInstruct1.TabIndex = 9;
			this.lblInstruct1.Text = "label1";
			// 
			// ReplaceBook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Plum;
			this.ClientSize = new System.Drawing.Size(1754, 953);
			this.Controls.Add(this.lblInstruct1);
			this.Controls.Add(this.btnRegen);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lblResult);
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
		private Label lblResult;
		private Button btnAdd;
		private Button btnRegen;
		private Label lblInstruct1;
	}
}