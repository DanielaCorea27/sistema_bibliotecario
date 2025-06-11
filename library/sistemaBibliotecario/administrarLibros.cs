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
    public partial class frmAdministrarLibros : Form
    {
        public frmAdministrarLibros()
        {
            InitializeComponent();
            lbNoEncontrar.Text = "";
        }
        //-----------------------------Crear conexion a base de datos bibliotecaBDFinal--------------------------------------------------
        static string conexionstring = "Data Source = DESKTOP-NFDMETJ; Initial Catalog = bibliotecaBDFinal; Integrated Security = True";
        SqlConnection miconexion = new SqlConnection(conexionstring);
        //-------------------------------------------------------------------------------------------------------------------------

        private void frmAdministrarLibros_Load(object sender, EventArgs e)
        {
            //Mostrar tabla de Libro
            MostrarLibros(dgvMostrarLibros);
        }
        //------------Seleccionar datos de tabla Libro----------------------
        public void MostrarLibros(DataGridView dg)
        {
            string miqueryLibro = "select * from Libro";
            SqlCommand micomando = new SqlCommand(miqueryLibro, miconexion);
            SqlDataAdapter todomiData = new SqlDataAdapter(micomando);
            DataTable miTablaOrdenada = new DataTable();
            todomiData.Fill(miTablaOrdenada);
            dgvMostrarLibros.DataSource = miTablaOrdenada;
        }
        //-------------Refrescar------------------------------------------
        public void limpiarTodo()
        {
            txtBusqueda.Text = "";
            txtId.Text = "";
            txtNombreLibro.Text = "";
            txtAutorLibro.Text = "";
            txtIsbn.Text = "";
            txtGenero.Text = "";
            txtSaga.Text = "";
            txtEjemplares.Text = "";
            txtDisponibles.Text = "";
            txtEstado.Text = "";
            lbNoEncontrar.Text = "";
            MostrarLibros(dgvMostrarLibros);
        }
        //Al seleccionar una celda se llenaran los datos datos en los textbox del formulario
        private void dgvMostrarLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvMostrarLibros.SelectedCells[0].Value.ToString();
            txtNombreLibro.Text = dgvMostrarLibros.SelectedCells[1].Value.ToString();
            txtAutorLibro.Text = dgvMostrarLibros.SelectedCells[2].Value.ToString();
            txtIsbn.Text = dgvMostrarLibros.SelectedCells[3].Value.ToString();
            txtSaga.Text = dgvMostrarLibros.SelectedCells[4].Value.ToString();
            txtDisponibles.Text = dgvMostrarLibros.SelectedCells[5].Value.ToString();
            txtEjemplares.Text = dgvMostrarLibros.SelectedCells[6].Value.ToString();
            txtGenero.Text = dgvMostrarLibros.SelectedCells[7].Value.ToString();
            txtEstado.Text = dgvMostrarLibros.SelectedCells[8].Value.ToString();
        }
        //-----------------BOTONES DE BUSCAR - AGREGAR - EDITAR - ELIMINAR  - ACTUALIZAR----------------------------
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBusqueda.Text !="")
            {
                string miqueryBuscar = "select * from Libro where Titulo like '%" + txtBusqueda.Text + "%'";
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
            }
            else
            {
                MessageBox.Show("INGRESE UN DATO A BUSCAR", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombreLibro.Text != "")
            {
                miconexion.Open();
                string consulta = "INSERT INTO Libro VALUES('" + txtNombreLibro.Text + "','" + txtAutorLibro.Text + "','" + txtIsbn.Text + "','" + txtSaga.Text + "','" + txtEjemplares.Text + "','" + txtDisponibles.Text + "','" + txtGenero.Text + "','" + txtEstado.Text + "')";
                SqlCommand comando = new SqlCommand(consulta, miconexion);
                comando.ExecuteNonQuery();
                limpiarTodo();

                MessageBox.Show("Registro añadido exitosamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, escribe el titulo del libro. ", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            miconexion.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreLibro.Text != "")
                {
                    miconexion.Open();
                    string consulta = "UPDATE Libro SET Titulo='" + txtNombreLibro.Text + "', Autor='" + txtAutorLibro.Text + "', Isbn='" + txtIsbn.Text + "', Genero='" + txtGenero.Text + "', Saga='" + txtSaga.Text + "', Ejemplares='" + txtEjemplares.Text + "', Disponibles='" + txtDisponibles.Text + "' WHERE IdLibro =" + txtId.Text;
                    //string consulta = " update Libro set  Titulo='" + txtNombreLibro.Text + "', Autor='" + txtAutorLibro.Text + "', Isbn='" + txtIsbn.Text + "', Genero='" + txtGenero.Text + "', Saga='" + txtSaga.Text + "', Ejemplares='" + txtEjemplares.Text + "', Disponibles='" + txtDisponibles.Text + "'where IdLibro =" + txtId.Text + "";
                    SqlCommand comando = new SqlCommand(consulta, miconexion);
                    int cant;
                    cant = comando.ExecuteNonQuery();
                    if (cant > 0)
                    {
                        MessageBox.Show("Registro modificado");
                    }
                    limpiarTodo();
                }
                else
                {
                    MessageBox.Show("Por favor, escribe el titulo del libro. ", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Por favor, llene el formulario. ", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            miconexion.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                try
                {
                    miconexion.Open();
                    string consulta = "UPDATE Libro SET Estado = '" + "Inactivo" + "' WHERE IdLibro = " + txtId.Text;
                    SqlCommand comando = new SqlCommand(consulta, miconexion);
                    int cant;
                    cant = comando.ExecuteNonQuery();
                    if (cant > 0)
                    {
                        MessageBox.Show("Registro Eliminado");
                    }

                    miconexion.Close();
                    limpiarTodo();
                }
                catch
                {
                    MessageBox.Show("ERROR AL ELIMINAR DATO");
                }
            }
            else
            {
                miconexion.Close();
                MessageBox.Show("Por favor, ingrese un ID de usuario válido para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            limpiarTodo();
        }
        //--------------------Ingresar solo números en EJEMPLARES y DISPONIBLES------------------
        private void txtEjemplares_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDisponibles_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //-------------------BOTON DE REGRESO----------------------------------
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipalAdmin MenuAdmin = new frmMenuPrincipalAdmin();
            this.Hide();
            MenuAdmin.Show();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            informeLibros InformeLibros = new informeLibros();
            //this.Hide();
            InformeLibros.Show();
        }
    }
}
