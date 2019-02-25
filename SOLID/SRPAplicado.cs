using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class SRPAplicado
    {
        List<Usuarios> usuarios;

        private bool UsuarioCumpleCondiciones(string nombreDeUsuario, int edad)
        {
            if (edad > 18 && NoExisteUsuario(nombreDeUsuario, edad)) return true;
            return false;
        }

        public void CrearUsuario(string nombreDeUsuario, int edad)
        {
            if(UsuarioCumpleCondiciones(nombreDeUsuario, edad)){
                Usuarios usuario = new Usuarios(nombreDeUsuario, edad);
                usuarios.Add(usuario);
            }
        }

        private bool NoExisteUsuario(string nombreDeUsuario, int edad)
        {
            Usuarios usuarioaux = new Usuarios(nombreDeUsuario, edad);
            bool existe = false;
            if (usuarios.Contains(usuarioaux))
            {
                existe = true;
            }
            return existe;
        }
    }
}
