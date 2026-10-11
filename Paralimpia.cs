using System;
using System.Collections.Generic;
using System.Text;

namespace ParalimpiaGUI
{
    internal class Paralimpia
    {
        public Paralimpia(string l)
        {
            var r = l.Split("\t");
            Id = int.Parse(r[0]);
            Orszag = r[1];
            Varos = r[2];
            Ev = int.Parse(r[3]);
            Arany = int.Parse(r[4]);
            Ezust = int.Parse(r[5]);
            Bronz = int.Parse(r[6]);

        }

        public int Id { get; set; }
        public string Orszag { get; set; }
        public string Varos { get; set; }
        public int Ev { get; set; }
        public int Arany { get; set; }
        public int Ezust { get; set; }
        public int Bronz { get; set; }


    }
}
