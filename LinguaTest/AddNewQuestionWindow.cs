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
    public partial class AddNewQuestionWindow : Form
    {
        public static bool isCancel = false;
        public static QuestionObject result;

        public AddNewQuestionWindow()
        {
            InitializeComponent();

        }

        public static QuestionObject ShowWindowDialog(string title, string fp, string sp,
            string v1, string v2, string v3, string v4, int ran)
        {
            AddNewQuestionWindow w = new AddNewQuestionWindow();
            w.Text = title;
            w.textBox1.Text = fp;
            w.textBox2.Text = sp;
            w.textBox3.Text = v1;
            w.textBox4.Text = v2;
            w.textBox5.Text = v3;
            w.textBox6.Text = v4;
            (w.Controls["radioButton" + ran.ToString()] as CheckBox).Checked = true;
            w.ShowDialog();
            if (!isCancel) return result;
            return null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isCancel = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }
    }
}
