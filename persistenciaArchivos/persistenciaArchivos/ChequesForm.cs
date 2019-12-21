using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNA.Cheques;

namespace persistenciaArchivos
{
    public partial class ChequesForm : Form
    {
        private readonly string userPassword = "El20Examen20Estaba20Faci20";
        public ChequesForm()
        {
            InitializeComponent();
        }

       

        private void ChequesForm_Load(object sender, EventArgs e)
        {
            CargarListaDeCheques();

        }

        private void CargarListaDeCheques()
        {
            ChequesDataGridView.Rows.Clear();
            string archivosDefectuosos = "";
            string[] listaDeArchivos = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.csv");

            for (int fileIndex = 0; fileIndex < listaDeArchivos.Length; fileIndex++)
            {

                using (StreamReader readFile = new StreamReader(listaDeArchivos[fileIndex]))
                {
                    string line;
                    string[] row;

                    while ((line = readFile.ReadLine()) != null)
                    {
                        row = line.Split(',');

                        try
                        {
                            Cheque cheque = new Cheque
                        {
                            Nombre = row[0],
                            Numero = row[1],
                            Monto = Convert.ToDouble(row[2]),
                            Descripcion = Encriptacion.DesencriptarString(row[3], userPassword),
                            Emisor = row[4],
                            Receptor = row[5],
                            Institucion = row[7],
                            Moneda = row[8],
                            Fecha = Convert.ToDateTime(row[6]),

                        };
                        ChequesDataGridView.Rows.Add(cheque.Nombre, cheque.Numero, cheque.Monto, cheque.Descripcion, cheque.Emisor, cheque.Receptor, cheque.Institucion, cheque.Moneda, cheque.Fecha);
                    }
                            catch (Exception)
                    {
                        archivosDefectuosos = archivosDefectuosos + " 	\n *  " + listaDeArchivos[fileIndex];
                        break;
                    }



                }
                }



            }
            //Todo: hacer if 
            if (archivosDefectuosos.Length!=0) { 
            MessageBox.Show("Se encotraron los siguientes errores " + archivosDefectuosos);
                   }
    }

        private void RefrescarButton_Click(object sender, EventArgs e)
        {

            CargarListaDeCheques();
        }

        private void ChequesDataGridView_DoubleClick(object sender, EventArgs e)
        {
            ChequesDataGridView.Rows.Clear();
        }

        private void Refreshtimer_Tick(object sender, EventArgs e)
        {
            CargarListaDeCheques();
        }
    }
}
