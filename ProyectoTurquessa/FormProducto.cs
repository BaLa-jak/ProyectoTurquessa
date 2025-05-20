using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace ProyectoTurquessa
{
    public partial class FormProducto : Form, IPProductoForm
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
            subirImagen = new LogicaSubirImagen();
            //Inicializar Constructor
            logicaProducto = new LogicaProducto(Listlabels, textBoxes, objects);
          

        }

        public string idProducto
        {
            get { return txtIdProducto.Text; }
            set { txtIdProducto.Text = value; }
        }
        public bool IdProductoReadOnly
        {
            get { return txtIdProducto.ReadOnly; }
            set { txtIdProducto.ReadOnly = value; }
        }
        public string Nombre
        {
            get { return txtNombre.Text; }
            set { txtNombre.Text = value; }
        }
        public string Categoria
        {
            get { return txtCategoria.Text; }
            set { txtCategoria.Text = value; }
        }
        public string Descripcion
        {
            get { return txtDescripcion.Text; }
            set { txtDescripcion.Text = value; }
        }
        public string Precio
        {
            get { return txtPrecio.Text; }
            set { txtPrecio.Text = value; }
        }
        public string Descuento
        {
            get { return txtDescuento.Text; }
            set { txtDescuento.Text = value; }
        }
        public byte[] Imagen
        {
            get { return subirImagen.ConvertirImagen(pictureBox1.Image); }
            set {
                if (value != null && value.Length > 0)
                {
                    try
                    {
                        // Convertir el array de bytes a una imagen usando el método estándar de .NET
                        using (MemoryStream ms = new MemoryStream(value))
                        {
                            // Crear una imagen a partir del MemoryStream
                            Image imagen = Image.FromStream(ms);

                            // Asignar la imagen al PictureBox
                            pictureBox1.Image = imagen;

                            // Configurar el modo de visualización para mejor apariencia
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier error en la conversión
                        MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Si value es null o está vacío, limpiar la imagen
                    pictureBox1.Image = null;
                }
            }
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
            subirImagen.UploadImage(pictureBox2); 
        }

        private void txtValidacion_KeyPress(object sender, EventArgs e)
        {
            if (txtIdProducto.Text == "")
            {
                lblProducto.ForeColor = Color.Red;
            }
            else
            {
                lblProducto.ForeColor = Color.Aqua;
            }
        }
        private void soloLetrasValidacion_KeyPress(object sender, KeyPressEventArgs e)
        {

            TextBoxEvent logicaProducto = new TextBoxEvent();
            logicaProducto.soloLetras(e);
        }
    }
}
