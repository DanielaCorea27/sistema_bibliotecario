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
    public partial class informeReservaciones : Form
    {
        public informeReservaciones()
        {
            InitializeComponent();
        }

        private void informeReservaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaBDFinalDataSet1.Reservacion' Puede moverla o quitarla según sea necesario.
            this.reservacionTableAdapter.Fill(this.bibliotecaBDFinalDataSet1.Reservacion);

            this.reportViewer1.RefreshReport();
        }
    }
}
