using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class LogicaSubirImagen
    {
        public OpenFileDialog OpenFileDialog = new OpenFileDialog();

        public void UploadImage(PictureBox pb)
        {
            string formatosImagen = "Imagenes |*.jpg;*.gif;*.png;*.bmp;*.webp";
            pb.WaitOnLoad = true;
            OpenFileDialog.Filter = formatosImagen;
            OpenFileDialog.ShowDialog();

            if (OpenFileDialog.FileName != string.Empty)
            {
                pb.ImageLocation = OpenFileDialog.FileName;

            }
            else
            {
                MessageBox.Show("No has seleccionado una imagen");
            }

        }

        public byte[] ConvertirImagen(Image image)
        {
            var convertir = new ImageConverter();
            return (byte[])convertir.ConvertTo(image, typeof(byte[]));

        }
    }
}
