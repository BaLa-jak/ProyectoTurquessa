using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface IPProductoForm
    {
         string idProducto { get; set; }
         string Nombre { get; set; }
         string Categoria { get; set; }
         string Descripcion { get; set; }
         string Precio { get; set; }
         string Descuento { get; set; }
         byte[] Imagen { get; set; }
        bool IdProductoReadOnly { get; set; }
        void Show();
    }
}
