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
    public partial class FormProveedores : Form
    {
        private LogicaProveedor logicaProveedor;
        public FormProveedores()
        {
            InitializeComponent();

            //establecer la lista
            List<TextBox> textBoxes = new List<TextBox>();
            textBoxes.Add(txtIdProveedor);
            textBoxes.Add(txtEmpresa);
            textBoxes.Add(txtNombre);
            textBoxes.Add(txtApellido);
            textBoxes.Add(txtCorreo);
            textBoxes.Add(txtTelefono);


            //lista de Etiquetas
            List<Label> Listlabels = new List<Label>();
            Listlabels.Add(lblProveedor);
            Listlabels.Add(lblEmpresa);
            Listlabels.Add(lblNombre);
            Listlabels.Add(lblApellido);
            Listlabels.Add(lblCorreo);
            Listlabels.Add(lblTelefono);



            //Inicializar Constructor
            logicaProveedor = new LogicaProveedor(Listlabels, textBoxes);

          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {

        }

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal form1 = new FormMenuPrincipal();
            form1.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
