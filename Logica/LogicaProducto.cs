using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using LinqToDB;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Logica
{
    public class LogicaProducto
    {
        private List<Label> ListaLabels = new List<Label>();
        private List<TextBox> textBoxes = new List<TextBox>();
        PictureBox pictureBox;
        private DataGridView dataGrid;
        public delegate IPProductoForm FormProveedorFactory();
        public event FormProveedorFactory SolicitarNuevoFormulario;
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
                // Obtener valores de los campos
                string IdProducto = textBoxes[0].Text;
                string txtNombre = textBoxes[1].Text;
                string txtCategoria = textBoxes[2].Text;
                string txtDescripcion = textBoxes[3].Text;
                string txtPrecio = textBoxes[4].Text;
                string txtDescuento = textBoxes[5].Text;
                using (var conexion = new Conexion())
                {
                    // Buscar si el proveedor ya existe por su ID
                    var proveedorExistente = conexion.GetTable<Producto>().FirstOrDefault(p => p.idProducto == IdProducto);

                    if (proveedorExistente != null)
                    {
                        // El proveedor existe, actualizar sus datos
                        proveedorExistente.idProducto = IdProducto;
                        proveedorExistente.Nombre = txtNombre;
                        proveedorExistente.Categoria = txtCategoria;
                        proveedorExistente.Descripcion = txtDescripcion;
                        proveedorExistente.Precio = txtPrecio;
                        proveedorExistente.Descuento = txtDescuento;
                        proveedorExistente.Imagen = imgArray;


                        // Actualizar el registro en la base de datos
                        conexion.Update(proveedorExistente);

                        // Aviso de actualización satisfactoria
                        MessageBox.Show("Actualización Satisfactoria");
                    }
                    else
                    {
                        // El proveedor no existe, crear un nuevo registro
                        var nuevoProveedor = new Producto
                        {
                            idProducto = IdProducto,
                            Nombre = txtNombre,
                            Categoria = txtCategoria,
                            Descripcion = txtDescripcion,
                            Precio = txtPrecio,
                            Descuento = txtDescuento,
                            Imagen = imgArray

                        };

                        // Insertar el nuevo registro
                        conexion.Insert(nuevoProveedor);

                        // Aviso de inserción satisfactoria
                        MessageBox.Show("Inserción Satisfactoria");
                    }
                }

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
        public void ActualizarRegistroProducto()
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Desea editar este registro?", "Confirmar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string clave = dataGrid.CurrentRow.Cells[0].Value.ToString();
                    using (var conexion = new Conexion())
                    {
                        var proveedor = conexion.GetTable<Producto>().FirstOrDefault(p => p.idProducto == clave);
                        if (proveedor != null && SolicitarNuevoFormulario != null)
                        {
                            // Solicitar nuevo formulario a través del evento
                             IPProductoForm formProductos = SolicitarNuevoFormulario();

                            // Configurar el formulario con los datos del proveedor
                            formProductos.idProducto = proveedor.idProducto;
                            formProductos.Nombre = proveedor.Nombre;
                            formProductos.Categoria = proveedor.Categoria;
                            formProductos.Descripcion = proveedor.Descripcion;
                            formProductos.Precio = proveedor.Precio;
                            formProductos.Descuento = proveedor.Descuento;
                            formProductos.Imagen = proveedor.Imagen;
                            formProductos.IdProductoReadOnly = true;
                            // Mostrar el formulario
                            formProductos.Show();

                            // Ocultar el formulario actual

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un registro para editar");
            }
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
