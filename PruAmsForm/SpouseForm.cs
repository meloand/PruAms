using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruAmsForm
{
    class SpouseForm
    {
        public string SpouseName
        { get; set; }
        public string SpouseGender
        { get; set; }
        public string SpouseDOB
        { get; set; }
        public string SpouseMarriage
        { get; set; }
        public int SpouseNextBday
        { get; set;  }
        public int SpouseHeight
        { get; set;  }
        public int SpouseWeight
        { get; set;  }
        public bool SpouseSmoke
        { get; set; }

        public SpouseForm() : this("", "", "", "", 0, 0, 0, false) { }
        public SpouseForm(string SpouseName, string SpouseGender, string SpouseDOB, string SpouseMarriage, int SpouseNextBday, 
            int SpouseHeight, int SpouseWeight, bool SpouseSmoke)
        {
            this.SpouseName = SpouseName;
            this.SpouseGender = SpouseGender;
            this.SpouseDOB = SpouseDOB;
            this.SpouseMarriage = SpouseMarriage;
            this.SpouseNextBday = SpouseNextBday;
            this.SpouseHeight = SpouseHeight;
            this.SpouseWeight = SpouseWeight;
            this.SpouseSmoke = SpouseSmoke; 
        }
    }
}
