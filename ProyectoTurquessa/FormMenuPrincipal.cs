using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTurquessa
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnSoporte_Click(object sender, EventArgs e)
        {
            string numeroWhatsApp = "526679140209";
            string mensaje = "Hola, necesito soporte.";

            // Codificar el mensaje para URL
            string mensajeCodificado = Uri.EscapeDataString(mensaje);

            // Enlace de WhatsApp
            string url = $"https://wa.me/{numeroWhatsApp}?text={mensajeCodificado}";

            // Abrir en el navegador
            Process.Start(url);

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir WhatsApp: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarProveedores_Click(object sender, EventArgs e)
        {
            FormProveedores proveedores = new FormProveedores();
            proveedores.Show();
            this.Hide();
        }

        private void btnVerProveedores_Click(object sender, EventArgs e)
        {
            FormTablaProveedores tproveedores = new FormTablaProveedores();
            tproveedores.Show();
            this.Hide();
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            FormProducto producto = new FormProducto();
            producto.Show();
            this.Hide();
        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            FormTablaProductos tproductos = new FormTablaProductos();
            tproductos.Show();
            this.Hide();

        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
