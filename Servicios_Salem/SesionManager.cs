using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE_Salem;

namespace Servicios_Salem
{
    public class SesionManager
    {
        private static SesionManager _instancia;

        public Usuario_BE UsuarioActual { get; private set; }
        private SesionManager()
        {
        }

        public static SesionManager Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new SesionManager();
                }

                return _instancia;
            }
        }

        public void IniciarSesion(Usuario_BE usuario)
        {
            UsuarioActual = usuario;
        }

        public void CerrarSesion()
        {
            UsuarioActual = null;
        }
        public bool HaySesionActiva()
        {
            return UsuarioActual != null;
        }
    }
}
