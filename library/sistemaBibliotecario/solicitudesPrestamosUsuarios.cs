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
    public partial class frmSolicitudesPrestamosUsuarios : Form
    {
        public frmSolicitudesPrestamosUsuarios()
        {
            InitializeComponent();
            lbNoEncontrar.Text = "";
        }
        //-----------------------------Crear conexion a base de datos bibliotecaBDFinal--------------------------------------------------
        static string conexionstring = "Data Source = DESKTOP-NFDMETJ; Initial Catalog = bibliotecaBDFinal; Integrated Security = True";
        SqlConnection miconexion = new SqlConnection(conexionstring);
        //-------------------------------------------------------------------------------------------------------------------------

        private void frmSolicitudesPrestamosUsuarios_Load(object sender, EventArgs e)
        {
            //Mostrar tabla de Libro
            MostrarLibros(dgvMostrarLibros);
        }
        //Seleccionar datos de tabla Libro
        public void MostrarLibros(DataGridView dg)
        {
            SqlCommand cmd = new SqlCommand("select Titulo, IdLibro from Libro where Estado = 'Disponible'", miconexion);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dgvMostrarLibros.DataSource = dt;
        }
        //Limpiar datos
        public void limpiarTodo()
        {
            txtBusqueda.Text = "";
        //    txtNombreEstudiante.Text = "";
          //  txtCarnet.Text = "";
            txtIdLibro.Text = "";
            txtNombreLibro.Text = "";
            dtpPedido.Value = DateTime.Now;
            txtObservacion.Text = "";
            MostrarLibros(dgvMostrarLibros);
        }
        //Seleccionar datos para cargar en textbox
        private void dgvMostrarLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombreLibro.Text = dgvMostrarLibros.Rows[dgvMostrarLibros.CurrentRow.Index].Cells[0].Value.ToString();
            txtIdLibro.Text = dgvMostrarLibros.Rows[dgvMostrarLibros.CurrentRow.Index].Cells[1].Value.ToString();


            /*if (e.RowIndex >= 0 && e.RowIndex < dgvMostrarLibros.Rows.Count)
               {
                   txtNombreLibro.Text = dgvMostrarLibros.Rows[e.RowIndex].Cells[0].Value.ToString();
                   txtIdLibro.Text = dgvMostrarLibros.Rows[e.RowIndex].Cells[1].Value.ToString();
               }*/
        }
        //Aceptar solo números
        private void txtCarnet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
        //-----------------------------------------BOTONES DE BUSCAR - ENVIAR - CANCELAR - REFRESCAR - SALIR---------------------------------
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBusqueda.Text != "")
            {
                miconexion.Open();
                string miqueryBuscar = "select Titulo, IdLibro from Libro where Titulo Like '%" + txtBusqueda.Text + "%' and Estado = 'Disponible'";
                SqlCommand micomando = new SqlCommand(miqueryBuscar, miconexion);
                SqlDataAdapter todomiData = new SqlDataAdapter(micomando);
                DataTable miTablaOrdenada = new DataTable();
                todomiData.Fill(miTablaOrdenada);
                dgvMostrarLibros.DataSource = miTablaOrdenada;

                if (miTablaOrdenada.Rows.Count == 0)
                {
                    lbNoEncontrar.Text = "¡No se encontraron resultados!";
                }
                else if (miTablaOrdenada.Rows.Count > 0)
                {
                    lbNoEncontrar.Text = "";
                }

                miconexion.Close();
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                miconexion.Open();
                string consulta = "INSERT INTO Reservacion (Observaciones, IdUsuario, IdLibro, FechaDevolucion) VALUES ('" + txtObservacion.Text + "', '" + txtCarnet.Text + "', '" + txtIdLibro.Text + "', '" + dtpPedido.Value.ToString("yyyy-MM-dd") + "')";
                //string consulta = "insert into Reservacion (Observaciones,IdUsuario,IdLibro ,FechaDevolucion )values('" + txtObservacion.Text + "','" + txtCarnet.Text + "','" + txtIdLibro.Text + "','" + txtNombreLibro.Text + "','" + dtpPedido.Value + "')";
                SqlCommand comando = new SqlCommand(consulta, miconexion);
                comando.ExecuteNonQuery();

                MessageBox.Show("Registro enviado exitosamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error. ", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiarTodo();
            lbNoEncontrar.Text = "";
            txtBusqueda.Text = "";
            miconexion.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarTodo();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            limpiarTodo();
            lbNoEncontrar.Text = "";
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipalUsuario MenuUsuario = new frmMenuPrincipalUsuario();
            this.Hide();
            MenuUsuario.Show();
        }
    }
}
