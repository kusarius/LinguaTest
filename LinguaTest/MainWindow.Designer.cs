﻿namespace LinguaTest
{
    partial class MainWindow
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tESTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.пройтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hELPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеLinguaTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startLabel = new System.Windows.Forms.Label();
            this.wordsTable = new System.Windows.Forms.DataGridView();
            this.word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.translate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tESTToolStripMenuItem,
            this.hELPToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(629, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tESTToolStripMenuItem
            // 
            this.tESTToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tESTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.toolStripSeparator1,
            this.открытьToolStripMenuItem,
            this.закрытьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.toolStripSeparator3,
            this.пройтиToolStripMenuItem,
            this.toolStripSeparator2,
            this.выходToolStripMenuItem});
            this.tESTToolStripMenuItem.Name = "tESTToolStripMenuItem";
            this.tESTToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.tESTToolStripMenuItem.Text = "ТЕСТ";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Enabled = false;
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Enabled = false;
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(151, 6);
            // 
            // пройтиToolStripMenuItem
            // 
            this.пройтиToolStripMenuItem.Enabled = false;
            this.пройтиToolStripMenuItem.Name = "пройтиToolStripMenuItem";
            this.пройтиToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.пройтиToolStripMenuItem.Text = "Пройти";
            this.пройтиToolStripMenuItem.Click += new System.EventHandler(this.пройтиToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(151, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // hELPToolStripMenuItem
            // 
            this.hELPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеLinguaTestToolStripMenuItem});
            this.hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
            this.hELPToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.hELPToolStripMenuItem.Text = "СПРАВКА";
            // 
            // оПрограммеLinguaTestToolStripMenuItem
            // 
            this.оПрограммеLinguaTestToolStripMenuItem.Name = "оПрограммеLinguaTestToolStripMenuItem";
            this.оПрограммеLinguaTestToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.оПрограммеLinguaTestToolStripMenuItem.Text = "О программе LinguaTest";
            this.оПрограммеLinguaTestToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеLinguaTestToolStripMenuItem_Click);
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.startLabel.Location = new System.Drawing.Point(116, 225);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(510, 21);
            this.startLabel.TabIndex = 1;
            this.startLabel.Text = "Для начала работы создайте новый тест или откройте существующий...";
            // 
            // wordsTable
            // 
            this.wordsTable.AllowUserToAddRows = false;
            this.wordsTable.AllowUserToDeleteRows = false;
            this.wordsTable.AllowUserToResizeRows = false;
            this.wordsTable.BackgroundColor = System.Drawing.Color.White;
            this.wordsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wordsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.wordsTable.ColumnHeadersHeight = 20;
            this.wordsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.wordsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.word,
            this.translate,
            this.chast});
            this.wordsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wordsTable.Enabled = false;
            this.wordsTable.Location = new System.Drawing.Point(0, 24);
            this.wordsTable.MultiSelect = false;
            this.wordsTable.Name = "wordsTable";
            this.wordsTable.RowHeadersVisible = false;
            this.wordsTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.wordsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.wordsTable.ShowCellErrors = false;
            this.wordsTable.ShowCellToolTips = false;
            this.wordsTable.ShowEditingIcon = false;
            this.wordsTable.ShowRowErrors = false;
            this.wordsTable.Size = new System.Drawing.Size(629, 393);
            this.wordsTable.TabIndex = 2;
            this.wordsTable.Visible = false;
            // 
            // word
            // 
            this.word.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.word.HeaderText = "Слово";
            this.word.MinimumWidth = 50;
            this.word.Name = "word";
            this.word.ReadOnly = true;
            // 
            // translate
            // 
            this.translate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.translate.HeaderText = "Перевод";
            this.translate.MinimumWidth = 60;
            this.translate.Name = "translate";
            this.translate.ReadOnly = true;
            // 
            // chast
            // 
            this.chast.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chast.FillWeight = 40F;
            this.chast.HeaderText = "Часть речи";
            this.chast.MinimumWidth = 70;
            this.chast.Name = "chast";
            this.chast.ReadOnly = true;
            this.chast.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 1);
            this.label1.TabIndex = 3;
            this.label1.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 417);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wordsTable);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainWindow";
            this.Text = "LinguaTest";
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tESTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hELPToolStripMenuItem;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеLinguaTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem пройтиToolStripMenuItem;
        public System.Windows.Forms.DataGridView wordsTable;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn word;
        private System.Windows.Forms.DataGridViewTextBoxColumn translate;
        private System.Windows.Forms.DataGridViewTextBoxColumn chast;
        private System.Windows.Forms.Label label1;
    }
}

