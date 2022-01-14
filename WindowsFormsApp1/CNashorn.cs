using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CNashorn:CLandtier
    {
        private int Hornlaenge;


        public CNashorn() { Hornlaenge = 10; }

        public CNashorn(string N, int G, int HL) : base(N,G) { Hornlaenge = HL; }

        public int get_HLaenge() { return Hornlaenge; }



        public string get_NWerte()
        {
            string Text;
            Text = "Name:" + Name + "\n";
            Text += "Geschwindigkeit:" + Geschwindigkeit + "\n";
            Text += "Horn Laenge:" + Hornlaenge + " cm" + "\n\n";
            return Text;
        }
    }
}
