using PruebaOracle.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OracleClient;
using System.Linq;
using System.Text;

namespace PruebaOracle
{
    public class conexion
    {
        OracleConnection con = new OracleConnection();

        string conexionString = ConfigurationManager.ConnectionStrings["pruebaOracle"].ConnectionString;

        public OracleConnection open()
        {
            try
            {
                if(variables.dbid == 1)
                {
                    con.ConnectionString = conexionString;
                    con.Open();
                }
               // System.Windows.Forms.MessageBox.Show("conexion exitosa");

            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("No hay Conexión: "+ex.Message);
            }
            return con;
        }

        public void close()
        {
            close();
        }
    }
}


//

//public void conectar()
//{
//    try
//    {
//        OracleConnection conexion = new OracleConnection(conexionString);
//        conexion.Open();


//        //System.Windows.Forms.MessageBox.Show("Conexion exitosa");
//    }
//    catch (Exception ex)
//    {

//        System.Windows.Forms.MessageBox.Show(ex.ToString());
//    }

//}