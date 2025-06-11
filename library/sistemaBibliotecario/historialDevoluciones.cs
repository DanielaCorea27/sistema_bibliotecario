using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaBibliotecario
{
    public partial class frmHistorialDevoluciones : Form
    {
        public frmHistorialDevoluciones()
        {
            InitializeComponent();
            lbNoEncontrar.Text = "";
        }
        //-----------------------------Crear conexion a base de datos bibliotecaBDFinal--------------------------------------------------
        static string conexionstring = "Data Source = DESKTOP-NFDMETJ; Initial Catalog = bibliotecaBDFinal; Integrated Security = True";
        SqlConnection miconexion = new SqlConnection(conexionstring);
        //-------------------------------------------------------------------------------------------------------------------------

        private void frmHistorialDevoluciones_Load(object sender, EventArgs e)
        {
            //Mostrar tabla de Devolución
            MostrarLibrosDevueltos(dgvMostrarLibrosDevueltos);
        }
        //------------Seleccionar datos de tablas----------------------
        public void MostrarLibrosDevueltos(DataGridView dg)
        {
            string miqueryLibro = "SELECT Devolucion.IdDevolucion, Devolucion.IdUsuario, Usuario.NombreUsuario, Devolucion.IdLibro, Libro.Titulo, Devolucion.Observaciones, Devolucion.FechaDevolucion FROM Usuario JOIN Devolucion ON Usuario.IdUsuario = Devolucion.IdUsuario JOIN Libro ON Devolucion.IdLibro = Libro.IdLibro ORDER BY Devolucion.IdDevolucion ";
            SqlCommand micomando = new SqlCommand(miqueryLibro, miconexion);
            SqlDataAdapter todomiData = new SqlDataAdapter(micomando);
            DataTable miTablaOrdenada = new DataTable();
            todomiData.Fill(miTablaOrdenada);
            dgvMostrarLibrosDevueltos.DataSource = miTablaOrdenada;
        }
        //Aceptar solo números
        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
           //     MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
        //---------------------BOTONES DE BUSCAR Y LIMPIAR-------------------------
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBusqueda.Text != "")
            {
                try
                {
                    string miqueryBuscar = "SELECT Devolucion.IdDevolucion, Devolucion.IdUsuario, Usuario.NombreUsuario, Devolucion.IdLibro, Libro.Titulo, Devolucion.Observaciones, Devolucion.FechaDevolucion FROM Usuario JOIN Devolucion ON Usuario.IdUsuario = Devolucion.IdUsuario JOIN Libro ON Devolucion.IdLibro = Libro.IdLibro WHERE Usuario.IdUsuario = '" + txtBusqueda.Text + "' ORDER BY Devolucion.IdDevolucion ";
                    SqlCommand micomando = new SqlCommand(miqueryBuscar, miconexion);
                    SqlDataAdapter todomiData = new SqlDataAdapter(micomando);
                    DataTable miTablaOrdenada = new DataTable();
                    todomiData.Fill(miTablaOrdenada);
                    dgvMostrarLibrosDevueltos.DataSource = miTablaOrdenada;

                    if (miTablaOrdenada.Rows.Count == 0)
                    {
                        lbNoEncontrar.Text = "¡No se encontraron resultados para la busqueda realizada!";
                    }
                    else if (miTablaOrdenada.Rows.Count > 0)
                    {
                        lbNoEncontrar.Text = "";
                    }
                }
                catch
                {
                    MessageBox.Show("Por Favor, Ingrese un ID", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("INGRESE UN DATO A BUSCAR", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            lbNoEncontrar.Text = "";
            MostrarLibrosDevueltos(dgvMostrarLibrosDevueltos);
        }
        // BOTON  DE REGRESO
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipalAdmin MenuAdmin = new frmMenuPrincipalAdmin();
            this.Hide();
            MenuAdmin.Show();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            informeDevoluciones informeDev = new informeDevoluciones();
            //this.Hide();
            informeDev.Show();
        }
    }
}
