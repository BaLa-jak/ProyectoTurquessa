using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTurquessa
{
    public partial class LoginTurquessa : Form
    {
        public LoginTurquessa()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            //Estructura condicional
            if (txtUsuario.Text == "")
            {
                //cambiamos a gris
                lblUsuario.ForeColor = Color.Gray;
            }
            else
            {
                //cambiamos a cyan
                lblUsuario.ForeColor = Color.Cyan;
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            //Estructura condicional
            if (txtContraseña.Text == "")
            {
                //cambiamos a gris
                lblContraseña.ForeColor = Color.Gray;
            }
            else
            {
                //cambiamos a cyan
                lblContraseña.ForeColor = Color.Cyan;
            }
        }

        private void btnSignUp_MouseUp(object sender, MouseEventArgs e)
        {
            btnSignUp.BackColor = Color.Gray;
        }

        private void btnSignUp_MouseDown(object sender, MouseEventArgs e)
        {
            btnSignUp.BackColor = Color.LightCyan;

        }
    }
}
