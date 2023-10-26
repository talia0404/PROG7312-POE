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
			components = new System.ComponentModel.Container();
			lblHeader = new Label();
			dvgKey = new DataGridView();
			dvgValues = new DataGridView();
			btnMatch = new Button();
			lblPoint = new Label();
			label4 = new Label();
			btnIdentifyAreas = new Button();
			btnBack = new Button();
			btnNewGame = new Button();
			timer1 = new System.Windows.Forms.Timer(components);
			panel1 = new Panel();
			panel2 = new Panel();
			lblWin = new Label();
			pbxWin = new PictureBox();
			lblAnswers = new Label();
			((System.ComponentModel.ISupportInitialize)dvgKey).BeginInit();
			((System.ComponentModel.ISupportInitialize)dvgValues).BeginInit();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbxWin).BeginInit();
			SuspendLayout();
			// 
			// lblHeader
			// 
			lblHeader.AutoSize = true;
			lblHeader.Font = new Font("Cooper Black", 36F, FontStyle.Regular, GraphicsUnit.Point);
			lblHeader.ForeColor = SystemColors.ButtonHighlight;
			lblHeader.ImageAlign = ContentAlignment.MiddleLeft;
			lblHeader.Location = new Point(582, 42);
			lblHeader.Name = "lblHeader";
			lblHeader.Size = new Size(759, 82);
			lblHeader.TabIndex = 13;
			lblHeader.Text = "Match the Colunms!";
			// 
			// dvgKey
			// 
			dvgKey.AllowUserToAddRows = false;
			dvgKey.BackgroundColor = Color.LemonChiffon;
			dvgKey.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dvgKey.GridColor = Color.LemonChiffon;
			dvgKey.Location = new Point(64, 49);
			dvgKey.Name = "dvgKey";
			dvgKey.RowHeadersWidth = 62;
			dvgKey.RowTemplate.Height = 33;
			dvgKey.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dvgKey.Size = new Size(360, 225);
			dvgKey.TabIndex = 14;
			// 
			// dvgValues
			// 
			dvgValues.AllowUserToAddRows = false;
			dvgValues.BackgroundColor = Color.MediumAquamarine;
			dvgValues.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dvgValues.GridColor = Color.MediumSeaGreen;
			dvgValues.Location = new Point(64, 280);
			dvgValues.Name = "dvgValues";
			dvgValues.RowHeadersWidth = 62;
			dvgValues.RowTemplate.Height = 33;
			dvgValues.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dvgValues.Size = new Size(360, 377);
			dvgValues.TabIndex = 15;
			// 
			// btnMatch
			// 
			btnMatch.BackColor = Color.MidnightBlue;
			btnMatch.Font = new Font("Cooper Black", 12F, FontStyle.Italic, GraphicsUnit.Point);
			btnMatch.ForeColor = SystemColors.ButtonFace;
			btnMatch.Location = new Point(523, 505);
			btnMatch.Name = "btnMatch";
			btnMatch.Size = new Size(264, 152);
			btnMatch.TabIndex = 16;
			btnMatch.Text = "Match";
			btnMatch.UseVisualStyleBackColor = false;
			btnMatch.Click += btnMatch_Click;
			// 
			// lblPoint
			// 
			lblPoint.AutoSize = true;
			lblPoint.BackColor = Color.Orange;
			lblPoint.Font = new Font("Cooper Black", 100F, FontStyle.Regular, GraphicsUnit.Point);
			lblPoint.ForeColor = SystemColors.ButtonHighlight;
			lblPoint.Location = new Point(73, 118);
			lblPoint.Name = "lblPoint";
			lblPoint.Size = new Size(217, 230);
			lblPoint.TabIndex = 17;
			lblPoint.Text = "0";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Orange;
			label4.Font = new Font("Cooper Black", 26F, FontStyle.Regular, GraphicsUnit.Point);
			label4.ForeColor = SystemColors.ButtonHighlight;
			label4.Location = new Point(14, 31);
			label4.Name = "label4";
			label4.Size = new Size(328, 60);
			label4.TabIndex = 18;
			label4.Text = "Your score:";
			// 
			// btnIdentifyAreas
			// 
			btnIdentifyAreas.BackColor = Color.RoyalBlue;
			btnIdentifyAreas.Font = new Font("Cooper Black", 8F, FontStyle.Italic, GraphicsUnit.Point);
			btnIdentifyAreas.ForeColor = SystemColors.ButtonHighlight;
			btnIdentifyAreas.Location = new Point(1607, 847);
			btnIdentifyAreas.Name = "btnIdentifyAreas";
			btnIdentifyAreas.Size = new Size(172, 61);
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
			btnBack.Location = new Point(1480, 847);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(103, 61);
			btnBack.TabIndex = 20;
			btnBack.Text = "Back";
			btnBack.UseVisualStyleBackColor = false;
			btnBack.Click += btnBack_Click;
			// 
			// btnNewGame
			// 
			btnNewGame.BackColor = Color.SteelBlue;
			btnNewGame.Font = new Font("Cooper Black", 12F, FontStyle.Italic, GraphicsUnit.Point);
			btnNewGame.ForeColor = SystemColors.ButtonFace;
			btnNewGame.Location = new Point(1414, 630);
			btnNewGame.Name = "btnNewGame";
			btnNewGame.Size = new Size(169, 100);
			btnNewGame.TabIndex = 22;
			btnNewGame.Text = "New Game";
			btnNewGame.UseVisualStyleBackColor = false;
			btnNewGame.Click += btnNewGame_Click;
			// 
			// panel1
			// 
			panel1.BackColor = Color.Orange;
			panel1.Controls.Add(lblPoint);
			panel1.Controls.Add(label4);
			panel1.Location = new Point(1330, 190);
			panel1.Name = "panel1";
			panel1.Size = new Size(345, 417);
			panel1.TabIndex = 23;
			// 
			// panel2
			// 
			panel2.BackColor = Color.Orange;
			panel2.Controls.Add(lblAnswers);
			panel2.Controls.Add(dvgKey);
			panel2.Controls.Add(dvgValues);
			panel2.Controls.Add(btnMatch);
			panel2.Location = new Point(131, 190);
			panel2.Name = "panel2";
			panel2.Size = new Size(1127, 718);
			panel2.TabIndex = 24;
			// 
			// lblWin
			// 
			lblWin.AutoSize = true;
			lblWin.Font = new Font("Cooper Black", 36F, FontStyle.Regular, GraphicsUnit.Point);
			lblWin.ForeColor = SystemColors.ButtonHighlight;
			lblWin.ImageAlign = ContentAlignment.MiddleLeft;
			lblWin.Location = new Point(733, 741);
			lblWin.Name = "lblWin";
			lblWin.Size = new Size(565, 82);
			lblWin.TabIndex = 25;
			lblWin.Text = "YOU WIN!!!!!!!!";
			// 
			// pbxWin
			// 
			pbxWin.Image = Properties.Resources.prog_task_2;
			pbxWin.InitialImage = null;
			pbxWin.Location = new Point(454, 141);
			pbxWin.Name = "pbxWin";
			pbxWin.Size = new Size(1032, 568);
			pbxWin.TabIndex = 20;
			pbxWin.TabStop = false;
			// 
			// lblAnswers
			// 
			lblAnswers.AutoSize = true;
			lblAnswers.BackColor = Color.Orange;
			lblAnswers.Font = new Font("Cooper Black", 24F, FontStyle.Regular, GraphicsUnit.Point);
			lblAnswers.ForeColor = SystemColors.ButtonHighlight;
			lblAnswers.Location = new Point(556, 73);
			lblAnswers.Name = "lblAnswers";
			lblAnswers.Size = new Size(0, 55);
			lblAnswers.TabIndex = 19;
			// 
			// IdentifyArea
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.PowderBlue;
			ClientSize = new Size(1823, 933);
			Controls.Add(lblWin);
			Controls.Add(btnNewGame);
			Controls.Add(pbxWin);
			Controls.Add(btnIdentifyAreas);
			Controls.Add(btnBack);
			Controls.Add(lblHeader);
			Controls.Add(panel1);
			Controls.Add(panel2);
			Name = "IdentifyArea";
			Text = "IdentifyArea";
			Load += frmIDAreas_Load;
			((System.ComponentModel.ISupportInitialize)dvgKey).EndInit();
			((System.ComponentModel.ISupportInitialize)dvgValues).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pbxWin).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblHeader;
		private DataGridView dvgKey;
		private DataGridView dvgValues;
		private Button btnMatch;
		private Label lblPoint;
		private Label label4;
		private Button btnIdentifyAreas;
		private Button btnBack;
		private Button btnNewGame;
		private System.Windows.Forms.Timer timer1;
		private Panel panel1;
		private Panel panel2;
		private Label lblAnswers;
		private PictureBox pbxWin;
		private Label lblWin;
	}
}