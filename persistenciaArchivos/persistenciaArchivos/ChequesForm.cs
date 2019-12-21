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

namespace persistenciaArchivos
{
    public partial class ChequesForm : Form
    {
        public ChequesForm()
        {
            InitializeComponent();
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {

        }

        private void ChequesForm_Load(object sender, EventArgs e)
        {           

            string[] listaDeArchivos= Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory);
            for () {//cinvert, recorrer, ccv
            }

        }
    }
}
