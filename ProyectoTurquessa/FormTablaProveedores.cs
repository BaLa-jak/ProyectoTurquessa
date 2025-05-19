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
    public partial class FormTablaProveedores : Form
    {
        private LogicaProveedor logicaProveedor;
        public FormTablaProveedores()
        {
            InitializeComponent();
            object[] objects = {  ProveedoresGridView };
            List<Label> Listlabels = new List<Label>();
            List<TextBox> textBoxes = new List<TextBox>();
            logicaProveedor = new LogicaProveedor( Listlabels, textBoxes, objects);
        }

        private void btnRegistrarProveedor_Click(object sender, EventArgs e)
        {
            FormProveedores formProveedores = new FormProveedores();
            formProveedores.Show();
            this.Hide();
        }

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal form1 = new FormMenuPrincipal();
            form1.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            logicaProveedor.GetElementosTablaView();

        }

        private void btnBorrarProveedor_Click(object sender, EventArgs e)
        {
            logicaProveedor.eliminarRegistroProveedor();
        }
    }
}
