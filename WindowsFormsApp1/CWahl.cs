using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CWahl:Wassertier
    {
        private int Gewicht;


        public CWahl() { Gewicht = 10; }

        public CWahl(string N, int T, int GW) : base(N, T) { Gewicht = GW; }

        public int get_Gewicht() { return Gewicht; }



        public string get_WWerte()
        {
            string Text;
            Text = "Name:" + Name + "\n";
            Text += "Tauchzeit:" + tauchzeit + "\n";
            Text += "Gewicht" + Gewicht +" t"+ "\n\n";
            return Text;
        }
    }
}
