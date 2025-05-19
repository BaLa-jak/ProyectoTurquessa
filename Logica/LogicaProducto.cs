using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using LinqToDB;

namespace Logica
{
    public class LogicaProducto
    {
        private List<Label> ListaLabels = new List<Label>();
        private List<TextBox> textBoxes = new List<TextBox>();
        PictureBox pictureBox;
        private DataGridView dataGrid;
        public LogicaProducto(List<Label> ListaLabels, List<TextBox> textBoxes, object[] objects)
        {
            this.ListaLabels = ListaLabels;
            this.textBoxes = textBoxes;
            pictureBox = (PictureBox)objects[0];
            dataGrid = (DataGridView)objects[1];
        }
        public void MensajesRequeridos()
        {
            string[] mensajeRequerido = {
            "El id es requerido","El nombre es requerido", "La categoría es requerida", "La descripción es requerida",
            "El precio es requerido", "El descuento es requerido" // Agregados Dirección y Teléfono
            };
            string[] mensajeValidado = { "id", "Nombre", "Categoría", "Descripción", "Precio", "Descuento" };
            bool camposVacios = false;
            // Verificar si hay campos vaciuios primero
            for (int i = 0; i < textBoxes.Count; i++)
            {
                if (string.IsNullOrEmpty(textBoxes[i].Text))
                {
                    ListaLabels[i].Text = mensajeRequerido[i];
                    ListaLabels[i].ForeColor = System.Drawing.Color.Red;
                    ListaLabels[i].Focus();
                    camposVacios = true;
                    break;
                }
            }
            if (!camposVacios)
            {
                // Marcar todos los campos como validos
                for (int i = 0; i < textBoxes.Count; i++)
                {
                    ListaLabels[i].Text = mensajeValidado[i];
                    ListaLabels[i].ForeColor = System.Drawing.Color.Green;
                }
                // Conversión de imagen
                LogicaSubirImagen subirImagen = new LogicaSubirImagen();
                var imgArray = subirImagen.ConvertirImagen(pictureBox.Image);
                // Crear la conexión e insertar el registro
                Conexion conexion = new Conexion();
                conexion.Insert(new Producto
                {
                    idProducto = textBoxes[0].Text,
                    Nombre = textBoxes[1].Text,
                    Categoria = textBoxes[2].Text,
                    Descripcion = textBoxes[3].Text,
                    Precio = textBoxes[4].Text,
                    Descuento = textBoxes[5].Text,
                    Imagen = imgArray
                });


                // Aviso de ingreso satisfactorio
                MessageBox.Show("Ingreso Satisfactorio");

                // Limpiar los campos
                for (int i = 0; i < textBoxes.Count; i++)
                {
                    textBoxes[i].Text = "";
                    ListaLabels[i].ForeColor = Color.Black;
                }
            }
        }
        public void GetElementosTablaView()
        {
            Conexion conexion = new Conexion();
            List<Producto> productos = conexion.GetTable<Producto>().ToList();
            dataGrid.DataSource = productos;
        }

        public void eliminarRegistroProducto()
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de eliminar el registro?", "Confirmar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string clave = dataGrid.CurrentRow.Cells[0].Value.ToString();
                    using (var conexion = new Conexion())
                    {
                        var producto = conexion.GetTable<Producto>().FirstOrDefault(p => p.idProducto == clave);
                        if (producto != null)
                        {
                            conexion.Delete(producto);
                            MessageBox.Show("Registro eliminado");
                            GetElementosTablaView();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un registro para eliminar");
            }
        }

    }
}
