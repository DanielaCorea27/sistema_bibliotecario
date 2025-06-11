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
    public partial class frmAdministrarUsuarios : Form
    {
        public frmAdministrarUsuarios()
        {
            InitializeComponent();
            lbNoEncontrar.Text = "";
        }
        //-----------------------------Crear conexion a base de datos bibliotecaBDFinal--------------------------------------------------
        static string conexionstring = "Data Source = DESKTOP-NFDMETJ; Initial Catalog = bibliotecaBDFinal; Integrated Security = True";
        SqlConnection miconexion = new SqlConnection(conexionstring);
        //-------------------------------------------------------------------------------------------------------------------------

        private void frmAdministrarUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaBDFinalDataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.bibliotecaBDFinalDataSet.Usuario);
            //Mostrar tabla de Usuario
            MostrarUsuarios(dgvMostrarUsuarios);
            //Ocultar opción de contraseña
            txtContraseña.UseSystemPasswordChar = true;
        }
        //------------Seleccionar datos de tabla Usuario----------------------
        public void MostrarUsuarios(DataGridView dg)
        {
            string miqueryLibro = "select * from Usuario";
            SqlCommand micomando = new SqlCommand(miqueryLibro, miconexion);
            SqlDataAdapter todomiData = new SqlDataAdapter(micomando);
            DataTable miTablaOrdenada = new DataTable();
            todomiData.Fill(miTablaOrdenada);
            dgvMostrarUsuarios.DataSource = miTablaOrdenada;
        }
        //-------------Refrescar------------------------------------------
        public void limpiarTodo()
        {
            txtBusqueda.Text = "";
            txtTipo.Text = "";
            txtNombre.Text = "";
            txtCarnet.Text = "";
            txtContraseña.Text = "";
            txtEstado.Text = "";
            lbNoEncontrar.Text = "";
            MostrarUsuarios(dgvMostrarUsuarios);
        }
        //Al seleccionar una celda se llenaran los datos datos en los textbox del formulario
        private void dgvMostrarUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCarnet.Text = dgvMostrarUsuarios.SelectedCells[0].Value.ToString();
            txtNombre.Text = dgvMostrarUsuarios.SelectedCells[1].Value.ToString();
            txtContraseña.Text = dgvMostrarUsuarios.SelectedCells[2].Value.ToString();
            txtTipo.Text = dgvMostrarUsuarios.SelectedCells[3].Value.ToString();
            txtEstado.Text = dgvMostrarUsuarios.SelectedCells[4].Value.ToString();
        }
        //---------------------Opción de mostrar contraseña---------------------
        private void ckbMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMostrarContraseña.Checked == true)
            {
                txtContraseña.UseSystemPasswordChar = false;

            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
            }
        }
        //---------------------------Validar solo números-------------------
        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //-----------------BOTONES DE BUSCAR - AGREGAR - EDITAR - ELIMINAR  - ACTUALIZAR----------------------------
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBusqueda.Text !="")
            {
                int txtParseado = 0;
                if (int.TryParse(txtBusqueda.Text, out txtParseado))
                {
                    string miqueryBuscar = "SELECT * FROM Usuario WHERE IdUsuario = '" + txtBusqueda.Text + "'";
                    SqlCommand micomando = new SqlCommand(miqueryBuscar, miconexion);
                    SqlDataAdapter todomiData = new SqlDataAdapter(micomando);
                    DataTable miTablaOrdenada = new DataTable();
                    todomiData.Fill(miTablaOrdenada);
                    dgvMostrarUsuarios.DataSource = miTablaOrdenada;

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
                    MessageBox.Show("Por favor, ingrese un ID de usuario válido para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("INGRESE UN DATO A BUSCAR", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" || txtContraseña.Text !="" || txtTipo.Text!="" || txtEstado.Text != "")
            {
                try
                {
                    miconexion.Open();
                    string consulta = "INSERT INTO Usuario(NombreUsuario, PassworUsuario, Tipo, Estado) VALUES('" + txtNombre.Text + "','" + txtContraseña.Text + "','" + txtTipo.Text + "','" + txtEstado.Text + "')";
                    //string consulta = "insert into Usuario(NombreUsuario, PassworUsuario,Tipo,Estado ) values(" + txtNombre.Text + "','" + txtContraseña.Text + "','"+ txtTipo + "' ,'"+ txtEstado + "')";
                    SqlCommand comando = new SqlCommand(consulta, miconexion);
                    comando.ExecuteNonQuery();
                    limpiarTodo();
                    miconexion.Close();

                    MessageBox.Show("Registro añadido exitosamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {

                    miconexion.Close();
                    MessageBox.Show("Ha ocurrido un error. ", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("COMPLETE LOS DATOS DEL FORMULARIO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" || txtContraseña.Text != "" || txtTipo.Text != "" || txtEstado.Text != "")
            {
                try
                {
                    miconexion.Open();
                    string consulta = "UPDATE Usuario SET NombreUsuario = '" + txtNombre.Text + "', PassworUsuario = '" + txtContraseña.Text + "', Tipo = '" + txtTipo.Text + "', Estado = '" + txtEstado.Text + "' WHERE IdUsuario = " + txtCarnet.Text;
                    //string consulta = "UPDATE Usuario SET     NombreUsuario = '" + txtNombre.Text + "', PassworUsuario = '" + txtContraseña.Text + "', Tipo = '" + txtTipo.Text + "',Estado='"+ txtEstado.Text + "' WHERE   IdUsuario = "+ txtCarnet.Text + ""; 
                    SqlCommand comando = new SqlCommand(consulta, miconexion);
                    int cant;
                    cant = comando.ExecuteNonQuery();
                    if (cant > 0)
                    {
                        MessageBox.Show("REGISTRO MODIFICADO");
                    }

                    miconexion.Close();
                    limpiarTodo();
                }
                catch
                {
                    MessageBox.Show("ERROR AL MODIFICAR");
                }
            }
            else
            {
                MessageBox.Show("COMPLETE LOS DATOS DEL FORMULARIO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCarnet.Text))
            {
                try
                {
                    miconexion.Open();
                    string consulta = "UPDATE Usuario SET Estado = '" + "Inactivo" + "' WHERE IdUsuario = " + txtCarnet.Text;
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipalAdmin MenuAdmin = new frmMenuPrincipalAdmin();
            this.Hide();
            MenuAdmin.Show();
        }
    }
}
