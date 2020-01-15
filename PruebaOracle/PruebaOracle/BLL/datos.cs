using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;

namespace PruebaOracle.BLL
{
    public class datos
    {
        conexion cx = new conexion();
        OracleConnection conec = new OracleConnection();
        OracleCommand cmm = new OracleCommand();
        //OracleCommand cmd = new OracleCommand();


        public DataTable consulta(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                // string sql = "select * from Cliente";
                //www.youtube.com/watch?v=5pA5l12VfOo
                conec = cx.open();
                OracleCommand comando = new OracleCommand("prueba1", conec);
                comando.Parameters.Add("pUsuario", OracleType.Char).Value = "PP021";
                comando.Parameters.Add("pPass", OracleType.Char).Value = "123";
                //comando.Parameters.AddWithValue(":pUsuario", "PP021");
                //comando.Parameters.AddWithValue(":pPass", "123");
                comando.Parameters.Add("resul", OracleType.Cursor).Direction = ParameterDirection.Output;
                comando.CommandType = CommandType.StoredProcedure;
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(dt);
                // conec.Open();

                //cmm.Connection = conec;
                //cmm = conec.CreateCommand();
                
                //cmm.CommandText = query;
                //cmm.CommandType = CommandType.Text;
                //OracleDataReader dr = cmm.ExecuteReader();
                //dr.Read();

                //dr.Dispose();
                //cmm.Dispose();
                //conec.Dispose();

                //cmm = new OracleCommand(query, conec);
                //cmm.CommandType = CommandType.Text;
                //OracleDataAdapter sqlDa = new OracleDataAdapter();

                //sqlDa.SelectCommand = cmm;
                //DataSet ds = new DataSet();
                //sqlDa.Fill(ds);


                
                //OracleDataAdapter da = new OracleDataAdapter(cmm);
                //da.Fill(dt);
                


            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("No se ejecuto datos.Consulta... "+ex.Message);
            }
            return dt;
        }



        public int inserta(string cadInserta)
        {
            int valRet = 0;
            try
            {
                conec = cx.open();
                cmm = new OracleCommand(cadInserta, conec);
                valRet = int.Parse(cmm.ExecuteNonQuery().ToString());
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("No se puede Ejecutar la conexion..");
            }
            finally
            {
                conec.Close();
            }
            return valRet;
        }

    }
}
