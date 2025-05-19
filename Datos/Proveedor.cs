using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Mapping;

namespace Datos
{
    public class Proveedor
    {
        [PrimaryKey]
        public string idProveedor { get; set; }
        public string Empresa { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        
    }
}
