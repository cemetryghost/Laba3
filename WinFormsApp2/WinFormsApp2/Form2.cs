using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string pass = textBox2.Text;

            MessageBox.Show(!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(pass) ? 
                "Вы вошли!" : "Заполните все поля!!");
        }
    }
}
