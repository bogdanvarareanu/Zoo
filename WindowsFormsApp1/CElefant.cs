using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CElefant:CLandtier
    {
        private int Naselaenge;


        public CElefant() { Naselaenge = 10; }

        public CElefant(string N, int G, int NL) : base(N, G) { Naselaenge = NL; }

        public int get_NLaenge() { return Naselaenge; }


        public string get_EWerte()
        {
            string Text;
            Text = "Name:" + Name + "\n";
            Text += "Geschwindigkeit:" + Geschwindigkeit + "\n";
            Text += "Ruessellaenge:" + Naselaenge + " cm" + "\n\n";
            return Text;
        }
    }
}
