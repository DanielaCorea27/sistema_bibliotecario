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
    public partial class informePrestamos : Form
    {
        public informePrestamos()
        {
            InitializeComponent();
        }

        private void informePrestamos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaBDFinalDataSet1.Prestamo' Puede moverla o quitarla según sea necesario.
            this.prestamoTableAdapter.Fill(this.bibliotecaBDFinalDataSet1.Prestamo);

            this.reportViewer1.RefreshReport();
        }
    }
}
