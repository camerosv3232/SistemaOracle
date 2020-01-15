using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PruebaOracle
{
    public partial class Form1 : Form
    {
        dbOrable db = new dbOrable();
        public Form1()
        {
            InitializeComponent();
            db.conectar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string conexionString = ConfigurationManager.ConnectionStrings["pruebaOracle"].ConnectionString;
            //OracleConnection conexion = new OracleConnection(conexionString);
            //conexion.Open();
            //DataTable dt = new DataTable();
            //OracleCommand cmd = new OracleCommand();
            //cmd.Connection = conexion;

            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select * from empleado";
            //OracleDataAdapter da = new OracleDataAdapter();
            //da.SelectCommand = cmd;
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //conexion.Close();
        }
    }
}
