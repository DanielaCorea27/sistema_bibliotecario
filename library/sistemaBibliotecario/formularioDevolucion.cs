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
    public partial class frmFormularioDevolucion : Form
    {
        public frmFormularioDevolucion()
        {
            InitializeComponent();
            lbNoEncontrar.Text = "";
        }
        //-----------------------------Crear conexion a base de datos bibliotecaBDFinal--------------------------------------------------
        static string conexionstring = "Data Source = DESKTOP-NFDMETJ; Initial Catalog = bibliotecaBDFinal; Integrated Security = True";
        SqlConnection miconexion = new SqlConnection(conexionstring);
        //-------------------------------------------------------------------------------------------------------------------------

        private void frmFormularioDevolucion_Load(object sender, EventArgs e)
        {
            //Mostrar tabla de Libros Devueltos
            MostrarLibrosDevueltos(dgvMostrarLibrosDevueltos);
            txtEstado.Text = "DEVUELTO";
        }
        //------------Seleccionar datos de tabla de Prestamo----------------------
        public void MostrarLibrosDevueltos(DataGridView dg)
        {
            string miqueryLibro = "select * from Prestamo";
            SqlCommand micomando = new SqlCommand(miqueryLibro, miconexion);
            SqlDataAdapter todomiData = new SqlDataAdapter(micomando);
            DataTable miTablaOrdenada = new DataTable();
            todomiData.Fill(miTablaOrdenada);
            dgvMostrarLibrosDevueltos.DataSource = miTablaOrdenada;
        }
        //-------------Refrescar------------------------------------------
        public void limpiarTodo()
        {
            txtBusqueda.Text = "";
            txtId.Text = "";
            // txtNombreEstudianteL.Text = "";
            txtCarnetL.Text = "";
            // txtIsbnL.Text = "";
            dtpDevolucion.Text = "";
            txtObservacion.Text = "";
            //  txtNombreEstudiante.Text = "";
            txtCarnet.Text = "";
            //  txtIsbn.Text = "";
            lbNoEncontrar.Text = "";
            MostrarLibrosDevueltos(dgvMostrarLibrosDevueltos);
        }
        //Funcion para editar el estado del libro prestado
        public void editarEstado()
        {
            miconexion.Open();

            string consulta = " update Prestamo set Estado='" + txtEstado.Text + "'where IdPrestamo = '" + txtId.Text + "'";
            SqlCommand comando = new SqlCommand(consulta, miconexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant > 0)
            {
                MessageBox.Show("Registro modificado");
            }

            miconexion.Close();
        }
            //Al seleccionar una celda se llenaran los datos datos en los textbox del formulario
            private void dgvMostrarLibrosDevueltos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvMostrarLibrosDevueltos.SelectedCells[0].Value.ToString();
            //txtNombreEstudiante.Text = dgvMostrarLibrosDevueltos.SelectedCells[1].Value.ToString();
            txtCarnet.Text = dgvMostrarLibrosDevueltos.SelectedCells[3].Value.ToString();
            //txtIsbn.Text = dgvMostrarLibrosDevueltos.SelectedCells[3].Value.ToString();

            //  txtNumeroPrestamoL.Text = dgvMostrarLibrosDevueltos.SelectedCells[0].Value.ToString();
            //txtNombreEstudianteL.Text = dgvMostrarLibrosDevueltos.SelectedCells[1].Value.ToString();
            //txtIsbnL.Text = dgvMostrarLibrosDevueltos.SelectedCells[2].Value.ToString();
            txtCarnetL.Text = dgvMostrarLibrosDevueltos.SelectedCells[2].Value.ToString();
        }
        //----------------Aceptar solo números------------------------------------------
        private void txtCarnetL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
             //   MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
               // MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
        //-------------NO EDITAR--------------------------------------------------------
        private void txtEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        //-----------------BOTONES DE BUSCAR - AGREGAR - CANCELAR----------------------------
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBusqueda.Text != "")
            {
                try
                {
                    string miqueryBuscar = "select * from Prestamo where IdUsuario = '" + txtBusqueda.Text + "'";
                    SqlCommand micomando = new SqlCommand(miqueryBuscar, miconexion);
                    SqlDataAdapter todomiData = new SqlDataAdapter(micomando);
                    DataTable miTablaOrdenada = new DataTable();
                    todomiData.Fill(miTablaOrdenada);
                    dgvMostrarLibrosDevueltos.DataSource = miTablaOrdenada;

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
                    MessageBox.Show("Por Favor, Ingrese un ID", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("INGRESE UN DATO A BUSCAR", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCarnetL.Text != "")
            {
                editarEstado();
                try
                {
                    miconexion.Open();
                    string consulta = "INSERT INTO Devolucion (Observaciones, IdLibro, IdUsuario, FechaDevolucion) VALUES ('" + txtObservacion.Text + "', '" + txtCarnetL.Text + "', '" + txtCarnet.Text + "', '" + dtpDevolucion.Value.ToString("yyyy-MM-dd") + "')";
                    //string consulta = "insert into Devolucion(Observaciones,IdLibro,IdUsuario ,FechaDevolucion ) values(" + txtObservacion.Text + "','" + txtIsbnL.Text + "'," + txtCarnetL.Text + "','" + dtpDevolucion.Text + "',')";
                    SqlCommand comando = new SqlCommand(consulta, miconexion);
                    comando.ExecuteNonQuery();
                    limpiarTodo();

                    MessageBox.Show("Registro añadido exitosamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    miconexion.Close();
                }
                catch
                {

                    miconexion.Close();
                    MessageBox.Show("Ha ocurrido un error. ", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
        //BOTON DE VER HISTORIAL Y DE REGRESO
        private void btnHistorialDevoluciones_Click(object sender, EventArgs e)
        {
            frmHistorialDevoluciones ventanaHistorialDevoluciones = new frmHistorialDevoluciones();
            this.Hide();
            ventanaHistorialDevoluciones.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipalAdmin MenuAdmin = new frmMenuPrincipalAdmin();
            this.Hide();
            MenuAdmin.Show();
        }

        
    }
}
