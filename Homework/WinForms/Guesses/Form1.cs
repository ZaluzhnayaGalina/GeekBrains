using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guesses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int _userAnswer;
        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                _userAnswer = Convert.ToInt32(inputBox.Text);
                if (_game.CheckAttemptPosibility())
                    CheckAnswer();
                else
                    MessageBox.Show("У вас кончились попытки, вы проиграли!");
            }
            catch
            {
                MessageBox.Show("Вы ввели не число!");
            }
            
        }

        private void CheckAnswer()
        {
           // throw new NotImplementedException();
        }
    }
}
