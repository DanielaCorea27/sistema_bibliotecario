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
    public partial class frmMenuPrincipalUsuario : Form
    {
        private bool formularioCargado = false;
        public frmMenuPrincipalUsuario()
        {
            InitializeComponent();
            lbNoEncontrar.Text = "";
        }
        //-----------------------------Crear conexion a base de datos bibliotecaS--------------------------------------------------
        static string conexionstring = "Data Source = DESKTOP-NFDMETJ; Initial Catalog = bibliotecaBDFinal; Integrated Security = True";
        SqlConnection miconexion = new SqlConnection(conexionstring);
        //-------------------------------------------------------------------------------------------------------------------------
        private void frmMenuPrincipalUsuario_Load(object sender, EventArgs e)
        {
            //Mostrar ComboBox Genero, filtar tabla por Genero, mostrar tabla libro, cargar formularios
            combo1();
            display_datagrid();
            MostrarLibros(dgvMostrarLibros);
            formularioCargado = true;
        }
        //------------Seleccionar datos de tabla Libro----------------------
        public void MostrarLibros(DataGridView dg)
        {
            string miqueryLibro = "select * from Libro where Estado = 'Disponible'";
            SqlCommand micomando = new SqlCommand(miqueryLibro, miconexion);
            SqlDataAdapter todomiData = new SqlDataAdapter(micomando);
            DataTable miTablaOrdenada = new DataTable();
            todomiData.Fill(miTablaOrdenada);
            dgvMostrarLibros.DataSource = miTablaOrdenada;
        }
        //--------REFRESCAR DATOS----------------------
        private void limpiador()
        {
            txtInfoNombre.Text = "";
            txtInfoAutor.Text = "";
            txtInfoIsbn.Text = "";
            txtInfoSaga.Text = "";
            txtInfoEjemplares.Text = "";
            txtInfoDisponibles.Text = "";
            txtInfoGenero.Text = "";

            cbGeneroLibro.Text = "";
            txtBusqueda.Text = "";
            MostrarLibros(dgvMostrarLibros);
        }
        //-----------Filtrar datos por ComboBoxGenero-----------
        private void combo1()
        {
            string query1 = "Select distinct Genero from Libro";

            SqlDataAdapter da = new SqlDataAdapter(query1, miconexion);
            miconexion.Open();
            DataSet dt = new DataSet();
            da.Fill(dt, "Genero");
            cbGeneroLibro.DisplayMember = "Genero";
            cbGeneroLibro.ValueMember = "Genero";
            cbGeneroLibro.DataSource = dt.Tables["Genero"];
            miconexion.Close();

            if (cbGeneroLibro.Items.Count > 0)
            {
                cbGeneroLibro.Text = "";
            }
        }

        private void display_datagrid()
        {
            //SqlCommand quer2 = new SqlCommand("SELECT IdLibro, Titulo, Autor, Isbn, Saga, Ejemplares, Disponibles, Genero FROM Libro WHERE Genero LIKE '%" + cbGeneroLibro.Text + "%'", miconexion);
            //SqlDataAdapter da = new SqlDataAdapter();
            ///DataTable dt = new DataTable();
            //da.SelectCommand = quer2;
            //dt.Clear();
            //da.Fill(dt);
            //dgvMostrarLibros.DataSource = dt;

            SqlCommand quer2 = new SqlCommand("SELECT IdLibro, Titulo, Autor, Isbn, Saga, Ejemplares, Disponibles, Genero FROM Libro WHERE Genero LIKE '%" + cbGeneroLibro.Text + "%'", miconexion);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = quer2;
            dt.Clear();
            da.Fill(dt);
            dgvMostrarLibros.DataSource = dt;

            /* SqlCommand quer2 = new SqlCommand("SELECT IdLibro, Titulo, Autor, Isbn, Saga, Ejemplares, Disponibles, Genero FROM Libro WHERE Genero LIKE '%'" + cbGeneroLibro.Text + "'", miconexion);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = quer2;
            dt.Clear();
            da.Fill(dt);
            dgvMostrarLibros.DataSource = dt;*/
        }
        //---------------------TERMINA FILTRADO--------------
        //--------------------TABLA FILTRAR-------------------
        private void tablaFiltrar()
        {
            if (txtBusqueda.Text != "" || cbGeneroLibro.Text != "")
            {
                DataTable dt = new DataTable();
                miconexion.Open();
                string consulta = "select * from Libro";
                if (rbAutor.Checked && txtBusqueda.Text != "")
                {
                    consulta += " where Autor COLLATE Latin1_General_CI_AI like '%" + txtBusqueda.Text + "%' and Estado = 'Disponible'";
                }
                else if (rbNombre.Checked && txtBusqueda.Text != "")
                {
                    consulta += " where Titulo COLLATE Latin1_General_CI_AI like '%" + txtBusqueda.Text + "%' and Estado = 'Disponible'";
                }
                if (cbGeneroLibro.Text != "")
                {
                    if (txtBusqueda.Text != "")
                    {
                        consulta += " and ";
                    }
                    else
                    {
                        consulta += " where ";
                    }
                    consulta += "Genero = '" + cbGeneroLibro.Text + "' and Estado = 'Disponible'";
                }
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, miconexion);
                adaptador.Fill(dt);
                dgvMostrarLibros.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    lbNoEncontrar.Text = "¡No se encontraron resultados para esta busqueda!";
                }
                else if (dt.Rows.Count > 0)
                {
                    lbNoEncontrar.Text = "";
                }
                miconexion.Close();
            }
            else
            {
                MostrarLibros(dgvMostrarLibros);
                lbNoEncontrar.Text = "";
            }
        }
        //-------------TERMINA TABLA FILTRAR------------------------
        //------------NO EDITAR COMBO BOX GENERO------------------
        private void cbGeneroLibro_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        //Desplegar ComboBox Genero
        private void cbGeneroLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.formularioCargado)
            {
                tablaFiltrar();
            }
        }
        //Seleccionar datos de la tabla Libro para mostrar en TextBox
        private void dgvMostrarLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtInfoNombre.Text = dgvMostrarLibros.SelectedCells[1].Value.ToString();
            txtInfoAutor.Text = dgvMostrarLibros.SelectedCells[2].Value.ToString();
            txtInfoIsbn.Text = dgvMostrarLibros.SelectedCells[3].Value.ToString();
            txtInfoSaga.Text = dgvMostrarLibros.SelectedCells[4].Value.ToString();
            txtInfoEjemplares.Text = dgvMostrarLibros.SelectedCells[5].Value.ToString();
            txtInfoDisponibles.Text = dgvMostrarLibros.SelectedCells[6].Value.ToString();
            txtInfoGenero.Text = dgvMostrarLibros.SelectedCells[7].Value.ToString();
        }
        //Filtar TextBox Busqueda y por radios de Titulo y Autor
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            tablaFiltrar();
        }

        private void rbNombre_CheckedChanged(object sender, EventArgs e)
        {
            tablaFiltrar();
        }

        private void rbAutor_CheckedChanged(object sender, EventArgs e)
        {
            tablaFiltrar();
        }
        //------------------BOTONES DE RESERVAR - REFRESCAR - SALIR------------------------
        private void btnReservarLibro_Click(object sender, EventArgs e)
        {
            frmSolicitudesPrestamosUsuarios PedirLibro = new frmSolicitudesPrestamosUsuarios();
            this.Hide();
            PedirLibro.Show();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Seguro que quiere refrescar?";
            string titulo = "ADVERTENCIA";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                limpiador();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Seguro que quiere salir?";
            string titulo = "ADVERTENCIA";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Hide();
                new frmLoginPrincipal().Show();
            }
        }
    }
}
