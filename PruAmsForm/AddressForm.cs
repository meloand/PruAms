﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruAmsForm
{
    class AddressForm
    {
        public string Address
        { get; set; }
        public string City
        { get; set; }
        public int ZipCode
        { get; set; }
        public string Email
        { get; set; }
        public long HPNumber
        { get; set; }
        public long OPNumber
        { get; set; }

        public AddressForm(string Address, string City, int ZipCode, string Email, long HPNumber, long OPNumber)
        {
            this.Address = Address;
            this.City = City;
            this.ZipCode = ZipCode;
            this.Email = Email;
            this.HPNumber = HPNumber;
            this.OPNumber = OPNumber;

        }


    }

}
