using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mantenimientoOracle.Clases
{
    public class datos
    {
        Conexion cx = new Conexion();
        SqlConnection conexion = new SqlConnection();
        SqlCommand cmm = new SqlCommand();


        public DataTable consulta(string query)
        {
            DataTable dt = new DataTable();

            try
            {
                conexion = cx.open();
                cmm = conexion.CreateCommand();
                cmm.CommandText = query;

                SqlDataAdapter da = new SqlDataAdapter(cmm);
                da.Fill(dt);
                conexion.Close();
            }
            catch (Exception ex)
            {

                conexion.Close();
                MessageBox.Show("NO se pudo consultar la B.D. " +ex.ToString());
            }
            return dt;
        }


        public int inserta(string cadInserta)
        {
            int valRet = 0;

            try
            {
                conexion = cx.open();
                cmm = new SqlCommand(cadInserta, conexion);
                valRet = int.Parse(cmm.ExecuteNonQuery().ToString());
            }
            catch (Exception)
            {

                return 0;
            }
            finally
            {
                conexion.Close();
            }
            return valRet;
        }


    }
}
