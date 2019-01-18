using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BelieveOrNotBelieve
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private IContainer components = null;

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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new MenuStrip();
            this.miFile = new ToolStripMenuItem();
            this.miNew = new ToolStripMenuItem();
            this.miOpen = new ToolStripMenuItem();
            this.miSave = new ToolStripMenuItem();
            this.toolStripMenuItem1 = new ToolStripSeparator();
            this.miExit = new ToolStripMenuItem();
            this.tboxQuestion = new TextBox();
            this.cboxTrue = new CheckBox();
            this.btnAdd = new Button();
            this.btnDelete = new Button();
            this.nudNumber = new NumericUpDown();
            this.btnSaveQuest = new Button();
            this.настройкиToolStripMenuItem = new ToolStripMenuItem();
            this.tsmiAutosave = new ToolStripMenuItem();
            this.tsmiParams = new ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((ISupportInitialize)(this.nudNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
            this.miFile,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new Size(487, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new ToolStripItem[] {
            this.miNew,
            this.miOpen,
            this.miSave,
            this.toolStripMenuItem1,
            this.miExit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new Size(37, 20);
            this.miFile.Text = "File";
            // 
            // miNew
            // 
            this.miNew.Name = "miNew";
            this.miNew.Size = new Size(152, 22);
            this.miNew.Text = "New";
            this.miNew.Click += new EventHandler(this.miNew_Click);
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.Size = new Size(152, 22);
            this.miOpen.Text = "Open";
            this.miOpen.Click += new EventHandler(this.miOpen_Click);
            // 
            // miSave
            // 
            this.miSave.Name = "miSave";
            this.miSave.Size = new Size(152, 22);
            this.miSave.Text = "Save";
            this.miSave.Click += new EventHandler(this.miSave_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new Size(149, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new Size(152, 22);
            this.miExit.Text = "Exit";
            this.miExit.Click += new EventHandler(this.miExit_Click);
            // 
            // tboxQuestion
            // 
            this.tboxQuestion.Dock = DockStyle.Top;
            this.tboxQuestion.Location = new Point(0, 24);
            this.tboxQuestion.Multiline = true;
            this.tboxQuestion.Name = "tboxQuestion";
            this.tboxQuestion.Size = new Size(487, 140);
            this.tboxQuestion.TabIndex = 1;
            // 
            // cboxTrue
            // 
            this.cboxTrue.Appearance = Appearance.Button;
            this.cboxTrue.Location = new Point(375, 168);
            this.cboxTrue.Name = "cboxTrue";
            this.cboxTrue.Size = new Size(60, 26);
            this.cboxTrue.TabIndex = 2;
            this.cboxTrue.Text = "Правда";
            this.cboxTrue.UseVisualStyleBackColor = false;
            this.cboxTrue.CheckedChanged += new EventHandler(this.cboxTrue_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new Point(13, 171);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new Point(109, 171);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);
            // 
            // nudNumber
            // 
            this.nudNumber.Location = new Point(304, 168);
            this.nudNumber.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new Size(52, 20);
            this.nudNumber.TabIndex = 5;
            this.nudNumber.ValueChanged += new EventHandler(this.nudNumber_ValueChanged);
            this.nudNumber.MouseClick += new MouseEventHandler(this.nudNumber_MouseClick);
            // 
            // btnSaveQuest
            // 
            this.btnSaveQuest.Location = new Point(191, 171);
            this.btnSaveQuest.Name = "btnSaveQuest";
            this.btnSaveQuest.Size = new Size(75, 23);
            this.btnSaveQuest.TabIndex = 6;
            this.btnSaveQuest.Text = "Сохранить";
            this.btnSaveQuest.UseVisualStyleBackColor = true;
            this.btnSaveQuest.Click += new EventHandler(this.btnSaveQuest_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.tsmiAutosave,
            this.tsmiParams});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // tsmiAutosave
            // 
            this.tsmiAutosave.Checked = true;
            this.tsmiAutosave.CheckOnClick = true;
            this.tsmiAutosave.CheckState = CheckState.Checked;
            this.tsmiAutosave.Name = "tsmiAutosave";
            this.tsmiAutosave.Size = new Size(217, 22);
            this.tsmiAutosave.Text = "Сохранять автоматически";
            // 
            // tsmiParams
            // 
            this.tsmiParams.Name = "tsmiParams";
            this.tsmiParams.Size = new Size(217, 22);
            this.tsmiParams.Text = "Параметры";
            this.tsmiParams.Click += new EventHandler(this.tsmiParams_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(487, 199);
            this.Controls.Add(this.btnSaveQuest);
            this.Controls.Add(this.nudNumber);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboxTrue);
            this.Controls.Add(this.tboxQuestion);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Верю - Не верю";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((ISupportInitialize)(this.nudNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem miFile;
        private ToolStripMenuItem miNew;
        private ToolStripMenuItem miOpen;
        private ToolStripMenuItem miSave;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem miExit;
        private TextBox tboxQuestion;
        private CheckBox cboxTrue;
        private Button btnAdd;
        private Button btnDelete;
        private NumericUpDown nudNumber;
        private Button btnSaveQuest;
        private ToolStripMenuItem настройкиToolStripMenuItem;
        private ToolStripMenuItem tsmiAutosave;
        private ToolStripMenuItem tsmiParams;
    }
}

