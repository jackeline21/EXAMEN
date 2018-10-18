using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Examen_1P
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnAceptar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server = localhost; Database=AdventureWorks2014; User Id=Jacki; 
                                    Password=12345;");
            //Crear el query de sql server
            string ins = "exec sp_ver_producto @id , @nombre , @mail , @rate , @comments";

            //Crear el comando
            SqlCommand cmd = new SqlCommand(ins, conn);

            try
            {
                //abrir la coneccion
                conn.Open();
                //llenar el comando con los parametros
                using (cmd)
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int)
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNombre.Text;
                    cmd.Parameters.Add("@mail", SqlDbType.VarChar).Value = txtCorreo.Text;
                    cmd.Parameters.Add("@rate", SqlDbType.Int);
                    cmd.Parameters.Add("@comments", SqlDbType.VarChar);
                }
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Detalles de excepcion!");
            }
            finally
            {
                conn.Close();
            }
        }

        private void dGVProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cerrar la conexion
            conn.Close();
        }
    }
}
