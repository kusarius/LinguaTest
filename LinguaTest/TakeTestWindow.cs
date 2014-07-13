using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LinguaTest
{
    public partial class TakeTestWindow : Form
    {
        WordObject[] questions; // Test questions
        List<UserAnswer> answers = new List<UserAnswer>();
        UserAnswer currentAnswer = new UserAnswer();
        int questionNumber = 0; // Current question number
        Random rnd = new Random();
        int tipIndex = 1;
        bool isDone = false; // Is test completed

        public TakeTestWindow(WordObject[] qs)
        {
            InitializeComponent();

            this.MaximumSize = new Size(Screen.PrimaryScreen.Bounds.Width, this.Height);
            questions = Utils.Shuffle<WordObject>(qs);

            UpdateQuestion();
        }

        private void UpdateQuestion()
        {
            if (questionNumber == questions.Length)
            {
                isDone = true;
                this.Close();
                ShowResults();
            }
            else
            {
                currentAnswer = new UserAnswer();
                textBox1.Clear();
                string question = "", rightAnswer = "";
                if (rnd.Next(0, 2) == 0)
                {
                    question = questions[questionNumber].Word;
                    rightAnswer = questions[questionNumber].Translate;
                }
                else
                {
                    question = questions[questionNumber].Translate;
                    rightAnswer = questions[questionNumber].Word;
                }

                qLabel.Text = question;
                qNumberLabel.Text = "Вопрос " + (questionNumber + 1) + " из " + questions.Length + ".";

                currentAnswer.Question = question;
                currentAnswer.RightAnswer = rightAnswer;

                questionNumber++;
            }
        }

        private void TakeTestWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isDone)
            {
                DialogResult dr = MessageBox.Show("Прохождение теста не закончено! Выход?", "LinguaTest",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == System.Windows.Forms.DialogResult.No) e.Cancel = true;
            }
        } 

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowResults()
        {
            ResultForm resForm = new ResultForm(answers);
            resForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ans = textBox1.Text.Trim();
            if (ans == "")
            {
                MessageBox.Show("Поле ответа не должно быть пустым!", "LinguaTest",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            currentAnswer.Answer = Utils.FormalWord(ans);
            answers.Add(currentAnswer);

            UpdateQuestion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentAnswer.Answer = null;
            answers.Add(currentAnswer);
            UpdateQuestion();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = currentAnswer.RightAnswer.Substring(0, tipIndex++);
            if (tipIndex > currentAnswer.RightAnswer.Length) tipIndex = 1;
        }
    }
}