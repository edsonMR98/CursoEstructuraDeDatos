using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.LiebreYTortuga
{
    abstract class Competidores
    {
        protected int _noPasos;
        protected static Random num = new Random();
        
        public int noPasos
        {
            get { return _noPasos; }
        }

        public virtual void avanzar() { }
    }
}
