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
        private WordObject[] questions;
        private int qNumber = 0; // Current question number
        private Random rnd = new Random();
        private int rightAns = 0; // Right answers count
        private string[] answers, 
                        _answers;
        private bool isDone = false; // Is the test done

        public TakeTestWindow(WordObject[] qs)
        {
            InitializeComponent();

            this.MaximumSize = new Size(Screen.PrimaryScreen.Bounds.Width, this.Height);
            questions = Utils.Shuffle<WordObject>(qs);
            answers = _answers = new string[questions.Length];

            UpdateQuestion();
        }

        private void UpdateQuestion()
        {
            qNumberLabel.Text = "Вопрос " + ++qNumber + " из " + questions.Length;
            qLabel.Text = ((rnd.Next(0, 2) == 0) ? questions[qNumber - 1].Word
                : questions[qNumber - 1].Translate) + ":";
            textBox1.Clear();
            string ans = "";
            if (qLabel.Text == questions[qNumber - 1].Word +":") ans = questions[qNumber - 1].Translate.ToLower();
            else ans = questions[qNumber - 1].Word.ToLower();
            _answers[qNumber - 1] = ans;
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
            ResultForm f = new ResultForm(_answers, answers);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string answ = textBox1.Text.Trim().ToLower();
            answers[qNumber - 1] = answ;
            if (answ == _answers[qNumber-1]) rightAns++;

            if (qNumber == questions.Length)
            {
                isDone = true;
                ShowResults();
                this.Close();
            }
            else UpdateQuestion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            answers[qNumber - 1] = "Don't fucking know...";
            if (qNumber == questions.Length)
            {
                isDone = true;
                ShowResults();
                this.Close();
            }
            else UpdateQuestion();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += _answers[qNumber - 1].Substring(_answers[qNumber].Length, 1);
        }
    }
}