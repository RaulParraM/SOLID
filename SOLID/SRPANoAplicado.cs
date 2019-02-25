using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class SRPANoAplicado
    {
        List<Usuarios> usuarios;


        public void CrearUsuario(string nombreDeUsuario, int edad)
        {
            Usuarios usuarioaux = new Usuarios(nombreDeUsuario, edad);
            bool existe = false;
            if(usuarios.Contains(usuarioaux)){
                existe = true;
            }
            if ((edad > 18 && !existe))
            {
                Usuarios usuario = new Usuarios(nombreDeUsuario, edad);
                usuarios.Add(usuario);
            }
        }

}
