using System;
using System.Windows.Forms;

namespace Guesses
{
    /*Залужная
     * 2. Используя Windows Forms, разработать игру «Угадай число».
     * Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток.
     * Для ввода данных от человека используется элемент TextBox.*/
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
