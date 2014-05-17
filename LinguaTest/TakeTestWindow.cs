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
        private int qNumber = 1;
        private Random rnd = new Random();

        public TakeTestWindow(WordObject[] qs)
        {
            InitializeComponent();

            this.MaximumSize = new Size(Screen.PrimaryScreen.Bounds.Width, this.Height);
            questions = Utils.Shuffle<WordObject>(qs);

            qNumberLabel.Text = "Вопрос " + qNumber + " из " + questions.Length;
            qLabel.Text = (rnd.Next(0,2) == 0) ? questions[qNumber - 1].Word
                : questions[qNumber - 1].Translate + ":";
        }

        private void TakeTestWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Прохождение теста не закончено! Выход?", "LinguaTest",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == System.Windows.Forms.DialogResult.No) e.Cancel = true;
        }
    }
}
