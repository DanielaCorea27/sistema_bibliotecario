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
    public partial class frmHistorialPrestamos : Form
    {
        public frmHistorialPrestamos()
        {
            InitializeComponent();
            lbNoEncontrar.Text = "";
        }
        //-----------------------------Crear conexion a base de datos bibliotecaBDFinal--------------------------------------------------
        static string conexionstring = "Data Source = DESKTOP-NFDMETJ; Initial Catalog = bibliotecaBDFinal; Integrated Security = True";
        SqlConnection miconexion = new SqlConnection(conexionstring);
        //-------------------------------------------------------------------------------------------------------------------------

        private void frmHistorialPrestamos_Load(object sender, EventArgs e)
        {
            //Mostrar tablas
            MostrarLibrosPrestados(dgvMostrarLibrosPrestados);
        }
        //------------Seleccionar datos de tablas----------------------
        public void MostrarLibrosPrestados(DataGridView dg)
        {
            /*SqlCommand cmd = new SqlCommand("select nombreLibro,isbn,edicion, estado, nombreEstudiante, carnet, salida, entrega from historialPrestamoLibros", miconexion);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dg.DataSource = dt;*/
            string miqueryLibro = "SELECT Prestamo.IdPrestamo, Prestamo.IdUsuario, Usuario.NombreUsuario, Prestamo.IdLibro, Libro.Titulo, Prestamo.Estado, Prestamo.Salida, Prestamo.Entrega FROM Prestamo JOIN Usuario ON Prestamo.IdUsuario = Usuario.IdUsuario JOIN Libro ON Prestamo.IdLibro = Libro.IdLibro ORDER BY Prestamo.IdPrestamo;";
            SqlCommand micomando = new SqlCommand(miqueryLibro, miconexion);
            SqlDataAdapter todomiData = new SqlDataAdapter(micomando);
            DataTable miTablaOrdenada = new DataTable();
            todomiData.Fill(miTablaOrdenada);
            dgvMostrarLibrosPrestados.DataSource = miTablaOrdenada;
        }
        //Aceptar solo números
        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

             //   MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    string miqueryBuscar = "SELECT Prestamo.IdPrestamo, Prestamo.IdUsuario, Usuario.NombreUsuario, Prestamo.IdLibro, Libro.Titulo, Prestamo.Estado, Prestamo.Salida, Prestamo.Entrega FROM Usuario JOIN Prestamo ON Usuario.IdUsuario = Prestamo.IdUsuario JOIN Libro ON Prestamo.IdLibro = Libro.IdLibro WHERE Usuario.IdUsuario = '" + txtBusqueda.Text + "' ORDER BY Prestamo.IdPrestamo ";
                    SqlCommand micomando = new SqlCommand(miqueryBuscar, miconexion);
                    SqlDataAdapter todomiData = new SqlDataAdapter(micomando);
                    DataTable miTablaOrdenada = new DataTable();
                    todomiData.Fill(miTablaOrdenada);
                    dgvMostrarLibrosPrestados.DataSource = miTablaOrdenada;

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
            MostrarLibrosPrestados(dgvMostrarLibrosPrestados);
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
            informePrestamos InformePrestamos = new informePrestamos();
            //this.Hide();
            InformePrestamos.Show();
        }
    }
}
