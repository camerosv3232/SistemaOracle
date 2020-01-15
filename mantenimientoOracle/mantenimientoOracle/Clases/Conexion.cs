using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mantenimientoOracle.Clases
{
    public class Conexion
    {
        SqlConnection con = new SqlConnection();


        string conOracle = "Data Source='PruebaConexion'; User Id=sys; Password=12345; ";
            //ConfigurationManager.ConnectionStrings["conOracle"].ConnectionString;

        public SqlConnection open()
        {
            try
            {
                if (variables.dbid == 1)
                {
                    con.ConnectionString = conOracle;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No existe la conexion: " + ex.ToString());
            }

            return con;
        }
        public void close()
        {
            con.Close();
        }

    }
}
