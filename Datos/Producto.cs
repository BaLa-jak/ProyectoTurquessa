﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Mapping;

namespace Datos
{
    public class Producto
    {
        [PrimaryKey]
        public string idProducto { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }
        public string Precio { get; set; }
        public string Descuento { get; set; }
        public byte[] Imagen { get; set; }
    }
    
}
