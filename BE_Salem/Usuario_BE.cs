using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Salem
{
    public class Usuario_BE
    {
        public int idBitacora { get; set; }
        public int? idUsuario { get; set;}
        public string usuario { get; set; }
        public string acccion { get; set; }

        public string descripcion { get; set;}
        public DateTime fechahora { get; set; }

    }
}
