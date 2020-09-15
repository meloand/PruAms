using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruAmsForm
{
    class PolisForm
    {

        public string PolisName
        { get; set; }
        public string PolisGender
        { get; set; }
        public string PolisDOB
        { get; set; }
        public string PolisMarriage
        { get; set; }
        public string PolisRs
        { get; set; }

        public PolisForm(string PolisName, string PolisGender, string PolisDOB, string PolisMarriage, string PolisRS)
        {
            this.PolisName = PolisName;
            this.PolisGender = PolisGender;
            this.PolisDOB = PolisDOB;
            this.PolisMarriage = PolisMarriage;
            this.PolisRs = PolisRS; 

        }
    }
}
