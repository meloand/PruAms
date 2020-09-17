using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruAmsForm
{
    class UpdateForm
    {

        public string UpdateInsName
        { get; set; }
        public string UpdateInsDOB
        { get; set; }
        public string UpdateStatus
        { get; set; }
        public string UpdateDate
        { get; set; }
        public string UpdatePolis
        { get; set; }
        public string UpdateInfo
        { get; set; }

        public UpdateForm() : this("", "", "", "", "", "") { }

        public UpdateForm(string UpdateInsName, string UpdateInsDOB, string UpdateStatus, string UpdateDate, 
            string UpdatePolis, string UpdateInfo)
        {
            this.UpdateInsName = UpdateInsName;
            this.UpdateInsDOB = UpdateInsDOB;
            this.UpdateStatus = UpdateStatus;
            this.UpdateDate = UpdateDate;
            this.UpdatePolis = UpdatePolis;
            this.UpdateInfo = UpdateInfo; 
        }
    }
}
