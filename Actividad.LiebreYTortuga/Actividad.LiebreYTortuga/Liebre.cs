using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.LiebreYTortuga
{
    class Liebre : Competidores
    {
        public Liebre()
        {
            _noPasos = 0;
        }

        public override void avanzar()
        {
            int n = num.Next(1, 11);

            if (n < 3) _noPasos += 0;
            else if (n < 5) _noPasos += 9;
            else if (n < 6) _noPasos -= 12;
            else if (n < 9) _noPasos += 1;
            else
                _noPasos -= 2;
            if (_noPasos < 0) _noPasos = 0;
        }

        public override string ToString()
        {
            return "La liebre esta en " + this.noPasos;
        }
    }
}
