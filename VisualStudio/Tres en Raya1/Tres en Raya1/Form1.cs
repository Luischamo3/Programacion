using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tres_en_Raya1
{
    public partial class Form1 : Form
    {
        Button[,] TBoton;
        private int N;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Crea()
        {
           int i, j, k;
            // string cadena = null;
            N = 3;
            TBoton = new Button[N, N];

            k = panel1.Controls.Count - 1;
            for (i = 0; i < N; i++)

                for (j = 0; j < N; j++)
                {
                    TBoton[i, j] = (Button) panel1.Controls[k];
                    k--;
                }
        }// Creamos la tabla de botones

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j, k;
            for (i = 0; i < N; i++)

                for (j = 0; j < N; j++)
                {
                    TBoton[i, j].Text="-";
                    TBoton[i, j] = Enabled;
                    k--;
                }
    }
}
