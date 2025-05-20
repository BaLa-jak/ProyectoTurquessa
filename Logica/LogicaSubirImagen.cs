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
  


        public void UploadImage(PictureBox pb)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                string formatosImagen = "Imágenes |*.jpg;*.gif;*.png;*.bmp;*.webp";
                pb.WaitOnLoad = true;
                openFileDialog.Filter = formatosImagen;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pb.ImageLocation = openFileDialog.FileName;
                }
                else
                {
                    MessageBox.Show("No has seleccionado una imagen");
                }
            }
        }


        public byte[] ConvertirImagen(Image image)
        {
            var convertir = new ImageConverter();
            return (byte[])convertir.ConvertTo(image, typeof(byte[]));

        }

       
    }
}
