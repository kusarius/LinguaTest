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
            foreach (Form i in Application.OpenForms)
                if (i.Name == "CreateOrEditTestWindow")
                {
                    i.Focus();
                    return;
                }

            CreateOrEditTestWindow w = new CreateOrEditTestWindow();
            w.Show();
        }
    }
}
