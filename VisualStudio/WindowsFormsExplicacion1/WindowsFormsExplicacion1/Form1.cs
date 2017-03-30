using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExplicacion1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonsuma_Click(object sender, EventArgs e)
        {
            int num1 = 0, num2 = 0, num3 = 0,resu;
            num1 = Convert.ToInt32(this.textBox1.Text);
            num2 = Convert.ToInt32(this.textBox2.Text);
            resu = num1 + num2;
            textBox3.Text = resu.ToString();

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            //int num1 = 0;
            TextBox auxBox;
            auxBox = (TextBox) sender;
            try
            {
                Convert.ToInt32(auxBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Dato no Numérico");
                auxBox.SelectAll();
                //auxBox.Focus();
                //otra forma de hacerlo
                e.Cancel = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char )ConsoleKey.Enter) // (char)13
                //(char)Keys.Enter
            {
                textBox2.Focus();
            }
        }
    }
}
