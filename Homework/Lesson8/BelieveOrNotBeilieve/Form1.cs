using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BelieveOrNotBelieve
{
    public partial class Form1 : Form
    {
        //База данных с вопросами
        TrueFalse _database;
        const string Filter = "XML файлы(*.xml)|*.xml|Все файлы(*.*)|*.*";
        frmParams _param;

        void Func(string param)
        {
//            MessageBox.Show(param);
            tboxQuestion.Text = param;

        }

        public Form1()
        {
            InitializeComponent();
        }

        //Обработчик пункта меню Exit
        private void miExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Обработчик пункта меню New
        private void miNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = Filter;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _database = new TrueFalse(sfd.FileName);
                _database.Add("1", false);
                _database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            }
        }

        //Обработчик события изменения значения numericUpDown
        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            if (_database != null)
            {
                tboxQuestion.Text = _database[(int)nudNumber.Value - 1].Text;
                cboxTrue.Checked = _database[(int)nudNumber.Value - 1].TrueFalse;
            }
        }

        //Обработчик кнопки Добавить
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_database==null)
            {
                MessageBox.Show("Создайте новую базу данных","Сообщение");
                return;
            }
            _database.Add((_database.Count+1).ToString(), true);
            nudNumber.Maximum = _database.Count;
            nudNumber.Value = _database.Count;
        }

        //Обработчик кнопки Удалить
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (nudNumber.Maximum == 1 || _database == null) return;
            _database.Remove((int)nudNumber.Value);
            nudNumber.Maximum--;
            if (nudNumber.Value > 1) nudNumber_ValueChanged(sender, EventArgs.Empty);

        }

        //Обработчик пункта меню Save
        private void miSave_Click(object sender, EventArgs e)
        {
            if (_database != null)
                _database.Save();
            else MessageBox.Show("База данных не создана");
        }

        //Обработчик пункта меню Open
        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = Filter;
            ofd.InitialDirectory = Application.StartupPath;
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                _database = new TrueFalse(ofd.FileName);
                _database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = _database.Count;
                nudNumber.Value = 1;
            }
        }

        //Обработчик кнопки Сохранить(вопрос)
        private void btnSaveQuest_Click(object sender, EventArgs e)
        {
            _database[(int)nudNumber.Value-1].Text = tboxQuestion.Text;
            _database[(int)nudNumber.Value - 1].TrueFalse = cboxTrue.Checked;
        }

        private void cboxTrue_CheckedChanged(object sender, EventArgs e)
        {
            cboxTrue.Text = cboxTrue.Checked ? "Правда" : "Ложь";
        }

        private void nudNumber_Validating(object sender, CancelEventArgs e)
        {
            //MessageBox.Show("!!!");

        }

        private void nudNumber_MouseClick(object sender, MouseEventArgs e)
        {
            if (tsmiAutosave.Checked)
            {
                btnSaveQuest.PerformClick();
            }
        }

        private void tsmiParams_Click(object sender, EventArgs e)
        {
            _param = new frmParams(Func);
            _param.ShowDialog();
            tboxQuestion.Font = _param.font;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog(){Filter = Filter};
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _database.FileName = sfd.FileName;
                _database.Save();
            }
        }
    }
}
