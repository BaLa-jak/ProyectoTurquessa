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
    public partial class FormProveedores : Form, Logica.IProveedorForm
    {

        private LogicaProveedor logicaProveedor;
        private DataGridView dataGrid;
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

               
            Object[] objects = { dataGrid };



            //Inicializar Constructor
            logicaProveedor = new LogicaProveedor(Listlabels, textBoxes, objects);

          
        }
        public string IdProveedor
        {
            get { return txtIdProveedor.Text; }
            set { txtIdProveedor.Text = value; }
        }
        public string Empresa
        {
            get { return txtEmpresa.Text; }
            set { txtEmpresa.Text = value; }
        }
        public string Nombre
        {
            get { return txtNombre.Text; }
            set { txtNombre.Text = value; }
        }
        public string Apellido
        {
            get { return txtApellido.Text; }
            set { txtApellido.Text = value; }
        }
        public string Correo
        {
            get { return txtCorreo.Text; }
            set { txtCorreo.Text = value; }
        }
        public string Telefono
        {
            get { return txtTelefono.Text; }
            set { txtTelefono.Text = value; }
        }
        public bool IdProveedorReadOnly
        {
            get { return txtIdProveedor.ReadOnly; }
            set { txtIdProveedor.ReadOnly = value; }
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
            logicaProveedor.MensajesRequeridos();
        }

        private void txtIdProveedor_TextChanged(object sender, EventArgs e)
        {
            if (txtIdProveedor.Text == "")
            {
                lblProveedor.ForeColor = Color.Red;
            }
            else
            {
                lblProveedor.ForeColor = Color.Aqua;
            }
        }

        private void txtEmpresa_TextChanged(object sender, EventArgs e)
        {
            if (txtEmpresa.Text == "")
            {
                lblEmpresa.ForeColor = Color.Red;
            }
            else
            {
                lblEmpresa.ForeColor = Color.Aqua;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                lblNombre.ForeColor = Color.Red;
            }
            else
            {
                lblNombre.ForeColor = Color.Aqua;
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                lblApellido.ForeColor = Color.Red;
            }
            else
            {
                lblApellido.ForeColor = Color.Aqua;
            }
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                lblCorreo.ForeColor = Color.Red;
            }
            else
            {
                lblCorreo.ForeColor = Color.Aqua;
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "")
            {
                lblTelefono.ForeColor = Color.Red;
            }
            else
            {
                lblTelefono.ForeColor = Color.Aqua;
            }
        }

        private void soloLetrasValidacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxEvent logicaProducto = new TextBoxEvent();
            logicaProducto.soloLetras(e);
        }

        private void soloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxEvent logicaProducto = new TextBoxEvent();
            logicaProducto.SoloNumeros(e);
        }
    }
}
