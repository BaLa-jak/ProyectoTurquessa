using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using LinqToDB;

namespace Logica
{
    public class LogicaValidar
    {
 
        private string usuario;
        private string clave;
        private DataGrid dataGrid;

        public LogicaValidar(string usuario, string clave)
        {
           this.usuario = usuario;
            this.clave = clave;
        }

        public bool validarUsuario()
        {
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Usuario y contraseña son requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            Conexion conexion = new Conexion();
            var usuarioEncontrado = conexion.GetTable<Usuario>().FirstOrDefault(u => u.Nombre == usuario);
            
            if (usuarioEncontrado == null)
            {
                MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (usuarioEncontrado.Clave != clave)
            {
                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
        public void GetElementosTablaView()
        {
            Conexion conexion = new Conexion();
            List<Usuario> usuarios = conexion.GetTable<Usuario>().ToList();
            dataGrid.DataSource = usuarios;
        }
    }
}
