using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruAmsForm
{
    class Beneficiary
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthdate { get; set; }
        public string Relationship { get; set; }
        public string Details { get; set; }

        public Beneficiary() : this("", "", "", "", "") { }

        public Beneficiary(string firstName, string lastName, string birthDate, string relationship, string details)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Birthdate = birthDate;
            this.Relationship = relationship;
            this.Details = details;
        }
    }
}
