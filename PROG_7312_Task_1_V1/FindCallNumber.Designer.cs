namespace PROG_7312_Task_1_V1
{
	partial class FindCallNumber
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
			cmbQuestions = new ComboBox();
			lblQuestions = new Label();
			pnlAnswer = new Panel();
			cmbA = new ComboBox();
			lblAnswers = new Label();
			richTextBox1 = new RichTextBox();
			btnBack = new Button();
			treeView = new TreeView();
			pnlQuestion.SuspendLayout();
			pnlAnswer.SuspendLayout();
			SuspendLayout();
			// 
			// pnlQuestion
			// 
			pnlQuestion.BackColor = Color.OliveDrab;
			pnlQuestion.Controls.Add(cmbQuestions);
			pnlQuestion.Controls.Add(lblQuestions);
			pnlQuestion.Location = new Point(114, 79);
			pnlQuestion.Name = "pnlQuestion";
			pnlQuestion.Size = new Size(477, 599);
			pnlQuestion.TabIndex = 0;
			// 
			// cmbQuestions
			// 
			cmbQuestions.BackColor = Color.Black;
			cmbQuestions.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
			cmbQuestions.ForeColor = Color.Ivory;
			cmbQuestions.FormattingEnabled = true;
			cmbQuestions.Location = new Point(102, 124);
			cmbQuestions.Name = "cmbQuestions";
			cmbQuestions.Size = new Size(250, 36);
			cmbQuestions.TabIndex = 1;
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
			// pnlAnswer
			// 
			pnlAnswer.BackColor = Color.OliveDrab;
			pnlAnswer.Controls.Add(cmbA);
			pnlAnswer.Controls.Add(lblAnswers);
			pnlAnswer.Location = new Point(681, 79);
			pnlAnswer.Name = "pnlAnswer";
			pnlAnswer.Size = new Size(477, 599);
			pnlAnswer.TabIndex = 1;
			// 
			// cmbA
			// 
			cmbA.BackColor = Color.Black;
			cmbA.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
			cmbA.ForeColor = Color.Ivory;
			cmbA.FormattingEnabled = true;
			cmbA.Location = new Point(114, 124);
			cmbA.Name = "cmbA";
			cmbA.Size = new Size(250, 36);
			cmbA.TabIndex = 2;
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
			// richTextBox1
			// 
			richTextBox1.Location = new Point(1310, 79);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(407, 393);
			richTextBox1.TabIndex = 2;
			richTextBox1.Text = "";
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
			treeView.Location = new Point(1310, 493);
			treeView.Name = "treeView";
			treeView.Size = new Size(407, 195);
			treeView.TabIndex = 22;
			// 
			// FindCallNumber
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSeaGreen;
			ClientSize = new Size(1827, 807);
			Controls.Add(treeView);
			Controls.Add(btnBack);
			Controls.Add(richTextBox1);
			Controls.Add(pnlAnswer);
			Controls.Add(pnlQuestion);
			Name = "FindCallNumber";
			Text = "FindCallNumber";
			Load += FindCallNumber_Load;
			pnlQuestion.ResumeLayout(false);
			pnlQuestion.PerformLayout();
			pnlAnswer.ResumeLayout(false);
			pnlAnswer.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel pnlQuestion;
		private Label lblQuestions;
		private Panel pnlAnswer;
		private Label lblAnswers;
		private ComboBox cmbQuestions;
		private ComboBox cmbA;
		private RichTextBox richTextBox1;
		private Button btnBack;
		private TreeView treeView;
	}
}