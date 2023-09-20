using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"@");
            string str = textBox3.Text;

            MatchCollection match = regex.Matches(str);

            if(match.Count > 0 && textBox5.Text == textBox6.Text)
            {
                MessageBox.Show("Вы зарегистрировались!");
            }
            else
            {
                MessageBox.Show("Неправильная почта");
            }
            if (textBox5.Text == textBox6.Text)
            {
                MessageBox.Show("Вы зарегистрировались!");
            }
            else MessageBox.Show("Пароли не совпадают");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
