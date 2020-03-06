using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirMetro
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        int a, b, res;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if ((int.TryParse(metroTextBox1.Text.ToString(), out a)) && (int.TryParse(metroTextBox2.Text.ToString(), out b))) res = a + b; else res = 1234567;
            if (res == 1234567) metroTextBox3.Text = "Ошибка!";
            else metroTextBox3.Text = " = " + res.ToString();
        }
    }
}
