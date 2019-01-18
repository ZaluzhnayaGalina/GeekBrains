using System;
using System.Drawing;
using System.Windows.Forms;

struct Param
{
    string data;
    Font font;
}

namespace BelieveOrNotBelieve
{

    
    public delegate void MyDelegate(string data);


    public partial class frmParams : Form
    {
        public Font font=new Font(FontFamily.GenericMonospace,15);
        MyDelegate d;

        public frmParams(MyDelegate f)
        {
            InitializeComponent();
            d = f;
            global::Param p;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog()==DialogResult.OK)
            {
                lblFont.Text = fontDialog1.Font.Name;
                font = fontDialog1.Font;
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            d("Данные");
            Close();
        }
    }
}
