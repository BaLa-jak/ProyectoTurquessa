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
        private LogicaSubirImagen subirImagen;
        private DataGridView gridImagen;
        
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
            object[] objects = { pictureBox1, gridImagen };
            LogicaSubirImagen subirImagen = new LogicaSubirImagen();
            



            //Inicializar Constructor
            logicaProducto = new LogicaProducto(Listlabels, textBoxes, objects);
        }

        private void btnSubirImagen_Click(object sender, EventArgs e)
        {
  
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            logicaProducto.MensajesRequeridos();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                lblDescripcion.ForeColor = Color.Red;
            }
            else
            {
                lblDescripcion.ForeColor = Color.Aqua;
            }
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "")
            {
                lblCategoria.ForeColor = Color.Red;
            }
            else
            {
                lblCategoria.ForeColor = Color.Aqua;
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
        private void txtValidacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxEvent logicaProducto = new TextBoxEvent();
            logicaProducto.SoloNumeros(e);
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "")
            {
                lblPrecio.ForeColor = Color.Red;
            }
            else
            {
                lblPrecio.ForeColor = Color.Aqua;
            }
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            if (txtDescuento.Text == "")
            {
                lblDescuento.ForeColor = Color.Red;
            }
            else
            {
                lblDescuento.ForeColor = Color.Aqua;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LogicaSubirImagen subirImagen = new LogicaSubirImagen();  
            subirImagen.UploadImage(pictureBox2);
        }

        private void txtValidacion_KeyPress(object sender, EventArgs e)
        {

        }
        private void soloLetrasValidacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxEvent logicaProducto = new TextBoxEvent();
            logicaProducto.soloLetras(e);
        }
    }
}
