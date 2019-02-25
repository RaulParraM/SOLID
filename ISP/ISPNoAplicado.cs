using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    interface Funcionalidades
    {
        void EnviarSolicitudDeAmistad();
        void Banear();
        void CambiarApariencia();
    }

    class Admin : Funcionalidades
    {
        public void EnviarSolicitudDeAmistad()
        {

        }
        public void Banear()
        {

        }
        public void CambiarApariencia()
        {

        }
    }

    class Prenium : Funcionalidades
    {
        public void EnviarSolicitudDeAmistad()
        {

        }
        public void Banear()
        {
            throw new Exception("No se puede usar");
        }
        public void CambiarApariencia()
        {

        }
    }

    class Normal : Funcionalidades
    {
        public void EnviarSolicitudDeAmistad()
        {

        }
        public void Banear()
        {
            throw new Exception("No se puede usar");
        }
        public void CambiarApariencia()
        {
            throw new Exception("No se puede usar");
        }
    }

}
