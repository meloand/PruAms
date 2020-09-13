using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruAmsForm
{
    class AgentLevelChange
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Number { get; set; }
        public DateTime Changed { get; set; }
        public string LevelBefore { get; set; }
        public string LevelAfter { get; set; }

        public AgentLevelChange(string firstName, string lastName, string number, DateTime changed, string levelBefore, string levelAfter)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Number = number;
            this.Changed = changed;
            this.LevelBefore = levelBefore;
            this.LevelAfter = levelAfter;
        }
    }
}
