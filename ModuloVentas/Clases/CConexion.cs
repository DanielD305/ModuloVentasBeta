using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloVentas.Clases
{
    public class CConexion
    {
        SqlConnection con = new SqlConnection();

        string Conexion = "Data Source=LAPTOP-27S68BUV\\SQLEXPRESS;Initial Catalog=ModuloVentas;Integrated Security=True;";

        public SqlConnection LeerCadena()
        {
            con.ConnectionString = Conexion;

            return con;
        }

        public SqlConnection ConectarBD()
        {
            try
            {
                LeerCadena();
                con.Open();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto correctamente a la BDD " + ex );
            }

            return con;
        }

        public void CerrarConeccion()
        {
            con.Close();
        }

    }
}
