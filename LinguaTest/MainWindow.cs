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

namespace LinguaTest {
    public partial class MainWindow : Form {
        private SystemMenu sMenu = null;
        private bool showMenu = true;

        public MainWindow() {
            InitializeComponent();

            // Locate startLabel to the center of the screen
            UpdateStartLabel();

            sMenu = SystemMenu.FromForm(this);
            sMenu.AppendSeparator();
            sMenu.AppendMenu(11, "Показать меню");
            sMenu.AppendMenu(22, "Скрыть меню");
        }

        // Переопроеделяем WndProc для перехвата нажатий кнопок в системном меню
        protected override void WndProc(ref Message m) {
            if (m.Msg == (int)SystemMenu.WindowMessages.wmSysCommand) {
                switch (m.WParam.ToInt32()) {
                    case 11:
                        showMenu = true;
                        break;
                    case 22:
                        showMenu = false;
                        break;
                }
                UpdateMenu();
            }
            base.WndProc(ref m);
        }

        private void UpdateMenu() {
            menuStrip1.Visible = menuStrip1.Enabled = 
                label1.Visible = label1.Enabled = showMenu;
        }

        private void MainWindow_Resize(object sender, EventArgs e) {
            if (startLabel.Visible == true)
                UpdateStartLabel();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e) {
            CreateOrEditTestWindow w = new CreateOrEditTestWindow();
            w.ShowDialog();
        }

        private void EnableControls(bool value) {
            startLabel.Visible = startLabel.Enabled = !value;
            wordsTable.Enabled = wordsTable.Visible =
               label1.Enabled = label1.Visible = value;
            редактироватьToolStripMenuItem.Enabled =
                пройтиToolStripMenuItem.Enabled =
                закрытьToolStripMenuItem.Enabled = value;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "Файлы тестов LinguaTest (*.ltt)|*.ltt";

            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                string fStr = File.ReadAllText(d.FileName, Encoding.Default);
                string[] sWords = fStr.Trim().Split(new string[] { Environment.NewLine, "\r", "\n" }, StringSplitOptions.None);
                WordObject[] words = new WordObject[sWords.Length];
                wordsTable.Rows.Clear();
                for (int i = 0; i < sWords.Length; ++i) {
                    string[] parts = sWords[i].Split(new string[] { ":::" }, StringSplitOptions.None);
                    words[i] = new WordObject(parts[0], parts[1], WordObject.GetPartOfSpeech(parts[2]));
                    wordsTable.Rows.Add(words[i].Word, words[i].Translate,
                        WordObject.GetPartOfSpeechString(words[i].PartOfSpeech));
                }
                EnableControls(true);

                /* При прокрутке элементов таблицы стрелкой вниз 
                проявляется баг в контроле DataGridView. Единственный известный мне 
                фикс - изменение размера таблицы. */
                wordsTable.Width++;
                wordsTable.Width--;
            }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e) {
            wordsTable.Rows.Clear();
            EnableControls(false);
            UpdateStartLabel();
        }

        private void UpdateStartLabel() {
            startLabel.Location = new Point(this.Width / 2 - startLabel.Width / 2,
                    this.Height / 2 - startLabel.Height / 2 - 20);
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e) {
            CreateOrEditTestWindow w = new CreateOrEditTestWindow();
            foreach (DataGridViewRow i in this.wordsTable.Rows)
                w.dataGridView1.Rows.Add(i.Cells[0].Value, i.Cells[1].Value, i.Cells[2].Value);
            w.ShowDialog();
        }

        private void пройтиToolStripMenuItem_Click(object sender, EventArgs e) {
            WordObject[] words = new WordObject[wordsTable.Rows.Count];
            for (int i = 0; i < wordsTable.Rows.Count; ++i) {
                DataGridViewCellCollection cc = wordsTable.Rows[i].Cells;
                words[i] = new WordObject(cc[0].Value as string, cc[1].Value as string,
                    WordObject.GetPartOfSpeech(cc[2].Value as string));
            }
            TakeTestWindow tw = new TakeTestWindow(words);
            EnableControls(false);
            startLabel.Text = "Идёт прохождение теста...";
            UpdateStartLabel();
            tw.ShowDialog();
            EnableControls(true);
            startLabel.Text = "Для начала работы создайте новый тест или откройте существующий...";
            UpdateStartLabel();
        }

        private void оПрограммеLinguaTestToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("LinguaTest 1.1, 25.06.2014\nАвтор: Рагулин Александр (kusarius)\n" +
                "Баг-репорты, замечания и предложения отправляйте на e-mail:\n" +
                "     kusarius@gmail.com\n     ragulin.alexander@gmail.com",
                "О программе LinguaTest", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}