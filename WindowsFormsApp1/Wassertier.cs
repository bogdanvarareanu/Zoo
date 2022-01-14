using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Wassertier:CTier
    {
        protected int tauchzeit;


        public Wassertier() { tauchzeit = 10; }

        public Wassertier(string N, int T) : base(N) { tauchzeit = T; }

        public int get_tauchzeit() { return tauchzeit; }
    }
}
