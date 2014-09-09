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
    public partial class CreateOrEditVarTestWindow : Form
    {
        public CreateOrEditVarTestWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewQuestionWindow w = new AddNewQuestionWindow();
            w.Text = "Добавить вопрос";
            w.ShowDialog();
        }
    }
}
