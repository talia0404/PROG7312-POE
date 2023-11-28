namespace PROG_7312_Task_1_V1
{
	partial class FindCallNumbers
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
			pnlQuestion = new Panel();
			btnQRepopLevel1 = new Button();
			cmbLevel1Q = new ComboBox();
			lblQuestions = new Label();
			label1 = new Label();
			pnlAnswer = new Panel();
			btnCheck2 = new Button();
			btnCheck1 = new Button();
			btnRepopLevel2A = new Button();
			lblLevel2 = new Label();
			btnRepopL1A = new Button();
			cmbLevel2A = new ComboBox();
			cmbLevel1A = new ComboBox();
			lblAnswers = new Label();
			btnBack = new Button();
			treeView = new TreeView();
			lblScore = new Label();
			label2 = new Label();
			pnlQuestion.SuspendLayout();
			pnlAnswer.SuspendLayout();
			SuspendLayout();
			// 
			// pnlQuestion
			// 
			pnlQuestion.BackColor = Color.OliveDrab;
			pnlQuestion.Controls.Add(btnQRepopLevel1);
			pnlQuestion.Controls.Add(cmbLevel1Q);
			pnlQuestion.Controls.Add(lblQuestions);
			pnlQuestion.Location = new Point(114, 79);
			pnlQuestion.Name = "pnlQuestion";
			pnlQuestion.Size = new Size(477, 385);
			pnlQuestion.TabIndex = 0;
			// 
			// btnQRepopLevel1
			// 
			btnQRepopLevel1.BackColor = Color.DarkGreen;
			btnQRepopLevel1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnQRepopLevel1.ForeColor = SystemColors.ButtonHighlight;
			btnQRepopLevel1.Location = new Point(145, 247);
			btnQRepopLevel1.Name = "btnQRepopLevel1";
			btnQRepopLevel1.Size = new Size(184, 61);
			btnQRepopLevel1.TabIndex = 25;
			btnQRepopLevel1.Text = "Repopulate";
			btnQRepopLevel1.UseVisualStyleBackColor = false;
			btnQRepopLevel1.Click += btnQRepopLevel1_Click;
			// 
			// cmbLevel1Q
			// 
			cmbLevel1Q.BackColor = Color.Black;
			cmbLevel1Q.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
			cmbLevel1Q.ForeColor = Color.Ivory;
			cmbLevel1Q.FormattingEnabled = true;
			cmbLevel1Q.Location = new Point(39, 155);
			cmbLevel1Q.Name = "cmbLevel1Q";
			cmbLevel1Q.Size = new Size(391, 36);
			cmbLevel1Q.TabIndex = 1;
			// 
			// lblQuestions
			// 
			lblQuestions.AutoSize = true;
			lblQuestions.Font = new Font("Impact", 20F, FontStyle.Bold, GraphicsUnit.Point);
			lblQuestions.ForeColor = Color.White;
			lblQuestions.Location = new Point(135, 40);
			lblQuestions.Name = "lblQuestions";
			lblQuestions.Size = new Size(194, 48);
			lblQuestions.TabIndex = 0;
			lblQuestions.Text = "Questions";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Impact", 20F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.White;
			label1.Location = new Point(168, 121);
			label1.Name = "label1";
			label1.Size = new Size(141, 48);
			label1.TabIndex = 2;
			label1.Text = "Level 1:";
			// 
			// pnlAnswer
			// 
			pnlAnswer.BackColor = Color.OliveDrab;
			pnlAnswer.Controls.Add(btnCheck2);
			pnlAnswer.Controls.Add(btnCheck1);
			pnlAnswer.Controls.Add(btnRepopLevel2A);
			pnlAnswer.Controls.Add(lblLevel2);
			pnlAnswer.Controls.Add(btnRepopL1A);
			pnlAnswer.Controls.Add(cmbLevel2A);
			pnlAnswer.Controls.Add(label1);
			pnlAnswer.Controls.Add(cmbLevel1A);
			pnlAnswer.Controls.Add(lblAnswers);
			pnlAnswer.Location = new Point(681, 79);
			pnlAnswer.Name = "pnlAnswer";
			pnlAnswer.Size = new Size(477, 599);
			pnlAnswer.TabIndex = 1;
			// 
			// btnCheck2
			// 
			btnCheck2.BackColor = Color.DarkGreen;
			btnCheck2.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnCheck2.ForeColor = SystemColors.ButtonHighlight;
			btnCheck2.Location = new Point(43, 475);
			btnCheck2.Name = "btnCheck2";
			btnCheck2.Size = new Size(184, 61);
			btnCheck2.TabIndex = 29;
			btnCheck2.Text = "Check";
			btnCheck2.UseVisualStyleBackColor = false;
			btnCheck2.Visible = false;
			btnCheck2.Click += btnCheck2_Click;
			// 
			// btnCheck1
			// 
			btnCheck1.BackColor = Color.DarkGreen;
			btnCheck1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnCheck1.ForeColor = SystemColors.ButtonHighlight;
			btnCheck1.Location = new Point(43, 261);
			btnCheck1.Name = "btnCheck1";
			btnCheck1.Size = new Size(184, 61);
			btnCheck1.TabIndex = 28;
			btnCheck1.Text = "Check";
			btnCheck1.UseVisualStyleBackColor = false;
			btnCheck1.Click += btnCheck1_Click;
			// 
			// btnRepopLevel2A
			// 
			btnRepopLevel2A.BackColor = Color.DarkGreen;
			btnRepopLevel2A.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnRepopLevel2A.ForeColor = SystemColors.ButtonHighlight;
			btnRepopLevel2A.Location = new Point(254, 475);
			btnRepopLevel2A.Name = "btnRepopLevel2A";
			btnRepopLevel2A.Size = new Size(184, 61);
			btnRepopLevel2A.TabIndex = 27;
			btnRepopLevel2A.Text = "Repopulate";
			btnRepopLevel2A.UseVisualStyleBackColor = false;
			btnRepopLevel2A.Visible = false;
			btnRepopLevel2A.Click += btnRepopLevel2A_Click;
			// 
			// lblLevel2
			// 
			lblLevel2.AutoSize = true;
			lblLevel2.Font = new Font("Impact", 20F, FontStyle.Bold, GraphicsUnit.Point);
			lblLevel2.ForeColor = Color.White;
			lblLevel2.Location = new Point(155, 350);
			lblLevel2.Name = "lblLevel2";
			lblLevel2.Size = new Size(146, 48);
			lblLevel2.TabIndex = 24;
			lblLevel2.Text = "Level 2:";
			lblLevel2.Visible = false;
			// 
			// btnRepopL1A
			// 
			btnRepopL1A.BackColor = Color.DarkGreen;
			btnRepopL1A.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnRepopL1A.ForeColor = SystemColors.ButtonHighlight;
			btnRepopL1A.Location = new Point(254, 261);
			btnRepopL1A.Name = "btnRepopL1A";
			btnRepopL1A.Size = new Size(184, 61);
			btnRepopL1A.TabIndex = 26;
			btnRepopL1A.Text = "Repopulate";
			btnRepopL1A.UseVisualStyleBackColor = false;
			btnRepopL1A.Click += btnRepopL1A_Click;
			// 
			// cmbLevel2A
			// 
			cmbLevel2A.BackColor = Color.Black;
			cmbLevel2A.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
			cmbLevel2A.ForeColor = Color.Ivory;
			cmbLevel2A.FormattingEnabled = true;
			cmbLevel2A.Location = new Point(43, 422);
			cmbLevel2A.Name = "cmbLevel2A";
			cmbLevel2A.Size = new Size(395, 36);
			cmbLevel2A.TabIndex = 3;
			cmbLevel2A.Visible = false;
			// 
			// cmbLevel1A
			// 
			cmbLevel1A.BackColor = Color.Black;
			cmbLevel1A.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
			cmbLevel1A.ForeColor = Color.Ivory;
			cmbLevel1A.FormattingEnabled = true;
			cmbLevel1A.Location = new Point(43, 205);
			cmbLevel1A.Name = "cmbLevel1A";
			cmbLevel1A.Size = new Size(395, 36);
			cmbLevel1A.TabIndex = 2;
			cmbLevel1A.SelectedIndexChanged += cmbLevel1A_SelectedIndexChanged;
			// 
			// lblAnswers
			// 
			lblAnswers.AutoSize = true;
			lblAnswers.Font = new Font("Impact", 20F, FontStyle.Bold, GraphicsUnit.Point);
			lblAnswers.ForeColor = Color.White;
			lblAnswers.Location = new Point(155, 40);
			lblAnswers.Name = "lblAnswers";
			lblAnswers.Size = new Size(167, 48);
			lblAnswers.TabIndex = 1;
			lblAnswers.Text = "Answers";
			// 
			// btnBack
			// 
			btnBack.BackColor = Color.DarkGreen;
			btnBack.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnBack.ForeColor = SystemColors.ButtonHighlight;
			btnBack.Location = new Point(1657, 710);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(103, 61);
			btnBack.TabIndex = 21;
			btnBack.Text = "Back";
			btnBack.UseVisualStyleBackColor = false;
			btnBack.Click += btnBack_Click;
			// 
			// treeView
			// 
			treeView.BackColor = SystemColors.MenuText;
			treeView.ForeColor = SystemColors.Window;
			treeView.Location = new Point(137, 492);
			treeView.Name = "treeView";
			treeView.Size = new Size(407, 259);
			treeView.TabIndex = 22;
			// 
			// lblScore
			// 
			lblScore.AutoSize = true;
			lblScore.Font = new Font("Impact", 100F, FontStyle.Bold, GraphicsUnit.Point);
			lblScore.ForeColor = Color.White;
			lblScore.Location = new Point(1351, 284);
			lblScore.Name = "lblScore";
			lblScore.Size = new Size(210, 243);
			lblScore.TabIndex = 27;
			lblScore.Text = "0";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Impact", 72F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.White;
			label2.Location = new Point(1250, 94);
			label2.Name = "label2";
			label2.Size = new Size(454, 176);
			label2.TabIndex = 28;
			label2.Text = "Score:";
			// 
			// FindCallNumbers
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSeaGreen;
			ClientSize = new Size(1827, 807);
			Controls.Add(label2);
			Controls.Add(lblScore);
			Controls.Add(treeView);
			Controls.Add(btnBack);
			Controls.Add(pnlAnswer);
			Controls.Add(pnlQuestion);
			Name = "FindCallNumbers";
			Text = "FindCallNumber";
			Load += FindCallNumber_Load;
			pnlQuestion.ResumeLayout(false);
			pnlQuestion.PerformLayout();
			pnlAnswer.ResumeLayout(false);
			pnlAnswer.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel pnlQuestion;
		private Label lblQuestions;
		private Panel pnlAnswer;
		private Label lblAnswers;
		private ComboBox cmbLevel1Q;
		private ComboBox cmbLevel1A;
		private Button btnBack;
		private TreeView treeView;
		private Label label1;
		private Label lblLevel2;
		private ComboBox cmbLevel2Q;
		private ComboBox cmbLevel2A;
		private Button btnQRepopLevel1;
		private Button btnRepopL1A;
		private Button btnRepopLevel2A;
		private Label lblScore;
		private Label label2;
		private Button btnCheck1;
		private Button btnCheck2;
	}
}