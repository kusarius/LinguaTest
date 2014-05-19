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
        private CreateOrEditTestWindow _owner;

        public AddNewWordWindow(CreateOrEditTestWindow owner)
        {
            InitializeComponent();

            isCancel = false;
            result = new WordObject();
            _owner = owner;

            this.MaximumSize = new Size(Screen.PrimaryScreen.Bounds.Width, this.Height);
        }

        public static WordObject ShowWindowDialog(string w, string tr, string pof, string title, CreateOrEditTestWindow owner)
        {
            AddNewWordWindow wnd = new AddNewWordWindow(owner);
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

        private void button1_Click(object sender, EventArgs e)
        {
            string sError = "";
            textBox1.Text = textBox1.Text.Trim();
            textBox2.Text = textBox2.Text.Trim();
            if (textBox1.Text == "") sError += "Поле \"Слово\" должно быть заполнено!";
            if (textBox2.Text == "") sError += Environment.NewLine + "Поле \"Перевод\" должно быть заполнено!";
            if (comboBox1.SelectedItem == null) sError += Environment.NewLine + "Не указана часть речи!";
            if (sError != "") MessageBox.Show(sError.Trim(), "LinguaTest", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (this.Text == "Добавить слово")
                {
                    _owner.dataGridView1.Rows.Add(Utils.FormalWord(textBox1.Text.Trim()), Utils.FormalWord(textBox2.Text.Trim()),
                        WordObject.GetPartOfSpeech(comboBox1.SelectedItem.ToString()));
                    _owner.isSave = false;
                    textBox1.Clear();
                    textBox2.Clear();
                    comboBox1.SelectedItem = null;
                }
                else
                {
                    result = new WordObject(Utils.FormalWord(textBox1.Text.Trim()), Utils.FormalWord(textBox2.Text.Trim()),
                        WordObject.GetPartOfSpeech(comboBox1.SelectedItem.ToString()));
                    this.Close();
                }
            }
        }
    }
}