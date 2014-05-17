/* 
 * LinguaTest main window.
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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            // Locate startLabel to the center of the screen
            startLabel.Location = new Point(this.Width / 2 - startLabel.Width / 2,
                this.Height / 2 - startLabel.Height / 2 - 20);
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            if (startLabel.Visible == true) 
                startLabel.Location = new Point(this.Width / 2 - startLabel.Width / 2,
                    this.Height / 2 - startLabel.Height / 2 - 20);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateOrEditTestWindow w = new CreateOrEditTestWindow();
            w.ShowDialog();
        }

        private void EnableControls(bool value)
        {
            startLabel.Visible = startLabel.Enabled = !value;
            dataGridView1.Enabled = dataGridView1.Visible = value;
            редактироватьToolStripMenuItem.Enabled =
                пройтиToolStripMenuItem.Enabled =
                закрытьToolStripMenuItem.Enabled = value;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "Файлы тестов LinguaTest (*.ltt)|*.ltt";

            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fStr = File.ReadAllText(d.FileName, Encoding.Default);
                string[] sWords = fStr.Trim().Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                WordObject[] words = new WordObject[sWords.Length];
                dataGridView1.Rows.Clear();
                for (int i = 0; i < sWords.Length; ++i)
                {
                    string[] parts = sWords[i].Split(new string[] { ":::" }, StringSplitOptions.None);
                    words[i] = new WordObject(parts[0], parts[1], WordObject.GetPartOfSpeech(parts[2]));
                    dataGridView1.Rows.Add(words[i].Word, words[i].Translate,
                        WordObject.GetPartOfSpeechString(words[i].PartOfSpeech));
                }
                EnableControls(true);
            }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            EnableControls(false);
            startLabel.Location = new Point(this.Width / 2 - startLabel.Width / 2,
                    this.Height / 2 - startLabel.Height / 2 - 20);
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateOrEditTestWindow w = new CreateOrEditTestWindow();
            foreach (DataGridViewRow i in this.dataGridView1.Rows)
                w.dataGridView1.Rows.Add(i.Cells[0].Value, i.Cells[1].Value, i.Cells[2].Value);
            w.ShowDialog();
        }

        private void пройтиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}