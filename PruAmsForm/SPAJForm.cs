using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruAmsForm
{
    class SPAJForm
    {
        public long SPAJNum
        { get; set; }
        public string SPAJType
        { get; set; }
        public string AgentName
        { get; set; }
        public int AgentNum
        { get; set; }
        public int PruFlyerNum
        { get; set; }
        public string SPAJSubmitDate
        { get; set; }

        public SPAJForm(long SPAJNum, string SPAJType, string AgentName, int AgentNum, int PruFlyerNum,
            string SPAJSubmitDate)
        {
            this.SPAJNum = SPAJNum;
            this.SPAJType = SPAJType;
            this.AgentName = AgentName;
            this.AgentNum = AgentNum;
            this.PruFlyerNum = PruFlyerNum;
            this.SPAJSubmitDate = SPAJSubmitDate;
        }

    }
}
