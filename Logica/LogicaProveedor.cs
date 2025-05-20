using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Logica;
using LinqToDB;





namespace Logica
{
    public class LogicaProveedor
    {
        private List<Label> ListaLabels = new List<Label>();
        private List<TextBox> textBoxes = new List<TextBox>();
        private DataGridView dataGrid;
        public delegate IProveedorForm FormProveedorFactory();
        public event FormProveedorFactory SolicitarNuevoFormulario;

        public LogicaProveedor(List<Label> ListaLabels, List<TextBox> textBoxes, object[] objects)
        {
            this.ListaLabels = ListaLabels;
            this.textBoxes = textBoxes;
            dataGrid = (DataGridView)objects[0];
        }

        public void MensajesRequeridos()
        {
            string[] mensajeRequerido = {
                "El id es requerido", "La Empresa es requerida", "El Nombre es requerido",
                "El Apellido es requerido", "El Correo es requerido", "El Teléfono es requerido"
            };

            string[] mensajeValidado = { "id", "Empresa", "Nombre", "Apellidos", "Correo", "Teléfono" };

            bool camposVacios = false;

            // Verificar si hay campos vacíos primero
            for (int i = 0; i < textBoxes.Count; i++)
            {
                if (string.IsNullOrEmpty(textBoxes[i].Text))
                {
                    ListaLabels[i].Text = mensajeRequerido[i];
                    ListaLabels[i].ForeColor = Color.Red;
                    ListaLabels[i].Focus();
                    camposVacios = true;
                    return;
                }
            }

            // Obtener valores de los campos
            string id = textBoxes[0].Text;
            string empresa = textBoxes[1].Text;
            string nombre = textBoxes[2].Text;
            string apellido = textBoxes[3].Text;
            string email = textBoxes[4].Text;
            string telefono = textBoxes[5].Text;

            // Validar que Nombre y Apellido no contengan números
            if (!EsTextoValido(nombre))
            {
                ListaLabels[2].Text = "Nombre inválido (solo letras)";
                ListaLabels[2].ForeColor = Color.Red;
                textBoxes[2].Focus();
                return;
            }

            if (!EsTextoValido(apellido))
            {
                ListaLabels[3].Text = "Apellido inválido (solo letras)";
                ListaLabels[3].ForeColor = Color.Red;
                textBoxes[3].Focus();
                return;
            }

            // Validar formato del correo electrónico
            if (!EsCorreoValido(email))
            {
                ListaLabels[4].Text = "Correo inválido (Ej: usuario@dominio.com)";
                ListaLabels[4].ForeColor = Color.Red;
                textBoxes[4].Focus();
                return;
            }

            // Validar que Teléfono solo contenga números
            if (!EsTelefonoValido(telefono))
            {
                ListaLabels[5].Text = "Teléfono inválido (solo números)";
                ListaLabels[5].ForeColor = Color.Red;
                textBoxes[5].Focus();
                return;
            }

            // Marcar todos los campos como válidos
            for (int i = 0; i < textBoxes.Count; i++)
            {
                ListaLabels[i].Text = mensajeValidado[i];
                ListaLabels[i].ForeColor = Color.Green;
            }


            using (var conexion = new Conexion())
            {
                // Buscar si el proveedor ya existe por su ID
                var proveedorExistente = conexion.GetTable<Proveedor>().FirstOrDefault(p => p.idProveedor == id);

                if (proveedorExistente != null)
                {
                    // El proveedor existe, actualizar sus datos
                    proveedorExistente.Empresa = empresa;
                    proveedorExistente.Nombre = nombre;
                    proveedorExistente.Apellido = apellido;
                    proveedorExistente.Correo = email;
                    proveedorExistente.Telefono = telefono;

                    // Actualizar el registro en la base de datos
                    conexion.Update(proveedorExistente);

                    // Aviso de actualización satisfactoria
                    MessageBox.Show("Actualización Satisfactoria");
                }
                else
                {
                    // El proveedor no existe, crear un nuevo registro
                    var nuevoProveedor = new Proveedor
                    {
                        idProveedor = id,
                        Empresa = empresa,
                        Nombre = nombre,
                        Apellido = apellido,
                        Correo = email,
                        Telefono = telefono,
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

        public void GetElementosTablaView()
        {
            Conexion conexion = new Conexion();
            List<Proveedor> proveedors = conexion.GetTable<Proveedor>().ToList();
            dataGrid.DataSource = proveedors;
        }

        // Método para validar el correo electrónico con Regex
        private bool EsCorreoValido(string email)
        {
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // Expresión regular para correo válido
            return Regex.IsMatch(email, patron);
        }

        // Método para validar que un texto solo contenga letras (sin números ni caracteres especiales)
        private bool EsTextoValido(string texto)
        {
            string patron = @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"; // Solo letras y espacios
            return Regex.IsMatch(texto, patron);
        }

        // Método para validar que el teléfono solo contenga números
        private bool EsTelefonoValido(string telefono)
        {
            string patron = @"^\d+$"; // Solo números
            return Regex.IsMatch(telefono, patron);
        }

        public void ActualizarRegistroProveedor()
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Desea editar este registro?", "Confirmar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string clave = dataGrid.CurrentRow.Cells[0].Value.ToString();
                    using (var conexion = new Conexion())
                    {
                        var proveedor = conexion.GetTable<Proveedor>().FirstOrDefault(p => p.idProveedor == clave);
                        if (proveedor != null && SolicitarNuevoFormulario != null)
                        {
                            // Solicitar nuevo formulario a través del evento
                            IProveedorForm formProveedores = SolicitarNuevoFormulario();

                            // Configurar el formulario con los datos del proveedor
                            formProveedores.IdProveedor = proveedor.idProveedor;
                            formProveedores.Empresa = proveedor.Empresa;
                            formProveedores.Nombre = proveedor.Nombre;
                            formProveedores.Apellido = proveedor.Apellido;
                            formProveedores.Correo = proveedor.Correo;
                            formProveedores.Telefono = proveedor.Telefono;
                            formProveedores.IdProveedorReadOnly = true;

                            // Mostrar el formulario
                            formProveedores.Show();

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
    

        public void eliminarRegistroProveedor()
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de eliminar el registro?", "Confirmar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string clave = dataGrid.CurrentRow.Cells[0].Value.ToString();
                    using (var conexion = new Conexion())
                    {
                        var proveedor = conexion.GetTable<Proveedor>().FirstOrDefault(p => p.idProveedor == clave);
                        if (proveedor != null)
                        {
                            conexion.Delete(proveedor);
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
