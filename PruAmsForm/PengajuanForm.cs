using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruAmsForm
{
    class PengajuanForm
    { 
        public string PengajuanFrequency
        { get; set; }
        public string PengajuanPay
        { get; set; }
        public string PengajuanCCBankOther
        { get; set; }
        public string PengajuanExpDate
        { get; set; }
        public string PengajuanCurrency
        { get; set;  }
        public double PengajuanExchange
        { get; set; }
        public string PengajuanBasic
        { get; set; }
        public double PengajuanPertanggungan
        { get; set; }
        public double PengajuanPruHosp
        { get; set; }
        public string PengajuanPruPayor
        { get; set; }
        public double PengajuanPruPayorAmnt
        { get; set; }
        public string PengajuanPruCC
        { get; set; }
        public double PengajuanPruCCAmnt
        { get; set; }
        public string PengajuanPruADD
        { get; set; }
        public double PengajuanPruADDAmnt
        { get; set;  }
        public string PengajuanPruMed
        { get; set; }
        public double PengajuanPruMedAmnt
        { get; set; }
        public string PengajuanPruPPayor
        { get; set; }
        public double PengajuanPruPPayorAmnt
        { get; set; }
        public double PengajuanPremi
        { get; set; }
        public double PengajuanPruSaver
        { get; set; }
        public double PengajuanTotalPremi
        { get; set; }

        public PengajuanForm(string PengajuanFrequency, string PengajuanPay, string PengajuanCCBankOther, 
            string PengajuanExpDate,string PengajuanCurrency, double PengajuanExchange, string PengajuanBasic, 
            double PengajuanPertanggungan, double PengajuanPruHosp, string PengajuanPruPayor, double PengajuanPruPayorAmnt, 
            string PengajuanPruCC, double PengajuanPruCCAmnt, string PengajuanPruADD, double PengajuanPruADDAmnt, 
            string PengajuanPruMed, double PengajuanPruMedAmnt, string PengajuanPruPPayor, double PengajuanPruPPayorAmnt, 
            double  PengajuanPremi, double PengajuanPruSaver, double PengajuanTotalPremi)
        {
            this.PengajuanFrequency = PengajuanFrequency;
            this.PengajuanPay = PengajuanPay;
            this.PengajuanCCBankOther = PengajuanCCBankOther;
            this.PengajuanExpDate = PengajuanExpDate;
            this.PengajuanCurrency = PengajuanCurrency;
            this.PengajuanExchange = PengajuanExchange;
            this.PengajuanBasic = PengajuanBasic;
            this.PengajuanPertanggungan = PengajuanPertanggungan;
            this.PengajuanPruHosp = PengajuanPruHosp;
            this.PengajuanPruPayor = PengajuanPruPayor;
            this.PengajuanPruPayorAmnt = PengajuanPruPayorAmnt;
            this.PengajuanPruCC = PengajuanPruCC;
            this.PengajuanPruCCAmnt = PengajuanPruCCAmnt;
            this.PengajuanPruADD = PengajuanPruADD;
            this.PengajuanPruADDAmnt = PengajuanPruADDAmnt;
            this.PengajuanPruMed = PengajuanPruMed;
            this.PengajuanPruMedAmnt = PengajuanPruMedAmnt;
            this.PengajuanPruPPayor = PengajuanPruPPayor;
            this.PengajuanPruPPayorAmnt = PengajuanPruPPayorAmnt;
            this.PengajuanPremi = PengajuanPremi;
            this.PengajuanPruSaver = PengajuanPruSaver;
            this.PengajuanTotalPremi = PengajuanTotalPremi; 


        }
        

    }
}
