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
                {
                    MessageBox.Show("У вас кончились попытки, вы проиграли!");
                    RestartGame();
                }
            }
            catch
            {
                MessageBox.Show("Вы ввели не число!");
            }
            
        }

        private void CheckAnswer()
        {
            attemptsList.Items.Add(_userAnswer);
            if (_game.UserAnswerIsGreater(_userAnswer))
            {
                labelResult.Text = "Введенное число больше загаданного";
                return;
            }
            if (_game.UserAnswerIsLess(_userAnswer))
            {
                labelResult.Text = "Введенное число меньше загаданного";
                return;
            }
            labelResult.Text = _userAnswer.ToString();
            MessageBox.Show("Вы выиграли!");
            RestartGame();
        }
        private void RestartGame()
        {
            _game = new GuessesGame();
            labelResult.Text = String.Empty;
            inputBox.Text = String.Empty;
            attemptsList.Items.Clear();
        }
    }
}
