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
    public partial class frmHistorialReservacionesLibros : Form
    {
        public frmHistorialReservacionesLibros()
        {
            InitializeComponent();
            lbNoEncontrar.Text = "";
        }
        //-----------------------------Crear conexion a base de datos bibliotecaBDFinal--------------------------------------------------
        static string conexionstring = "Data Source = DESKTOP-NFDMETJ; Initial Catalog = bibliotecaBDFinal; Integrated Security = True";
        SqlConnection miconexion = new SqlConnection(conexionstring);
        //-------------------------------------------------------------------------------------------------------------------------
        private void frmHistorialReservacionesLibros_Load(object sender, EventArgs e)
        {
            //Mostrar tablas
            MostrarLibrosDevueltos(dgvMostrarPeticionesLibros);
        }
        //------------Seleccionar datos de tablas----------------------
        public void MostrarLibrosDevueltos(DataGridView dg)
        {
            /*SqlCommand cmd = new SqlCommand("select nombreLibro,isbn,edicion, estado, nombreEstudiante, carnet, salida, entrega from historialPrestamoLibros", miconexion);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dg.DataSource = dt;*/
            string miqueryLibro = "SELECT R.IdReservacion,  R.IdUsuario,  U.NombreUsuario,  R.IdLibro, L.Titulo,  R.Observaciones,  R.FechaDevolucion FROM    Reservacion R JOIN  Usuario U ON R.IdUsuario = U.IdUsuario JOIN Libro L ON R.IdLibro = L.IdLibro;";
            SqlCommand micomando = new SqlCommand(miqueryLibro, miconexion);
            SqlDataAdapter todomiData = new SqlDataAdapter(micomando);
            DataTable miTablaOrdenada = new DataTable();
            todomiData.Fill(miTablaOrdenada);
            dgvMostrarPeticionesLibros.DataSource = miTablaOrdenada;
        }
        //Aceptar solo números
        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

              //  MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    string miqueryBuscar = "SELECT  R.IdReservacion,  R.IdUsuario,  U.NombreUsuario,  R.IdLibro,  L.Titulo,  R.Observaciones,  R.FechaDevolucion FROM Reservacion R  JOIN  Usuario U ON R.IdUsuario = U.IdUsuario  JOIN  Libro L ON R.IdLibro = L.IdLibro WHERE R.IdUsuario  = '" + txtBusqueda.Text + "'";
                    SqlCommand micomando = new SqlCommand(miqueryBuscar, miconexion);
                    SqlDataAdapter todomiData = new SqlDataAdapter(micomando);
                    DataTable miTablaOrdenada = new DataTable();
                    todomiData.Fill(miTablaOrdenada);
                    dgvMostrarPeticionesLibros.DataSource = miTablaOrdenada;


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
                    MessageBox.Show("Por favor, ingrese un id de usuario. ", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MostrarLibrosDevueltos(dgvMostrarPeticionesLibros);
        }
        //BOTON DE REGRESO
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipalAdmin MenuAdmin = new frmMenuPrincipalAdmin();
            this.Hide();
            MenuAdmin.Show();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            informeReservaciones InformeReservacion = new informeReservaciones();
            //this.Hide();
            InformeReservacion.Show();
        }
    }
}
