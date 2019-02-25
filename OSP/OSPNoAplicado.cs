using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSP
{
    class UsuarioAdmin
    {
        public string nombreUsuario { get; set; }
        public int edad { get; set; }
    }

    class UsuarioComun
    {
        public string nombreUsuario { get; set; }
        public int edad { get; set; }
    }

    class Caracteristicas
    {
        public bool UsuarioAdminPuedeBanear(UsuarioAdmin usuario)
        {
            //Comprovaciones
            return true;
        }

        public bool UsuarioComunPuedeBanear(UsuarioComun usuario)
        {
            //Comprovaciones
            return true;
        }
    }
}
