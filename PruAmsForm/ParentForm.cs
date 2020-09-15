using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruAmsForm
{
    class ParentForm
    {
        public string ParentName
        { get; set; }
        public string ParentGender
        { get; set; }
        public string ParentDOB
        { get; set; }
        public string ParentMarriage
        { get; set; }
        public int ParentNextBday
        { get; set; }
        public int ParentHeight
        { get; set; }
        public int ParentWeight
        { get; set; }
        public bool ParentSmoke
        { get; set; }

        public ParentForm(string ParentName, string ParentGender, string ParentDOB, string ParentMarriage, int ParentNextBday,
            int ParentHeight, int ParentWeight, bool ParentSmoke)
        {
            this.ParentName = ParentName;
            this.ParentGender = ParentGender;
            this.ParentDOB = ParentDOB;
            this.ParentMarriage = ParentMarriage;
            this.ParentNextBday = ParentNextBday;
            this.ParentHeight = ParentHeight;
            this.ParentWeight = ParentWeight;
            this.ParentSmoke = ParentSmoke; 
        }
    }
}
