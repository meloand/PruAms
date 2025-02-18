﻿using System;
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

        public ParentForm() : this("", "", "", "", 0, 0, 0, false) { }

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

        public bool IsEmpty()
        {
            return ParentName == "" && ParentGender == "" && ParentDOB == "" && ParentMarriage == "" && ParentNextBday == 0
                && ParentHeight == 0 && ParentWeight == 0 && ParentSmoke == false;
        }
    }
}
