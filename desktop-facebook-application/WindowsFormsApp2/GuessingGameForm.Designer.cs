namespace FacebookDesktop
{
    public partial class GuessingGameForm
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
            this.m_PictureBox = new System.Windows.Forms.PictureBox();
            this.m_TitleLabel = new System.Windows.Forms.Label();
            this.m_QuestionLabel = new System.Windows.Forms.Label();
            this.m_AnswerTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_NumWrongAnswersLabel = new System.Windows.Forms.Label();
            this.m_NumCorrectAnswersLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_SubmitAnswerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_PictureBox
            // 
            this.m_PictureBox.Location = new System.Drawing.Point(217, 81);
            this.m_PictureBox.Name = "m_PictureBox";
            this.m_PictureBox.Size = new System.Drawing.Size(497, 326);
            this.m_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.m_PictureBox.TabIndex = 0;
            this.m_PictureBox.TabStop = false;
            // 
            // m_TitleLabel
            // 
            this.m_TitleLabel.AutoSize = true;
            this.m_TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_TitleLabel.Location = new System.Drawing.Point(210, 20);
            this.m_TitleLabel.Name = "m_TitleLabel";
            this.m_TitleLabel.Size = new System.Drawing.Size(110, 39);
            this.m_TitleLabel.TabIndex = 1;
            this.m_TitleLabel.Text = "TITLE";
            // 
            // m_QuestionLabel
            // 
            this.m_QuestionLabel.AutoSize = true;
            this.m_QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_QuestionLabel.Location = new System.Drawing.Point(212, 429);
            this.m_QuestionLabel.Name = "m_QuestionLabel";
            this.m_QuestionLabel.Size = new System.Drawing.Size(218, 29);
            this.m_QuestionLabel.TabIndex = 2;
            this.m_QuestionLabel.Text = "QUESTION_TEXT";
            // 
            // m_AnswerTextBox
            // 
            this.m_AnswerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_AnswerTextBox.Location = new System.Drawing.Point(265, 475);
            this.m_AnswerTextBox.MaxLength = 0;
            this.m_AnswerTextBox.Name = "m_AnswerTextBox";
            this.m_AnswerTextBox.Size = new System.Drawing.Size(177, 40);
            this.m_AnswerTextBox.TabIndex = 3;
            this.m_AnswerTextBox.TextChanged += new System.EventHandler(this.m_AnswerTextBox_TextChanged);
            this.m_AnswerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m_AnswerTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Correct Answers:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_NumWrongAnswersLabel);
            this.groupBox1.Controls.Add(this.m_NumCorrectAnswersLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(29, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 160);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Score";
            // 
            // m_NumWrongAnswersLabel
            // 
            this.m_NumWrongAnswersLabel.AutoSize = true;
            this.m_NumWrongAnswersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_NumWrongAnswersLabel.ForeColor = System.Drawing.Color.Red;
            this.m_NumWrongAnswersLabel.Location = new System.Drawing.Point(128, 88);
            this.m_NumWrongAnswersLabel.Name = "m_NumWrongAnswersLabel";
            this.m_NumWrongAnswersLabel.Size = new System.Drawing.Size(26, 29);
            this.m_NumWrongAnswersLabel.TabIndex = 7;
            this.m_NumWrongAnswersLabel.Text = "0";
            // 
            // m_NumCorrectAnswersLabel
            // 
            this.m_NumCorrectAnswersLabel.AutoSize = true;
            this.m_NumCorrectAnswersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_NumCorrectAnswersLabel.ForeColor = System.Drawing.Color.Green;
            this.m_NumCorrectAnswersLabel.Location = new System.Drawing.Point(128, 28);
            this.m_NumCorrectAnswersLabel.Name = "m_NumCorrectAnswersLabel";
            this.m_NumCorrectAnswersLabel.Size = new System.Drawing.Size(26, 29);
            this.m_NumCorrectAnswersLabel.TabIndex = 6;
            this.m_NumCorrectAnswersLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Wrong Answers:";
            // 
            // m_SubmitAnswerButton
            // 
            this.m_SubmitAnswerButton.Location = new System.Drawing.Point(456, 475);
            this.m_SubmitAnswerButton.Name = "m_SubmitAnswerButton";
            this.m_SubmitAnswerButton.Size = new System.Drawing.Size(106, 40);
            this.m_SubmitAnswerButton.TabIndex = 6;
            this.m_SubmitAnswerButton.Text = "Submit";
            this.m_SubmitAnswerButton.UseVisualStyleBackColor = true;
            this.m_SubmitAnswerButton.Click += new System.EventHandler(this.submitAnswerButton_Click);
            // 
            // GuessingGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 550);
            this.Controls.Add(this.m_SubmitAnswerButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.m_AnswerTextBox);
            this.Controls.Add(this.m_QuestionLabel);
            this.Controls.Add(this.m_TitleLabel);
            this.Controls.Add(this.m_PictureBox);
            this.Name = "GuessingGameForm";
            this.Text = "TITLE";
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox m_PictureBox;
        private System.Windows.Forms.Label m_TitleLabel;
        private System.Windows.Forms.Label m_QuestionLabel;
        private System.Windows.Forms.TextBox m_AnswerTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label m_NumWrongAnswersLabel;
        private System.Windows.Forms.Label m_NumCorrectAnswersLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button m_SubmitAnswerButton;
    }
}