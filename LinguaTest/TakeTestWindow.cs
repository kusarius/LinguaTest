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
        private int qNumber = 0;
        private Random rnd = new Random();
        private int rightAns = 0;
        private string[] answers, _answers;
        private bool isDone = false;

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

        private void button1_Click(object sender, EventArgs e)
        {
            string ans = "";
            if (qLabel.Text == questions[qNumber - 1].Word + ":") ans = questions[qNumber - 1].Translate.ToLower();
            else ans = questions[qNumber - 1].Word.ToLower();
            _answers[qNumber - 1] = ans;

            string answ = textBox1.Text.Trim().ToLower();
            answers[qNumber - 1] = answ;
            if (answ == ans) rightAns++;

            if (qNumber == questions.Length)
            {
                isDone = true;
                this.Close();
            }
            else UpdateQuestion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ans = "";
            if (qLabel.Text == questions[qNumber - 1].Word) ans = questions[qNumber - 1].Translate.ToLower();
            else ans = questions[qNumber - 1].Word.ToLower();
            _answers[qNumber - 1] = ans;
            answers[qNumber - 1] = "Don't fucking know...";
            UpdateQuestion();
        }
    }
}