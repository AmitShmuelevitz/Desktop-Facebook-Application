using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookDesktop
{
    public partial class GuessingGameForm : Form
    {
        public Collection<object> Objects { get; set; }

        public IGuessingGameBuilderPictureFetcher PictureFetcher { get; set; }

        public IGuessingGameBuilderAnswerFetcher AnswerFetcher { get; set; }

        public string Title
        {
            get
            {
                return m_Title;
            }

            set
            {
                m_Title = value;
                Text = m_Title;
                m_TitleLabel.Text = m_Title;
            }
        }

        private string m_Title;

        public string QuestionText
        {
            get
            {
                return m_QuestionText;
            }

            set
            {
                m_QuestionText = value;
                m_QuestionLabel.Text = m_QuestionText;
            }
        }

        private string m_QuestionText;

        private Random m_Random = new Random();
        private string m_CurrentCorrectAnswer;

        private int m_NumCorrectAnswers = 0;
        private int m_NumWrongAnswers = 0;

        public int NumCorrectAnswers
        {
            get
            {
                return m_NumCorrectAnswers;
            }
        }

        public int NumWrongAnswers
        {
            get
            {
                return m_NumWrongAnswers;
            }
        }

        public int NumQuestionsAnswered
        {
            get
            {
                return m_NumCorrectAnswers + m_NumWrongAnswers;
            }
        }

        private object chooseRandomObject()
        {
            int chosenObjectIndex = m_Random.Next(0, Objects.Count);
            return Objects[chosenObjectIndex];
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            initRound();
        }

        public GuessingGameForm()
        {
            InitializeComponent();
        }

        private void initRound()
        {
            m_PictureBox.ImageLocation = null;
            m_AnswerTextBox.Text = string.Empty;
            object obj = chooseRandomObject();

            m_PictureBox.ImageLocation = PictureFetcher.GetPictureUrl(obj);

            m_CurrentCorrectAnswer = AnswerFetcher.GetCorrectAnswer(obj);
        }

        private void m_AnswerTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void m_AnswerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                submitAnswer();
            }
        }

        private void submitAnswerButton_Click(object sender, EventArgs e)
        {
            submitAnswer();
        }

        private bool userGuessedCorrectAnswer()
        {
            string guessedAnswer = m_AnswerTextBox.Text;
            return guessedAnswer.ToLower() == m_CurrentCorrectAnswer.ToLower();
        }

        private void submitAnswer()
        {
            if (m_AnswerTextBox.Text.Length == 0)
            {
                return;
            }

            if (userGuessedCorrectAnswer())
            {
                MessageBox.Show(string.Format("Correct!{0}The answer is {1}", Environment.NewLine, m_CurrentCorrectAnswer), "Correct!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                m_NumCorrectAnswers++;
                m_NumCorrectAnswersLabel.Text = m_NumCorrectAnswers.ToString();
            }
            else
            {
                MessageBox.Show(string.Format("Wrong!{0}You guessed: {1}{2}But the correct answer is: {3}", Environment.NewLine, m_AnswerTextBox.Text, Environment.NewLine, m_CurrentCorrectAnswer), "Wrong!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                m_NumWrongAnswers++;
                m_NumWrongAnswersLabel.Text = m_NumWrongAnswers.ToString();
            }

            if (NumQuestionsAnswered < 10)
            {
                initRound();
            }
            else
            {
                MessageBox.Show(string.Format("Game Over! You answered {0} out of {1} questions correctly!", m_NumCorrectAnswers, NumQuestionsAnswered), "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}
