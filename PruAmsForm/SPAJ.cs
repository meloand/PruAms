using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruAmsForm
{
    class SPAJ
    {
        public AddressForm AddressForm { get; set; }
        public BeneficiaryForm BeneficiaryForm { get; set; }
        public InsurerForm InsurerForm { get; set; }
        public ParentForm ParentForm { get; set; }
        public PengajuanForm PengajuanForm { get; set; }
        public PolisForm PolisForm { get; set; }
        public SPAJForm SPAJForm { get; set; }
        public SpouseForm SpouseForm { get; set; }

        public SPAJ()
        {

        }

        public SPAJ(AddressForm address, BeneficiaryForm beneficiary, InsurerForm insurer, ParentForm parent,
            PengajuanForm pengajuan, PolisForm polis, SPAJForm spaj, SpouseForm spouse)
        {
            this.AddressForm = address;
            this.BeneficiaryForm = beneficiary;
            this.InsurerForm = insurer;
            this.ParentForm = parent;
            this.PengajuanForm = pengajuan;
            this.PolisForm = polis;
            this.SPAJForm = spaj;
            this.SpouseForm = spouse;
        }
    }
}
