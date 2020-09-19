using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruAmsForm
{
    class BeneficiaryForm
    {
        public Beneficiary Beneficiary1 { get; set; }
        public Beneficiary Beneficiary2 { get; set; }
        public Beneficiary Beneficiary3 { get; set; }
        public Beneficiary Beneficiary4 { get; set; }
        public Beneficiary Beneficiary5 { get; set; }
        public Beneficiary Beneficiary6 { get; set; }

        public BeneficiaryForm()
        {
            Beneficiary1 = new Beneficiary();
            Beneficiary2 = new Beneficiary();
            Beneficiary3 = new Beneficiary();
            Beneficiary4 = new Beneficiary();
            Beneficiary5 = new Beneficiary();
            Beneficiary6 = new Beneficiary();
        }
    }
}
