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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miNew = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAutosave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiParams = new System.Windows.Forms.ToolStripMenuItem();
            this.tboxQuestion = new System.Windows.Forms.TextBox();
            this.cboxTrue = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.btnSaveQuest = new System.Windows.Forms.Button();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(487, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNew,
            this.miOpen,
            this.miSave,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.miExit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(37, 20);
            this.miFile.Text = "File";
            // 
            // miNew
            // 
            this.miNew.Name = "miNew";
            this.miNew.Size = new System.Drawing.Size(152, 22);
            this.miNew.Text = "New";
            this.miNew.Click += new System.EventHandler(this.miNew_Click);
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.Size = new System.Drawing.Size(152, 22);
            this.miOpen.Text = "Open";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // miSave
            // 
            this.miSave.Name = "miSave";
            this.miSave.Size = new System.Drawing.Size(152, 22);
            this.miSave.Text = "Save";
            this.miSave.Click += new System.EventHandler(this.miSave_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(152, 22);
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAutosave,
            this.tsmiParams});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // tsmiAutosave
            // 
            this.tsmiAutosave.Checked = true;
            this.tsmiAutosave.CheckOnClick = true;
            this.tsmiAutosave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiAutosave.Name = "tsmiAutosave";
            this.tsmiAutosave.Size = new System.Drawing.Size(217, 22);
            this.tsmiAutosave.Text = "Сохранять автоматически";
            // 
            // tsmiParams
            // 
            this.tsmiParams.Name = "tsmiParams";
            this.tsmiParams.Size = new System.Drawing.Size(217, 22);
            this.tsmiParams.Text = "Параметры";
            this.tsmiParams.Click += new System.EventHandler(this.tsmiParams_Click);
            // 
            // tboxQuestion
            // 
            this.tboxQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxQuestion.Location = new System.Drawing.Point(0, 24);
            this.tboxQuestion.Multiline = true;
            this.tboxQuestion.Name = "tboxQuestion";
            this.tboxQuestion.Size = new System.Drawing.Size(487, 140);
            this.tboxQuestion.TabIndex = 1;
            // 
            // cboxTrue
            // 
            this.cboxTrue.Appearance = System.Windows.Forms.Appearance.Button;
            this.cboxTrue.Location = new System.Drawing.Point(375, 168);
            this.cboxTrue.Name = "cboxTrue";
            this.cboxTrue.Size = new System.Drawing.Size(60, 26);
            this.cboxTrue.TabIndex = 2;
            this.cboxTrue.Text = "Правда";
            this.cboxTrue.UseVisualStyleBackColor = false;
            this.cboxTrue.CheckedChanged += new System.EventHandler(this.cboxTrue_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 171);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(109, 171);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // nudNumber
            // 
            this.nudNumber.Location = new System.Drawing.Point(304, 168);
            this.nudNumber.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(52, 20);
            this.nudNumber.TabIndex = 5;
            this.nudNumber.ValueChanged += new System.EventHandler(this.nudNumber_ValueChanged);
            this.nudNumber.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nudNumber_MouseClick);
            // 
            // btnSaveQuest
            // 
            this.btnSaveQuest.Location = new System.Drawing.Point(191, 171);
            this.btnSaveQuest.Name = "btnSaveQuest";
            this.btnSaveQuest.Size = new System.Drawing.Size(75, 23);
            this.btnSaveQuest.TabIndex = 6;
            this.btnSaveQuest.Text = "Сохранить";
            this.btnSaveQuest.UseVisualStyleBackColor = true;
            this.btnSaveQuest.Click += new System.EventHandler(this.btnSaveQuest_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 199);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
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
        private ToolStripMenuItem saveAsToolStripMenuItem;
    }
}

