using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataGridViewRichTextBox;
using LinguaTest.Properties;

namespace LinguaTest
{
    public partial class ResultForm : Form
    {
        public ResultForm(List<UserAnswer> answers)
        {
            InitializeComponent();

            int rightAns = 0;
            Image tick = Resources.tick, cross = Resources.cross;
            for (int i = 0; i < answers.Count; i++ )
            {
                if (answers[i].Answer == null)
                {
                    answers[i].Answer = answers[i].RightAnswer;
                    dataGridView1.Rows.Add(answers[i].Question, "-", answers[i].FormattedAnswer(), cross);
                }
                else
                {
                    if (answers[i].IsCorrect) rightAns++;
                    dataGridView1.Rows.Add(answers[i].Question, answers[i].Answer, answers[i].FormattedAnswer(),
                        answers[i].IsCorrect ? tick : cross);
                }
            }

            double percent = ((double)rightAns / (double)answers.Count) * 100.0;
            resLabel.Text = string.Format("Вы правильно ответили на {0} ({1:N2}%). Уровень подготовки - {2}.",
                rightAns.ToString() + " " + get_correct_str(rightAns, "вопрос", "вопроса", "вопросов"),
                percent, GetLevelFromPercent(percent));
            UpdateResLabel();
        }

        private string get_correct_str(int num, string str1, string str2, string str3)
        {
            int val = num % 100;
            if (val > 10 && val < 20) return str3;
            else
            {
                val = num % 10;
                if (val == 1) return str1;
                else if (val > 1 && val < 5) return str2;
                else return str3;
            }
        }

        private string GetLevelFromPercent(double pc)
        {
            if (pc >= 0 && pc < 20) return "Низкий";
            else if (pc >= 20 && pc < 40) return "Ниже среднего";
            else if (pc >= 40 && pc < 60) return "Средний";
            else if (pc >= 60 && pc < 80) return "Выше среднего";
            else return "Высокий";
        }

        private void UpdateResLabel()
        {
            resLabel.Location = new Point(this.Width / 2 - resLabel.Width / 2, resLabel.Location.Y);
        }

        private void ResultForm_Resize(object sender, EventArgs e)
        {
            UpdateResLabel();
        }

        private void ResultForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.Close();
        }
    }
}