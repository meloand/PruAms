using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruAmsForm
{
    class InsurerForm
    {
        // properties 
  
        public string InsurerName
        { get; set; }
        public string InsurerGender
        { get; set; }
        public string InsurerDOB
        { get; set; }
        public string InsurerMarried
        { get; set; }
        public int InsurerNextBday
        { get; set;  }
        public int InsurerHeight
        { get; set; }
        public int InsurerWeight
        { get; set; }
        public bool InsurerSmoke
        { get; set; }
        public string InsurerJobClass
        { get; set; }


        public InsurerForm(string InsurerName, string InsurerGender, string InsurerDOB, string InsurerMarried, 
            int InsurerNextBday, int InsurerHeight, int InsurerWeight, bool InsurerSmoke, string InsurerJobClass)
        {
            
            this.InsurerName = InsurerName;
            this.InsurerGender = InsurerGender;
            this.InsurerDOB = InsurerDOB;
            this.InsurerMarried = InsurerMarried;
            this.InsurerNextBday = InsurerNextBday;
            this.InsurerHeight = InsurerHeight;
            this.InsurerSmoke = InsurerSmoke;
            this.InsurerJobClass = InsurerJobClass; 


        }
    }
}
