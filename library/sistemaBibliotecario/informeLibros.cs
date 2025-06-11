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
    public partial class informeLibros : Form
    {
        public informeLibros()
        {
            InitializeComponent();
        }

        private void informeLibros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaBDFinalDataSet1.Libro' Puede moverla o quitarla según sea necesario.
            this.libroTableAdapter.Fill(this.bibliotecaBDFinalDataSet1.Libro);

            this.reportViewer1.RefreshReport();
        }
    }
}
