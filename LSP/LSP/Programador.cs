using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    abstract class ProgramadorJunior
    {
        public virtual int sueldo()
        {
            return 2000;
        }
    }

    class Mediocre : ProgramadorJunior
    {
        public override int sueldo()
        {
            return 1500;
        }
    }

    class Brillante : ProgramadorJunior
    {
        public override int sueldo()
        {
            return 2500;
        }
    }



}
