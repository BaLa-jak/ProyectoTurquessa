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
using static LinqToDB.Sql;

namespace ProyectoTurquessa
{
    public partial class FormRegistro : Form
    {
        private LogicaRegistroUsuario LogicaRegistroUsuario;
        public FormRegistro()
        {
            InitializeComponent();
            //establecer la lista
            List<TextBox> textBoxes = new List<TextBox>();
            textBoxes.Add(txtUsuario);
            textBoxes.Add(txtContraseña);
            textBoxes.Add(txtConfirmarContraseña);
          

            //lista de Etiquetas
            List<Label> Listlabels = new List<Label>();
            Listlabels.Add(lblUsuario);
            Listlabels.Add(lblContraseña);
            Listlabels.Add(lblConfirmarContraseña);


            //Inicializar Constructor
            LogicaRegistroUsuario =  new LogicaRegistroUsuario(Listlabels, textBoxes);
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            FormLoginTurquessa formLoginTurquessa = new FormLoginTurquessa();
            formLoginTurquessa.Show();
            this.Hide();

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                lblUsuario.ForeColor = Color.Red;

            }
            else
            {
                lblUsuario.ForeColor = Color.Aqua;
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                lblContraseña.ForeColor = Color.Red;

            }
            else
            {
                lblContraseña.ForeColor = Color.Aqua;
            }
        }

        private void txtConfirmarContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmarContraseña.Text == "")
            {
                lblConfirmarContraseña.ForeColor = Color.Red;

            }
            else
            {
                lblConfirmarContraseña.ForeColor = Color.Aqua;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            LogicaRegistroUsuario.ValidarCampos();
        }
    }
    }

