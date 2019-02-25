using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    interface IEnviarSolicitudDeAmistad
    {
        void EnviarSolicitudDeAmistad();
    }

    interface IBanear
    {
        void Banear();
    }

    interface ICambiarApariencia
    {
        void CambiarApariencia();
    }

    class Admin : ICambiarApariencia, IBanear, IEnviarSolicitudDeAmistad
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

    class Prenium : ICambiarApariencia, IEnviarSolicitudDeAmistad
    {
        public void EnviarSolicitudDeAmistad()
        {

        }

        public void CambiarApariencia()
        {

        }

    }

    class Normal : IEnviarSolicitudDeAmistad
    {
        public void EnviarSolicitudDeAmistad()
        {

        }
    }
}
