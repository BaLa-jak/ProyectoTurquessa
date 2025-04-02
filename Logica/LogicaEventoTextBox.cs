using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class TextBoxEvent
    {
        //Definicion del metodo 
        public void soloLetras(KeyPressEventArgs key)
        {
            //Validacion del text box ID

            if (!char.IsLetter(key.KeyChar) &&
                key.KeyChar != '\b' && //si es diferente de un backspace
                key.KeyChar != ' ')//si es diferente de un espacio vacío
            {
                key.Handled = true; //Si no es letra, no se podra escribir

            }

        }


        //Crearemos un metodo publico, para recibir solo numeros
        public void SoloNumeros(KeyPressEventArgs keyPressEventArgs)
        {
            Boolean soloNumerosValidacion = !char.IsNumber(keyPressEventArgs.KeyChar) &&
                    keyPressEventArgs.KeyChar != '\b' &&
                    keyPressEventArgs.KeyChar != ' ';

            if (soloNumerosValidacion)
            {
                keyPressEventArgs.Handled = true;

            }

        }


        //crearemos un metodo publico, para validar el formato del correo electronico

        public void validarCorreoElectronico(KeyPressEventArgs key)
        {
            //Validacion del text box ID
            if (!char.IsLetterOrDigit(key.KeyChar) &&
                key.KeyChar != '\b' && //si es diferente de un backspace
                key.KeyChar != '@' && //si es diferente de un arroba
                key.KeyChar != '.' && //si es diferente de un punto
                key.KeyChar != '_' && //si es diferente de un guion bajo
                key.KeyChar != '-') //si es diferente de un guion
            {
                key.Handled = true; //Si no es letra, no se podra escribir
            }
        }
    }
}
