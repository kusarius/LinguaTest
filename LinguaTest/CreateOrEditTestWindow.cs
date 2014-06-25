/* 
 * A window for creating or editing tests.
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
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LinguaTest
{
    public partial class CreateOrEditTestWindow : Form
    {
        public bool isSave = true;

        public CreateOrEditTestWindow()
        {
            InitializeComponent();
        }

        // Add word button
        private void button1_Click(object sender, EventArgs e)
        {
            AddNewWordWindow wnd = new AddNewWordWindow(this);
            wnd.Text = "Добавить слово";
            wnd.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                isSave = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dataGridView1.SelectedRows[0];
                WordObject res = AddNewWordWindow.ShowWindowDialog(r.Cells[0].Value.ToString(),
                    r.Cells[1].Value.ToString(), r.Cells[2].Value.ToString(), "Редактировать слово", this);
                if (res != null && res.Translate != null)
                {
                    dataGridView1.SelectedRows[0].Cells[0].Value = res.Word;
                    dataGridView1.SelectedRows[0].Cells[1].Value = res.Translate;
                    dataGridView1.SelectedRows[0].Cells[2].Value = WordObject.GetPartOfSpeechString(res.PartOfSpeech);
                    isSave = false;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog d = new SaveFileDialog();
                d.Filter = "Файлы тестов LinguaTest (*.ltt)|*.ltt";

                if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string output = "";
                    foreach (DataGridViewRow i in dataGridView1.Rows)
                    {
                        output += i.Cells[0].Value.ToString() + ":::";
                        output += i.Cells[1].Value.ToString() + ":::";
                        output += i.Cells[2].Value.ToString() + Environment.NewLine;
                    }
                    File.WriteAllText(d.FileName, output,Encoding.Default);
                    isSave = true;
                }
            }
        }

        private void CreateOrEditTestWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isSave || dataGridView1.Rows.Count == 0) return;
            DialogResult dr = MessageBox.Show("Сохранить изменения в тесте?", "LinguaTest", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.Cancel) e.Cancel = true;
            if (dr == System.Windows.Forms.DialogResult.Yes) button4_Click(null, null);
        }

        private void CreateOrEditTestWindow_Shown(object sender, EventArgs e)
        {
            label1.Width = label3.Width = 1;
            label2.Height = 1;
        }
    }
}