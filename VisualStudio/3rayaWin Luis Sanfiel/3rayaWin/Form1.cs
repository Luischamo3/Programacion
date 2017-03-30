using System;
using System.Windows.Forms;

namespace _3rayaWin
{
    /// <summary>
    /// Creación de la tabladebotones y variables que utilizamos
    /// </summary>
    public partial class Form1 : Form
    {
        
        juego j = new juego(3, 3);
        devolucion _dev;
        Button[,] tablabotones;
        public int N = 3;

        public Form1()
        {
            InitializeComponent();
            Crea();
        }
        /// <summary>
        /// Creación de la tabla de botones
        /// </summary>
        private void Crea()
        {
                        tablabotones = new Button[N, N];
            int k = panel1.Controls.Count - 1;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    tablabotones[i, j] = (Button)panel1.Controls[k];
                    k--;
                }

            }

        }

        /// <summary>
        /// Función que contiene lo que pasará cuando hagamos 
        /// click sobre cada casilla y escribe cada caracter 
        /// en la tabla de botones llamando a la as funciones de la clase 
        /// juego además de mostras los mensajes de victoria , empate o derrota
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, EventArgs e)
        {
            int fila, columna;

            Button clickedButton = (Button)sender;
            clickedButton.Text = "X";
            fila = Convert.ToInt32(clickedButton.Name[1].ToString());
            columna = Convert.ToInt32(clickedButton.Name[2].ToString());
            clickedButton.Enabled = false;

            j.movimientojugador(fila, columna, j.devol.turno);// Llamada a movimiento 
                                                               //jugador que a su vez llama a jugadaganadora y checkwinner
            if (j.devol.ganajugador) //Llamada a la función checkwinner
            {
                MessageBox.Show("!Has Ganado");
                panel1.Enabled = false;
            }
            if (!j.devol.empate && !j.devol.ganajugador)
            {
                j.movimientomaquina();//Llamada a la función checkwinner
            }
            tablabotones[j.devol.fila, j.devol.columna].Text = "O";
            tablabotones[j.devol.fila, j.devol.columna].Enabled = false;

            if (j.devol.ganamaquina)
            {
                MessageBox.Show("La máquina ha ganado");
                panel1.Enabled = false;
            }
            if (j.devol.empate)
            {
                MessageBox.Show("Has Empatado");
                panel1.Enabled = false;
            }

        }
        /// <summary>
        /// Función que resetea la tabla de botones habilitando 
        /// los botones nuevamente una vez finalize la partida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void reset_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            j.reset();
            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    tablabotones[i, k].Text = "-";
                    tablabotones[i, k].Enabled = true;
                }
            }
        }
    }
}
