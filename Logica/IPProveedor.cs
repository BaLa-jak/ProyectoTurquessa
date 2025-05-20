using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface IProveedorForm
    {
        string IdProveedor { get; set; }
        string Empresa { get; set; }
        string Nombre { get; set; }
        string Apellido { get; set; }
        string Correo { get; set; }
        string Telefono { get; set; }
        bool IdProveedorReadOnly { get; set; }
        void Show();
    }

}
