using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CLandtier:CTier
    {
        protected int Geschwindigkeit;


        public CLandtier() { Geschwindigkeit = 10; }

        public CLandtier(string N, int G) : base(N) { Geschwindigkeit = G; }

        public int get_geschwindigkeit() { return Geschwindigkeit; }


    }
}
