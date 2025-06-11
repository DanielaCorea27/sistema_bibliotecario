using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaBibliotecario
{
    public partial class informeDevoluciones : Form
    {
        public informeDevoluciones()
        {
            InitializeComponent();
        }

        private void informeDevoluciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaBDFinalDataSet1.Devolucion' Puede moverla o quitarla según sea necesario.
            this.devolucionTableAdapter.Fill(this.bibliotecaBDFinalDataSet1.Devolucion);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
