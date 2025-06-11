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
    public partial class frmMenuPrincipalAdmin : Form
    {
        private bool formularioCargado = false;
        public frmMenuPrincipalAdmin()
        {
            InitializeComponent();
            lbNoEncontrar.Text = "";
        }
        //-----------------------------Crear conexion a base de datos bibliotecaBDFinal--------------------------------------------------
        static string conexionstring = "Data Source = DESKTOP-NFDMETJ; Initial Catalog = bibliotecaBDFinal; Integrated Security = True";
        SqlConnection miconexion = new SqlConnection(conexionstring);
        //-------------------------------------------------------------------------------------------------------------------------
        private void frmMenuPrincipalAdmin_Load(object sender, EventArgs e)
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
            string miqueryLibro = "select * from Libro";
            SqlCommand micomando = new SqlCommand(miqueryLibro, miconexion);
            SqlDataAdapter todomiData = new SqlDataAdapter(micomando);
            DataTable miTablaOrdenada = new DataTable();
            todomiData.Fill(miTablaOrdenada);
            dgvMostrarLibros.DataSource = miTablaOrdenada;
        }
        //--------REFRESCAR DATOS----------------------
        private void limpiador()
        {
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
            SqlCommand quer2 = new SqlCommand("SELECT * FROM Libro WHERE Genero LIKE '%" + cbGeneroLibro.Text + "'", miconexion);
            SqlDataAdapter da2 = new SqlDataAdapter();
            DataTable dt2 = new DataTable();
            da2.SelectCommand = quer2;
            dt2.Clear();
            da2.Fill(dt2);
            dgvMostrarLibros.DataSource = dt2;
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
                    consulta += " where Autor COLLATE Latin1_General_CI_AI like '%" + txtBusqueda.Text + "%'";
                }
                else if (rbNombre.Checked && txtBusqueda.Text != "")
                {
                    consulta += " where Titulo COLLATE Latin1_General_CI_AI like '%" + txtBusqueda.Text + "%' ";
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
                    consulta += "Genero = '" + cbGeneroLibro.Text + "'";
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
        //Filtrar datos en tabla
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            tablaFiltrar();
        }
        //------------ENLACES A LAS OPCIONES DEL MENU----------------
        private void menuUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdministrarUsuarios AdminUsuarios = new frmAdministrarUsuarios();
            this.Hide();
            AdminUsuarios.Show();
        }

        private void menuLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdministrarLibros AdminLibros = new frmAdministrarLibros();
            this.Hide();
            AdminLibros.Show();
        }
        private void menuFormulariosPrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFormularioPrestamos FrmPrestamos = new frmFormularioPrestamos();
            this.Hide();
            FrmPrestamos.Show();
        }

        private void menuFormulariosDevolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFormularioDevolucion FrmDevoluciones = new frmFormularioDevolucion();
            this.Hide();
            FrmDevoluciones.Show();
        }

        private void menuHistorialSolicitudesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHistorialReservacionesLibros HistorialReservaciones = new frmHistorialReservacionesLibros();
            this.Hide();
            HistorialReservaciones.Show();
        }

        private void menuHistorialPrestamosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHistorialPrestamos HistorialPrestamos = new frmHistorialPrestamos();
            this.Hide();
            HistorialPrestamos.Show();
        }

        private void menuHistorialDevolucionesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmHistorialDevoluciones HistorialDevoluciones = new frmHistorialDevoluciones();
            this.Hide();
            HistorialDevoluciones.Show();
        }
        //-------------------BOTONES REFRESCAR Y SALIR----------
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
