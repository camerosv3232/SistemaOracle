using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OracleClient;
using System.Configuration;
using System.Data;

namespace PruebaOracle
{
    public class dbOrable
    {
        string conexionString = ConfigurationManager.ConnectionStrings["pruebaOracle"].ConnectionString;

        public void conectar()
        {
            try
            {
                OracleConnection conexion = new OracleConnection(conexionString);
                conexion.Open();


                //System.Windows.Forms.MessageBox.Show("Conexion exitosa");
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }

        }

    }
}
