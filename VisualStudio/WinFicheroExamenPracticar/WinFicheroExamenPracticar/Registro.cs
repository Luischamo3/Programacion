using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.Data;
using System.IO;
using System.Windows.Forms;

namespace WinFicheroExamenPracticar
{
    enum tipo
    {
        cadena = 1,
        entero = 2,
        doble = 3,
    }
    class Registro
    {
         List<string> campos;
        List<tipo> tipos;
        int numCampos;

        public Registro(List<string> lista1,List<tipo>lista2  )
        {
            int i = 0;
            campos  = new List<string>();
            tipos = new List<tipo>();
            for (i = 0;i  < lista1.Count; i ++)
            {
                campos.InsertRange(0, lista1);
                tipos.InsertRange(0, lista2);

            }
            numCampos = lista1.Count;
        }

        public void escribe(List<string> listavalores, BinaryWriter bw  )
        {
            int entero = 0;
            double doble = 0;

            try
            {
                for (int i = 0; i < listavalores.Count; i++)
                {
                    switch (tipos[i])
                    {
                            case  tipo.cadena:
                            bw.Write(listavalores[i].ToString());
                            break;

                            case tipo.entero:
                            Int32.TryParse(listavalores[i], out  entero)
                            ;
                            bw.Write(entero);
                            break;

                            case tipo.doble:
                            double.TryParse(listavalores[i],out doble)
                            ;
                            bw.Write(doble);
                            break;


                            default:
                            throw new Exception("Tipo de dato no permitido");


                    }

                }
            }

            
            catch (Exception e1)
            {
                
                throw new Exception(e1.Message+ "\n" + e1.Source); 
            }
        }

        public List<string> lee(BinaryReader br)
        {
            List<string> devol;
            devol = new List<string>();

            try
            {
                for (int i = 0; i < numCampos;
                i++)
                {
                    switch (tipos[i])
                    {
                        case tipo.cadena:
                            devol.Add(br.ReadString());
                            break;

                        case tipo.entero:
                            devol.Add(br.ReadInt32().ToString())
                                ;
                            break;
                        case tipo.doble:
                            devol.Add(br.ReadDouble().ToString());
                            break;

                        default:
                            throw new Exception("Tipo de dato no permitido");


                    }
                }
                return devol;
            }
           

            catch (Exception e1)
            {

                throw new Exception(e1.Message + "\n" + e1.Source);
            }

        }
    }
    
}
