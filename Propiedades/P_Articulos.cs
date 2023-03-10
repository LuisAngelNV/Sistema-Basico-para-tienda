using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Tienda.Propiedades
{
    //Se modifico el tipo de dato
    public class P_Articulos
    {
        public int id_ar { get; set; }
        public string descripcion_ar  { get; set; }
        public string marca_ar { get; set; }
        public int codigo_um { get; set; }
        public int codigo_ca { get; set; }
        public decimal stock_actual { get; set; }
        public string fecha_creado { get; set; }
        public string fecha_modificado { get; set; }
    }
}
