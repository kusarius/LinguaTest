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
    public partial class SelectKindOfTestWindow : Form
    {
        public SelectKindOfTestWindow()
        {
            InitializeComponent();
        }

        /*  He ... born in 1985.
         *  1) was
         *  2) were
         *  3) is
         *  4) as
         *  
         *  He$::__was__$::were$::is$::as$::born in 1985.
         *  [He, __was__, were, is, as, born in 1985.]
         */

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (radioButton1.Checked)
            {
                CreateOrEditTestWindow w = new CreateOrEditTestWindow();
                w.ShowDialog();
            }
            else
            {
            }
        }
    }
}
