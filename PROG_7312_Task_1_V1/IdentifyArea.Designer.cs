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
			dataGridViewColumnA = new DataGridView();
			Column1 = new DataGridViewTextBoxColumn();
			dataGridViewColumnB = new DataGridView();
			Column2 = new DataGridViewTextBoxColumn();
			btnCheckOrder = new Button();
			lblPoint = new Label();
			label4 = new Label();
			btnIdentifyAreas = new Button();
			btnBack = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridViewColumnA).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridViewColumnB).BeginInit();
			SuspendLayout();
			// 
			// lblHeader
			// 
			lblHeader.AutoSize = true;
			lblHeader.Font = new Font("Cooper Black", 36F, FontStyle.Regular, GraphicsUnit.Point);
			lblHeader.ForeColor = SystemColors.ButtonHighlight;
			lblHeader.ImageAlign = ContentAlignment.MiddleLeft;
			lblHeader.Location = new Point(581, 43);
			lblHeader.Name = "lblHeader";
			lblHeader.Size = new Size(759, 82);
			lblHeader.TabIndex = 13;
			lblHeader.Text = "Match the Colunms!";
			// 
			// dataGridViewColumnA
			// 
			dataGridViewColumnA.AllowUserToAddRows = false;
			dataGridViewColumnA.BackgroundColor = Color.LemonChiffon;
			dataGridViewColumnA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewColumnA.Columns.AddRange(new DataGridViewColumn[] { Column1 });
			dataGridViewColumnA.Location = new Point(166, 230);
			dataGridViewColumnA.Name = "dataGridViewColumnA";
			dataGridViewColumnA.RowHeadersWidth = 62;
			dataGridViewColumnA.RowTemplate.Height = 33;
			dataGridViewColumnA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridViewColumnA.Size = new Size(360, 225);
			dataGridViewColumnA.TabIndex = 14;
			// 
			// Column1
			// 
			Column1.HeaderText = "Column1";
			Column1.MinimumWidth = 8;
			Column1.Name = "Column1";
			Column1.ReadOnly = true;
			Column1.Width = 150;
			// 
			// dataGridViewColumnB
			// 
			dataGridViewColumnB.AllowUserToAddRows = false;
			dataGridViewColumnB.BackgroundColor = Color.MediumAquamarine;
			dataGridViewColumnB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewColumnB.Columns.AddRange(new DataGridViewColumn[] { Column2 });
			dataGridViewColumnB.Location = new Point(647, 230);
			dataGridViewColumnB.Name = "dataGridViewColumnB";
			dataGridViewColumnB.RowHeadersWidth = 62;
			dataGridViewColumnB.RowTemplate.Height = 33;
			dataGridViewColumnB.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridViewColumnB.Size = new Size(360, 377);
			dataGridViewColumnB.TabIndex = 15;
			// 
			// Column2
			// 
			Column2.HeaderText = "Column2";
			Column2.MinimumWidth = 8;
			Column2.Name = "Column2";
			Column2.ReadOnly = true;
			Column2.Width = 150;
			// 
			// btnCheckOrder
			// 
			btnCheckOrder.BackColor = Color.MidnightBlue;
			btnCheckOrder.Font = new Font("Cooper Black", 12F, FontStyle.Italic, GraphicsUnit.Point);
			btnCheckOrder.ForeColor = SystemColors.ButtonFace;
			btnCheckOrder.Location = new Point(454, 652);
			btnCheckOrder.Name = "btnCheckOrder";
			btnCheckOrder.Size = new Size(264, 152);
			btnCheckOrder.TabIndex = 16;
			btnCheckOrder.Text = "Check Order";
			btnCheckOrder.UseVisualStyleBackColor = false;
			// 
			// lblPoint
			// 
			lblPoint.AutoSize = true;
			lblPoint.Font = new Font("Cooper Black", 100F, FontStyle.Regular, GraphicsUnit.Point);
			lblPoint.ForeColor = SystemColors.ButtonHighlight;
			lblPoint.Location = new Point(1425, 343);
			lblPoint.Name = "lblPoint";
			lblPoint.Size = new Size(217, 230);
			lblPoint.TabIndex = 17;
			lblPoint.Text = "0";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Cooper Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
			label4.ForeColor = SystemColors.ButtonHighlight;
			label4.Location = new Point(1403, 256);
			label4.Name = "label4";
			label4.Size = new Size(239, 46);
			label4.TabIndex = 18;
			label4.Text = "Your score";
			// 
			// btnIdentifyAreas
			// 
			btnIdentifyAreas.BackColor = Color.RoyalBlue;
			btnIdentifyAreas.Font = new Font("Cooper Black", 12F, FontStyle.Italic, GraphicsUnit.Point);
			btnIdentifyAreas.ForeColor = SystemColors.ButtonHighlight;
			btnIdentifyAreas.Location = new Point(1538, 652);
			btnIdentifyAreas.Name = "btnIdentifyAreas";
			btnIdentifyAreas.Size = new Size(169, 100);
			btnIdentifyAreas.TabIndex = 21;
			btnIdentifyAreas.Text = "Go to Replace Book Game";
			btnIdentifyAreas.UseVisualStyleBackColor = false;
			btnIdentifyAreas.Click += btnIdentifyAreas_Click;
			// 
			// btnBack
			// 
			btnBack.BackColor = Color.RoyalBlue;
			btnBack.Font = new Font("Cooper Black", 12F, FontStyle.Italic, GraphicsUnit.Point);
			btnBack.ForeColor = SystemColors.ButtonHighlight;
			btnBack.Location = new Point(1289, 652);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(169, 100);
			btnBack.TabIndex = 20;
			btnBack.Text = "Back";
			btnBack.UseVisualStyleBackColor = false;
			btnBack.Click += btnBack_Click;
			// 
			// IdentifyArea
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.PowderBlue;
			ClientSize = new Size(1823, 933);
			Controls.Add(btnIdentifyAreas);
			Controls.Add(btnBack);
			Controls.Add(label4);
			Controls.Add(lblPoint);
			Controls.Add(btnCheckOrder);
			Controls.Add(dataGridViewColumnB);
			Controls.Add(dataGridViewColumnA);
			Controls.Add(lblHeader);
			Name = "IdentifyArea";
			Text = "IdentifyArea";
			Load += frmIDAreas_Load;
			((System.ComponentModel.ISupportInitialize)dataGridViewColumnA).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridViewColumnB).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblHeader;
		private DataGridView dataGridViewColumnA;
		private DataGridView dataGridViewColumnB;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private Button btnCheckOrder;
		private Label lblPoint;
		private Label label4;
		private Button btnIdentifyAreas;
		private Button btnBack;
	}
}