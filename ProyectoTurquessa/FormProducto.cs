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
    public partial class FormProducto : Form
    {
        private LogicaProducto logicaProducto;
        public FormProducto()
        {
            InitializeComponent();

            //establecer la lista
            List<TextBox> textBoxes = new List<TextBox>();
            textBoxes.Add(txtIdProducto);
            textBoxes.Add(txtNombre);
            textBoxes.Add(txtCategoria);
            textBoxes.Add(txtDescripcion);
            textBoxes.Add(txtPrecio);
            textBoxes.Add(txtDescuento);


            //lista de Etiquetas
            List<Label> Listlabels = new List<Label>();
            Listlabels.Add(lblProducto);
            Listlabels.Add(lblNombre);
            Listlabels.Add(lblCategoria);
            Listlabels.Add(lblDescripcion);
            Listlabels.Add(lblPrecio);
            Listlabels.Add(lblDescuento);
            object[] objects = { btnSubirImagen };
            LogicaSubirImagen subirImagen = new LogicaSubirImagen();



            //Inicializar Constructor
            logicaProducto = new LogicaProducto(Listlabels, textBoxes);
        }

        private void btnSubirImagen_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal form1 = new FormMenuPrincipal();
            form1.Show();
            this.Hide();
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {

        }

        private void txtIdProducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
