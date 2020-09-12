using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruAmsForm
{
    class Agent
    {
        // properties 
        public string Number
        { get; set;  }
        public string Username
        { get; set; }
        public string Password
        { get; set; }
        public string FirstName
        { get; set; }
        public string LastName
        { get; set; }
        public string Email
        { get; set; }
        public string JoinDate
        { get; set; }
        public string Level
        { get; set; }
        public string Leader
        { get; set; }
        public string Religion
        { get; set; }
        public string Sex
        { get; set; }
        private string Addr
        { get; set; }
        private int ZipCode
        { get; set; }
        private int HphoneNum
        { get; set; }
        private int OPhoneNum
        { get; set; }
        private string POB
        { get; set; }
        private string DOB
        { get; set; }

       public Agent(string Number,string Username, string Password, string FirstName, string LastName, 
           string Email, string JoinDate, string Level, string Leader, string Religion,string Sex, 
           string Addr, int ZipCode, int HPhoneNum, int OPhoneNum, string POB, string DOB)
        {
            this.Number = Number;
            this.Username = Username;
            this.Password = Password;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.JoinDate = JoinDate;
            this.Level = Level;
            this.Leader = Leader;
            this.Religion = Religion;
            this.Sex = Sex;
            this.Addr = Addr;
            this.ZipCode = ZipCode;
            this.HphoneNum = HPhoneNum;
            this.OPhoneNum = OPhoneNum;
            this.POB = POB;
            this.DOB = DOB; 

        }


    }
}
