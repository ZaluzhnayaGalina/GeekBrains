using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson7
{
    public partial class Form1 : Form
    {

        GameDoubler _game;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToLongTimeString();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartNewGame(object sender, EventArgs e)
        {
            _game = new GameDoubler(15);
            UpdateInfo();
            btnMulti.Enabled = true;
            btnPlus.Enabled = true;
            btnReset.Enabled = true;
            btnBack.Enabled = true;
            _game.DataUpdated += UpdateInfo;
            _game.GameWon += WinMessage;

        }

        private void WinMessage(int count)
        {
            MessageBox.Show("Вы выиграли! Число ходов " + count);
            _game.Reset();
        }

        void UpdateInfo()
        {
            lblCurrent.Text = _game.Current.ToString();
            lblFinish.Text = _game.Finish.ToString();
            //lblMinCount.Text = gameDoubler.MinCount.ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (_game == null) return;
            _game.Plus();            
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (_game == null) return;
            _game.Multi();            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (_game == null) return;
            _game.Reset();           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _game.Undo();          
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }
    }
}
