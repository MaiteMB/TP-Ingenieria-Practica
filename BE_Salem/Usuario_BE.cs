using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Salem
{
    public class Usuario_BE
    {
        public int idUsuario { get; set;}
        public string usuario { get; set; }
        public string clave { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fechaalta { get; set; }
        public int IdRol { get; set; }
        public bool activo { get; set; }
        public bool bloqueado { get; set; }     
        public int intentosFallidos { get; set; }
    }
}
