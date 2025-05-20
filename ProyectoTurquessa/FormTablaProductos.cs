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
    public partial class FormTablaProductos : Form
    {
        private LogicaProducto logicaProducto;
    
        public FormTablaProductos()
        {
            InitializeComponent();
            object[] objects = { pictureBox1, ProductosGridView };
            List<Label> Listlabels = new List<Label>();
            List<TextBox> textBoxes = new List<TextBox>();
            logicaProducto = new LogicaProducto(Listlabels, textBoxes, objects);
            logicaProducto.SolicitarNuevoFormulario += CrearNuevoFormularioProveedor;
        }
        private IPProductoForm CrearNuevoFormularioProveedor()
        {
            return new FormProducto();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FormProducto formProductos = new FormProducto();
            formProductos.Show();
            this.Hide();
        }

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal form1 = new FormMenuPrincipal();
            form1.Show();
            this.Hide();
        }

        private void FormTablaProductos_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            logicaProducto.ActualizarRegistroProducto();
        }

        private void btnMostrarTabla_Click(object sender, EventArgs e)
        {
            logicaProducto.GetElementosTablaView();

        }

        private void btnBorrarProducto_Click(object sender, EventArgs e)
        {
            logicaProducto.eliminarRegistroProducto();
        }

        private void ProductosGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
