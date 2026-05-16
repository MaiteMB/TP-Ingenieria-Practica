using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Salem
{
    public class Bitacora_BE
    {
        public int idUsuario { get; set; }
        public string usuario { get; set; }
        public string nombre { get; set; }
        public string clave { get; set; }
        public int idrol { get; set; }
        public bool activo { get; set; }
        public bool bloqueado { get; set; }
        public int intentosfallidos { get; set; }
        public DateTime fechaalta { get; set; }
    }
}
