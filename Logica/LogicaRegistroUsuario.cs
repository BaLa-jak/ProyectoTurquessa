using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class LogicaRegistroUsuario
    {
        private List<Label> ListaLabels = new List<Label>();
        private List<TextBox> textBoxes = new List<TextBox>();
        public LogicaRegistroUsuario(List<Label> ListaLabels, List<TextBox> textBoxes)
        {
            this.ListaLabels = ListaLabels;
            this.textBoxes = textBoxes;
        }

        public void ValidarCampos()
        {
            foreach (var item in ListaLabels)
            {
                if (item.Text == string.Empty)
                {
                    MessageBox.Show("Por favor llena todos los campos");
                    return;
                }
            }
            if (textBoxes[1].Text != textBoxes[2].Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }
            MessageBox.Show("Usuario registrado con exito");
        }

    }
}
