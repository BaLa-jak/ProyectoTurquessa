using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace ProyectoTurquessa
{
    public partial class FormLoginTurquessa : Form
    {
        private LogicaValidar LogicaValidar;
        public FormLoginTurquessa()
        {
            InitializeComponent();
           

            LogicaValidar = new LogicaValidar(txtUsuario.Text, txtContraseña.Text);



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

        private void FormLoginTurquessa_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            LogicaValidar logicaValidar = new LogicaValidar(txtUsuario.Text, txtContraseña.Text);

            if (logicaValidar.validarUsuario()) {
                FormMenuPrincipal Menu = new FormMenuPrincipal();
                Menu.Show();
                this.Hide();
            }
            
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            FormRegistro fr = new FormRegistro();
            fr.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
