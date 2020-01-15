using PruebaOracle.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PruebaOracle.forms
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        conexion cx = new conexion();
        datos db = new datos();

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string consultaUs = "select codid from empleado where codempleado = '"+txtUsuario.Text+"' and pass ='"+txtContrasenia.Text+"'";
                variables.dbid = 1;
                DataTable dt = new DataTable();
                dt = db.consulta(consultaUs);
                if (dt.Rows.Count > 0)
                {
                    //this.Close();
                    frmPrincipal descargos = new frmPrincipal();
                    descargos.Show();
                }
                else
                {
                    MessageBox.Show("No se encuentra el usuario: "+txtUsuario.Text);
                    
                }
                
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("No existe conexion "+ ex.Message);
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = "PP021";
            txtContrasenia.Text = "123";
        }
    }
}
