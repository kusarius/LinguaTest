using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataGridViewRichTextBox;

namespace LinguaTest
{
    public partial class ResultForm : Form
    {
        public ResultForm(string[] exept, string[] ans)
        {
            InitializeComponent();

            DataGridViewRichTextBoxColumn rtbc = new DataGridViewRichTextBoxColumn();
            rtbc.HeaderText = "Результат";
            rtbc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            rtbc.ReadOnly = true;
            rtbc.MinimumWidth = 70;
            dataGridView1.Columns.Add(rtbc);

            dataGridView1.Rows.Add("Hello", "World");

            DataGridViewRichTextBoxCell c = new DataGridViewRichTextBoxCell();
            RichTextBox r = new RichTextBox();
            r.Text = "Hello, language!";
            r.Font = new System.Drawing.Font("Segoe UI Light", 10);
            r.Select(2, 7);
            r.SelectionColor = Color.Blue;
            r.SelectAll();
            r.SelectionAlignment = HorizontalAlignment.Center;
            c.Value = r.Rtf;

            dataGridView1.Rows[0].Cells[3] = c;

        }
    }
}
