using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.c3_dominio.entidad
{
    public abstract class Producto
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string codigopatrimonial { get; set; }
    }
}
