using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CTier
    {
        protected string Name;

        public CTier() { Name = "Saugertier"; }

        public CTier(string N) { Name=N; }

        public string get_Name() { return Name; }
    }



}
