using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFicheroExamenPracticar
{
    public partial class FormIniciar : Form
    {
        private Fichero f1, f2;
        private List<string> l1;
        private List<tipo> l2;
        private List<string> cajas;

        

        public FormIniciar()
        {
            InitializeComponent();
        }


        private void grabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (f1.abre())
                {
                    f1.fin();
                    carga(cajas);
                    f1.escribe(cajas);
                }
            }
            catch (Exception e1)
            {
                throw new Exception(e1.Message);

            }
            finally
            {
                f1.cierra();
            }

        }
        
        private void crearfichero_Click(object sender, EventArgs e)
        {
           /* crearfichero.Enabled = true;
            grabar.Enabled = false;
            buttoncalculamedia.Enabled = false;
            cargamedias.Enabled = false;*/

          


            l1 = new List<string>();
            l2 = new List<tipo>();
            cajas = new List<string>();

            l1.Add("Dorsal");
            l1.Add("Nombre Jugador");
            l1.Add("Goles 2015");
            l1.Add("Goles 2016");
            l2.Add(tipo.entero);
            l2.Add(tipo.cadena);
            l2.Add(tipo.entero);
            l2.Add(tipo.entero);


            try
            {
                f1 = new Fichero("Goles.dat", l1, l2);
            }
            catch (Exception e1)
            {

                MessageBox.Show(e1.Message);
                return;
            }

            l1.Clear();
            l2.Clear();
            l1.Add("Dorsal");
            l1.Add("Nombre Jugador");
            l1.Add("Goles 2015");
            l1.Add("Goles 2016");
            l1.Add("media Goles");
            l2.Add(tipo.entero);
            l2.Add(tipo.cadena);
            l2.Add(tipo.entero);
            l2.Add(tipo.entero);
            l2.Add(tipo.doble);

            try
            {
                f2 = new Fichero("MediaGoles.dat", l1, l2);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                return;
            }

        }

      

        private void buttoncalculamedia_Click(object sender, EventArgs e)
        {


            {

                List<string> caja2;
                f1.abre();
                f2.trunca();
                f2.abre();
                cajas.Clear();
                caja2 = new List<string>();
                int gol1, gol2;
                double medg;

                for (int i = 0; i < f1.numRegistros; i++)
                {
                    caja2.Clear();
                    try
                    {
                        cajas = f1.lee();
                        gol1 = Convert.ToInt32(cajas[2]);
                        gol2 = Convert.ToInt32(cajas[3]);
                        medg = (gol1 + gol2)/2;
                        caja2.Add(cajas[0]);
                        caja2.Add(cajas[1]);
                        caja2.Add(cajas[2]);
                        caja2.Add(cajas[3]);
                        caja2.Add(medg.ToString());
                        try
                        {
                            f2.escribe(caja2);
                        }
                        catch (Exception e1)
                        {
                            MessageBox.Show(e1.Message + "\n" + e1.Source);
                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show(e1.Message);
                    }
                }
                f1.cierra();
                f2.cierra();
                
            }
        }
        private void cargamedias_Click(object sender, EventArgs e)
        {
            int i = 0;
            List<string> caja3;
            caja3 = new List<string>();
            try
            {

                f2.abre();
                dataGridView1.Rows.Clear();
                for (i = 0; i < f2.numRegistros; i++)
                {
                    caja3.Clear();
                    try
                    {
                        caja3 = f2.lee();
                        dataGridView1.Rows.Add(caja3[0], caja3[1], caja3[2],caja3[3],caja3[4]);
                        dataGridView1.Sort(dataGridView1.Columns[4],ListSortDirection.Descending);
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show(e1.Message);
                    }
                }
                f2.cierra();

            }
            catch (System.SystemException)
            {
                throw new System.SystemException("El archivo no ha sido creado");
            }

            f2.cierra();
        }

        void carga(List<string> cajas)
        {
            cajas.Clear();
            cajas.Add(textBox1.Text);
            cajas.Add(textBox2.Text);
            cajas.Add(textBox3.Text);
            cajas.Add(textBox4.Text);
        }

        public void botonesdeshabilitados()
        {
            try
            {


                foreach (Control c in Controls)
                {
                    Button b = (Button)
                        c;
                    b.Enabled = false;
                }
            }

            catch
            {
            }

        }
    }

}