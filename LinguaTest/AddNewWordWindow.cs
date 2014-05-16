/* 
 * A window for adding new word.
 * 
 * -----------------------------------------------
 * 
 * Author: Alexander Ragulin (kusarius@gmail.com)
 * 16.05.2014
 *
*/

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
    public partial class AddNewWordWindow : Form
    {
        public static bool isCancel = false;
        public static WordObject result;

        public AddNewWordWindow()
        {
            InitializeComponent();

            isCancel = false;
            result = new WordObject();

            this.MaximumSize = new Size(Screen.PrimaryScreen.Bounds.Width, this.Height);
        }

        public static WordObject ShowWindowDialog(string w, string tr, string pof, string title)
        {
            AddNewWordWindow wnd = new AddNewWordWindow();
            wnd.Text = title;
            wnd.textBox1.Text = w;
            wnd.textBox2.Text = tr;
            wnd.comboBox1.SelectedItem = pof;
            wnd.ShowDialog();
            if (!isCancel) return result;
            return null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isCancel = true;
            this.Close();
        }

        private string FormalWord(string w)
        {
            w = w.ToLower();
            return w[0].ToString().ToUpper() + w.Substring(1, w.Length - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                result = new WordObject(FormalWord(textBox1.Text), FormalWord(textBox2.Text),
                    WordObject.GetPartOfSpeech(comboBox1.SelectedItem.ToString()));
                this.Close();
            }
            catch
            {
                MessageBox.Show("Введены некорректные данные или не все поля заполнены!", "Ошибка", MessageBoxButtons.OK,
                     MessageBoxIcon.Exclamation);
            }
        }
    }
}