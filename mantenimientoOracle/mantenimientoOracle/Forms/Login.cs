using mantenimientoOracle.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mantenimientoOracle.Forms
{
    public partial class Login : Form
    {
        public static OracleConnection conexion;
        public Login()
        {
            InitializeComponent();
        }

        datos db = new datos();
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
           
            try
            {
                string consultaEmpleado = "SELECT CODID FROM EMPLEADO WHERE CODEMPLEADO = '"+txtUsuario.Text+"' AND PASS = '"+txtPass.Text+"' ";
                variables.dbid = 1;
                DataTable dt = new DataTable();
                dt = db.consulta(consultaEmpleado);

                if (dt.Rows.Count > 0 )
                {
                    Form principal = new Forms.mantenimientoOracle();
                    principal.Show();
                    this.Hide();
                }

            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPass.Text = "3238";
            txtUsuario.Text = "PP021";

        }


        OracleConnection ora = new OracleConnection("DATA SOURCE=PruebaConexion; PASSWORD=12345;USER ID=system;");
        private void button1_Click(object sender, EventArgs e)
        {
            ora.Open();
            //conexion.ConnectionString = "DATA SOURCE=PruebaConexion; USER ID=system; PASSWORD=12345;";

            MessageBox.Show("conectado");
        }
    }
}
