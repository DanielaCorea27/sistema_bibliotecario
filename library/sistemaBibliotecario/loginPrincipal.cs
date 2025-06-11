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
    public partial class frmLoginPrincipal : Form
    {
        public frmLoginPrincipal()
        {
            InitializeComponent();
        }
        //Coneccion a nuestro servidor sql
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-NFDMETJ; Initial Catalog = bibliotecaBDFINAL; Integrated Security = True");
        public void logger(string Carnet, string Contrasena)
        {
            try
            {
                con.Open();
                //Consulta SQl
                SqlCommand cmd = new SqlCommand("select NombreUsuario,Tipo from Usuario where IdUsuario=@IdUsuario and PassworUsuario =@PassworUsuario", con);
                //Llamamos los parametros 
                cmd.Parameters.AddWithValue("@IdUsuario", Carnet);
                cmd.Parameters.AddWithValue("@PassworUsuario", Contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                //evaluamos si escontramos datos  que coninsidan cn los criterios 
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    //Evaluamos que tipo thes  
                    if (dt.Rows[0][1].ToString() == "Admin")
                    {
                        new frmMenuPrincipalAdmin().Show();
                    }
                    else if ((dt.Rows[0][1].ToString() == "Lector"))
                    {
                        new frmMenuPrincipalUsuario().Show();
                    }
                }
                else
                {
                    MessageBox.Show("Carnet o contraseña incorrectos! ", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Carnet invalido! ", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
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

        private void btnAccederAdmin_Click(object sender, EventArgs e)
        {
            //llamamos el metodo logger
            logger(this.txtCarnet.Text, this.txtPassword.Text);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
