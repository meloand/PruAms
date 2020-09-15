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
        public float PengajuanExchange
        { get; set; }
        public string PengajuanBasic
        { get; set; }
        public float PengajuanPertanggungan
        { get; set; }
        public float PengajuanPruHosp
        { get; set; }
        public string PengajuanPruPayor
        { get; set; }
        public float PengajuanPruPayorAmnt
        { get; set; }
        public string PengajuanPruCC
        { get; set; }
        public float PengajuanPruCCAmnt
        { get; set; }
        public string PengajuanPruADD
        { get; set; }
        public float PengajuanPruADDAmnt
        { get; set;  }
        public string PengajuanPruMed
        { get; set; }
        public float PengajuanPruMedAmnt
        { get; set; }
        public string PengajuanPruPPayor
        { get; set; }
        public float PengajuanPruPPayorAmnt
        { get; set; }
        public float PengajuanPremi
        { get; set; }
        public float PengajuanPruSaver
        { get; set; }
        public float PengajuanTotalPremi
        { get; set; }

        public PengajuanForm(string PengajuanFrequency, string PengajuanPay, string PengajuanCCBankOther, 
            string PengajuanExpDate,string PengajuanCurrency, float PengajuanExchange, string PengajuanBasic, 
            float PengajuanPertanggungan, float PengajuanPruHosp, string PengajuanPruPayor, float PengajuanPruPayorAmnt, 
            string PengajuanPruCC, float PengajuanPruCCAmnt, string PengajuanPruADD, float PengajuanPruADDAmnt, 
            string PengajuanPruMed, float PengajuanPruMedAmnt, string PengajuanPruPPayor, float PengajuanPruPPayorAmnt, 
            float PengajuanPremi, float PengajuanPruSaver, float PengajuanTotalPremi)
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
