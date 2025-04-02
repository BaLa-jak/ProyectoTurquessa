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
    public class LogicaProveedor
    {
        private List<Label> ListaLabels = new List<Label>();
        private List<TextBox> textBoxes = new List<TextBox>();

        public LogicaProveedor(List<Label> ListaLabels, List<TextBox> textBoxes)
        {
            this.ListaLabels = ListaLabels;
            this.textBoxes = textBoxes;
        }

        public void MensajesRequeridos()
        {
            string[] mensajeRequerido = {
            "El id es requerido","La Empresa es requerida", "El nombre es requerido", "El apellido es requerido", 
            "El Correo es requerido",  "El Teléfono es requerido" // Agregados Dirección y Teléfono
            };

            string[] mensajeValidado = { "id", "Empresa", "Nombre", "Apellidos", "Correo","Teléfono" };

            bool camposVacios = false;

            // Verificar si hay campos vaciuios primero
            for (int i = 0; i < textBoxes.Count; i++)
            {
                if (string.IsNullOrEmpty(textBoxes[i].Text))
                {
                    ListaLabels[i].Text = mensajeRequerido[i];
                    ListaLabels[i].ForeColor = Color.Red;
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
                    ListaLabels[i].ForeColor = Color.Green;
                }

                // Conversión de imagen
                

                // Crear la conexión e insertar el registro 
                Conexion conexion = new Conexion();
                conexion.Insert(new Proveedor
                {
                    idProveedor = textBoxes[0].Text,
                    Empresa = textBoxes[1].Text,
                    Nombre = textBoxes[2].Text,
                    Apellido = textBoxes[3].Text,
                    Correo = textBoxes[4].Text,
                    Telefono = textBoxes[5].Text,
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
    }
}
