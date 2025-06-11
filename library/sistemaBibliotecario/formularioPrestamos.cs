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
    public partial class frmFormularioPrestamos : Form
    {
        public frmFormularioPrestamos()
        {
            InitializeComponent();
            lbNoEncontrar.Text = "";
        }
        //-----------------------------Crear conexion a base de datos bibliotecaBDFinal--------------------------------------------------
        static string conexionstring = "Data Source = DESKTOP-NFDMETJ; Initial Catalog = bibliotecaBDFinal; Integrated Security = True";
        SqlConnection miconexion = new SqlConnection(conexionstring);
        //-------------------------------------------------------------------------------------------------------------------------

        private void frmFormularioPrestamos_Load(object sender, EventArgs e)
        {
            //Mostrar tabla de Solicitudes
            MostrarSolicitudes(dgvMostrarSolicitudes);
        }
        //------------Seleccionar datos de tabla Reservacion----------------------
        public void MostrarSolicitudes(DataGridView dg)
        {
            /*SqlCommand cmd = new SqlCommand("select nombreLibro,isbn,edicion, estado, nombreEstudiante, carnet, salida, entrega from historialPrestamoLibros", miconexion);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dg.DataSource = dt;*/
            miconexion.Open();
            string miqueryLibro = "select * from Reservacion";
            SqlCommand micomando = new SqlCommand(miqueryLibro, miconexion);
            SqlDataAdapter todomiData = new SqlDataAdapter(micomando);
            DataTable miTablaOrdenada = new DataTable();
            todomiData.Fill(miTablaOrdenada);
            dgvMostrarSolicitudes.DataSource = miTablaOrdenada;
            miconexion.Close();
        }
        //-------------Refrescar------------------------------------------
        public void limpiarTodo()
        {
            txtBusqueda.Text = "";
            txtId.Text = "";
            txtCarnet.Text = "";
            dtpSalida.Text = "";
            dtpEntrega.Text = "";
            lbNoEncontrar.Text = "";
            MostrarSolicitudes(dgvMostrarSolicitudes);
        }
        //Al seleccionar una celda se llenaran los datos datos en los textbox del formulario
        private void dgvMostrarSolicitudes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvMostrarSolicitudes.SelectedCells[3].Value.ToString();
            txtCarnet.Text = dgvMostrarSolicitudes.SelectedCells[2].Value.ToString();
            //txtNombreLibro.Text = dgvMostrarSolicitudes.SelectedCells[2].Value.ToString();
            //txtIsbn.Text = dgvMostrarSolicitudes.SelectedCells[3].Value.ToString();
        }
        //Permitir solo números como busqueda de carnet
        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
               // MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
        //--------------------BOTONES DE BUSCAR - GUARDAR - CANCELAR ------------------------------------
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBusqueda.Text != "")
            {
                try
                {
                    string miqueryBuscar = "select * from Reservacion where IdReservacion = '" + txtBusqueda.Text + "'";
                    SqlCommand micomando = new SqlCommand(miqueryBuscar, miconexion);
                    SqlDataAdapter todomiData = new SqlDataAdapter(micomando);
                    DataTable miTablaOrdenada = new DataTable();
                    todomiData.Fill(miTablaOrdenada);
                    dgvMostrarSolicitudes.DataSource = miTablaOrdenada;

                    if (miTablaOrdenada.Rows.Count == 0)
                    {
                        lbNoEncontrar.Text = "¡No se encontraron resultados";
                    }
                    else if (miTablaOrdenada.Rows.Count > 0)
                    {
                        lbNoEncontrar.Text = "";
                    }
                }
                catch
                {
                    MessageBox.Show("Por Favor, Ingrese un id", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("INGRESE UN DATO A BUSCAR", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                try
                {
                    miconexion.Open();

                    string consulta = "insert into Prestamo(Estado, IdLibro, IdUsuario,  Salida, Entrega ) values('" + txtEstado.Text + "','" + txtId.Text + "','" + txtCarnet.Text + "','" + dtpSalida.Text + "','" + dtpEntrega.Text + "')";
                    SqlCommand comando = new SqlCommand(consulta, miconexion);
                    comando.ExecuteNonQuery();


                    MessageBox.Show("Registro añadido exitosamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    miconexion.Close();
                }
                catch (Exception)
                {

                    miconexion.Close();
                    MessageBox.Show("Ha ocurrido un error. ", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                limpiarTodo();
            }
            else
            {
                MessageBox.Show("INGRESE UN DATO A BUSCAR", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarTodo();
        }
        //BOTON PARA VER HISTORIAL
        private void btnHistorialPrestamos_Click(object sender, EventArgs e)
        {
            frmHistorialPrestamos ventanaHistorialPrestamos = new frmHistorialPrestamos();
            this.Hide();
            ventanaHistorialPrestamos.Show();
        }
        //BOTON PARA REGRESAR
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipalAdmin MenuAdmin = new frmMenuPrincipalAdmin();
            this.Hide();
            MenuAdmin.Show();
        }
    }
}
