using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class LogicaProducto
    {
        private List<Label> ListaLabels = new List<Label>();
        private List<TextBox> textBoxes = new List<TextBox>();
        public LogicaProducto(List<Label> ListaLabels, List<TextBox> textBoxes)
        {
            this.ListaLabels = ListaLabels;
            this.textBoxes = textBoxes;
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
                // Crear la conexión e insertar el registro
                Conexion conexion = new Conexion();
            }
        }
    }
}
