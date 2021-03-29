using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class SV
    {
        public string MSSV { get; set; }
        public string Name { get; set; }
        public double DTB { get; set; }
        public bool gender { get; set; }
        public SV(string MSSV,string Name,double DTB,bool gender)
        {
            this.MSSV = MSSV;
            this.Name = Name;
            this.DTB = DTB;
            this.gender = gender;
        }
    }
}
