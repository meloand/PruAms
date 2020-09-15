using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruAmsForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonSPAJClearBackMenu_Click(object sender, EventArgs e)
        {
            Form1 AMS_Home = new Form1();
            AMS_Home.Show();
            this.Close();
        }

        /// <summary>
        /// ADD SPAJ CONTROLS 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonInsInfoAccept_Click(object sender, EventArgs e)
        {

            // Add SPAJ Form 
            int SPAJNum = int.Parse(textBoxSPAJNum.Text);
            string SPAJType = comboBoxSPAJInsType.Text;
            string AgentName = textBoxSPAJAName.Text;
            int AgentNum = int.Parse(textBoxSPAJANum.Text);
            int PruFlyerNum = int.Parse(textBoxPRUFlyerNum.Text);
            string SPAJSubmitDate = dateTimeSPAJSubmit.Text;
            SPAJForm NewSPAJ;

            NewSPAJ = new SPAJForm(SPAJNum, SPAJType, AgentName, AgentNum, PruFlyerNum, SPAJSubmitDate); 

            // Insurer Info Form 
            string InsurerName = textBoxSPAJInsrName.Text;
            string InsurerGender = comboBoxSPAJInsrGender.Text;
            string InsurerDOB = dateTimeSPAJInsrDOB.Text;
            string InsurerMarried = comboBoxSPAJInsrMarriage.Text;
            int InsurerNextBday = NextBday(InsurerDOB);
            textBoxSPAJInsrNextBday.Enabled = false; 
            textBoxSPAJInsrNextBday.Text = InsurerNextBday.ToString("N0");

            int InsurerHeight = int.Parse(textBoxSPAJInsrHeight.Text);
            int InsurerWeight = int.Parse(textBoxSPAJInsrWeight.Text);
            bool InsurerSmoke = radioButtonSPAJInsrSmoke.Checked;
            string InsurerJobClass = comboBoxSPAJJobClass.Text;
            InsurerForm NewInsurer;

            NewInsurer = new InsurerForm(InsurerName,InsurerGender, InsurerDOB, InsurerMarried, InsurerNextBday, 
                                         InsurerHeight, InsurerWeight, InsurerSmoke, InsurerJobClass);

            tabControlAddSPAJ.SelectTab(tabPagePolisHolder);

        }

        private void buttonPolisHolderAccept_Click(object sender, EventArgs e)
        {
            string PolisName = textBoxSPAJPolisName.Text;
            string PolisGender = comboBoxSPAJPolisGender.Text;
            string PolisDOB = dateTimeSPAJPolisDOB.Text;
            string PolisMarriage = comboBoxSPAJPolisMarriage.Text;
            string PolisRs = comboBoxSPAJPolisRs.Text;
            PolisForm NewPolis;

           // if (radioButtonSPAJEQIns.Checked == true)
           // {  }

            NewPolis = new PolisForm(PolisName, PolisGender, PolisDOB, PolisMarriage, PolisRs);
            tabControlAddSPAJ.SelectTab(tabPageSpouseInfo);

        }

        private void buttonSpouseAccept_Click(object sender, EventArgs e)
        {
            string SpouseName = textBoxSPAJSpouseName.Text;
            string SpouseGender = comboBoxSPAJSpouseGender.Text;
            string SpouseDOB = dateTimeSPAJSpouseDOB.Text;
            string SpouseMarriage = comboBoxSPAJSpouseMarriage.Text;
            int SpouseNextBday = NextBday(SpouseDOB);
            textBoxSPAJSpouseNextBday.Enabled = false; 
            textBoxSPAJSpouseNextBday.Text = SpouseNextBday.ToString("N0");
            int SpouseHeight = int.Parse(textBoxSPAJSpouseHeight.Text);
            int SpouseWeight = int.Parse(textBoxSPAJSpouseWeight.Text);
            bool SpouseSmoke = radioButtonSPAJSpouseSmoke.Checked;
            SpouseForm NewSpouse;

            NewSpouse = new SpouseForm(SpouseName, SpouseGender, SpouseDOB, SpouseMarriage, SpouseNextBday,
                SpouseHeight, SpouseWeight, SpouseSmoke); 

            tabControlAddSPAJ.SelectTab(tabPageParentInfo); 
        }

        private void buttonParentAccept_Click(object sender, EventArgs e)
        {
            string ParentName = textBoxSPAJParentName.Text;
            string ParentGender = comboBoxSPAJParentGender.Text;
            string ParentDOB = dateTimeSPAJParentDOB.Text;
            string ParentMarriage = comboBoxSPAJParentMarriage.Text;
            int ParentNextBday = NextBday(ParentDOB);
            textBoxSPAJParentNextBday.Enabled = false; 
            textBoxSPAJSpouseNextBday.Text = NextBday(ParentDOB).ToString("N0");
            int ParentHeight = int.Parse(textBoxSPAJParentHeight.Text);
            int ParentWeight = int.Parse(textBoxSPAJParentWeight.Text);
            bool ParentSmoke = radioButtonSPAJParentSmoke.Checked;
            ParentForm NewParent;

            NewParent = new ParentForm(ParentName, ParentGender, ParentDOB, ParentMarriage, ParentNextBday, ParentHeight, ParentWeight, ParentSmoke);

            tabControlAddSPAJ.SelectTab(tabPageAddressInfo);
        }

        private void buttonAddressAccept_Click(object sender, EventArgs e)
        {
            string Address = textBoxSPAJAddrAddress.Text;
            string AddrCity = textBoxSPAJAddrCity.Text;
            int AddrZipCode = int.Parse(textBoxSPAJAddrZip.Text);
            string AddrEmail = textBoxSPAJAddrEmail.Text;
            int AddrHPNumber = int.Parse(textBoxSPAJAddrHP.Text);
            int AddrOPNumber = int.Parse(textBoxSPAJAddrOP.Text);
            AddressForm NewAddress;

            NewAddress = new AddressForm(Address, AddrCity, AddrZipCode, AddrEmail, AddrHPNumber, AddrOPNumber);

            tabControlAddSPAJ.SelectTab(tabPagePengajuanInfo);

        }

        private void buttonPengajuanAccept_Click(object sender, EventArgs e)
        {
            string PengajuanFrequency = comboBoxSPAJPengajuanFreq.Text;

            string PengajuanPay = comboBoxSPAJPengajuanPay.Text;
            if (PengajuanPay == "Credit Card")
            {
                labelPengajuanCCBankOther.Enabled = true;
                labelPengajuanCCExpDate.Enabled = true;
                textBoxSPAJPengajuanCCBank.Enabled = true;
                textBoxSPAJPengajuanExpDate.Enabled = true;
                labelPengajuanCCBankOther.Text = "Credit Card Num: ";
                labelPengajuanCCExpDate.Text = "Exp. Date: "; 

            }
            else if (PengajuanPay == "Bank Transfer")
            {
                labelPengajuanCCBankOther.Enabled = true;
                labelPengajuanCCExpDate.Enabled = true;
                textBoxSPAJPengajuanCCBank.Enabled = true;
                textBoxSPAJPengajuanExpDate.Enabled = true; 
                labelPengajuanCCBankOther.Text = "Bank Account Num: ";
                labelPengajuanCCExpDate.Text = "Bank Account Name: "; } 
            else if (PengajuanPay == "Other")
            {
                labelPengajuanCCBankOther.Enabled = true;
                textBoxSPAJPengajuanCCBank.Enabled = true;
                labelPengajuanCCBankOther.Text = "Other Type of Payment: "; }
            string PengajuanCCBankOther = textBoxSPAJPengajuanCCBank.Text;
            string PengajuanExpDate = textBoxSPAJPengajuanExpDate.Text; 

            string PengajuanCurrency = comboBoxSPAJPengajuanCurrency.Text; 
            if (PengajuanCurrency == "USD")
            { labelSPAJPengajuanExchRate.Enabled = true;
              textBoxSPAJPengajuanExchange.Enabled = true; 
            }
            float PengajuanExchange = float.Parse(textBoxSPAJPengajuanExchange.Text); 

            string PengajuanBasic = textBoxSPAJPengajuanBasic.Text;
            float PengajuanPertanggungan = float.Parse(textBoxSPAJPengajuanPrtanggung.Text) / BasicPertanggungan(PengajuanFrequency); // total premi per tahun/ frequency

            
            if(checkBoxSPAJPengajuanPruHosp.Checked == true)
            { labelPruHospitalandSurgical.Enabled = true;
              textBoxSPAJPengajuanPruHosp.Enabled = true; 
            }
            float PengajuanPruHosp = float.Parse(textBoxSPAJPengajuanPruHosp.Text) / BasicPertanggungan(PengajuanFrequency);

            if(checkBoxSPAJPengajuanPruPayor.Checked == true)
            {
                textBoxSPAJPengajuanPruPayorAmnt.Enabled = true;
                textBoxSPAJPengajuanPruPayorAmnt.Enabled = true; 
            }
            string PengajuanPruPayor = textBoxSPAJPengajuanPruPayorAmnt.Text;
            float PengajuanPruPayorAmnt = float.Parse(textBoxSPAJPengajuanPruPayorAmnt.Text)/BasicPertanggungan(PengajuanFrequency);

      
            if(checkBoxSPAJPengajuanPruCC.Checked == true)
            {
                textBoxSPAJPengajuanPruCC.Enabled = true;
                textBoxSPAJPengajuanPruCCAmnt.Enabled = true;
            }
            string PengajuanPruCC = textBoxSPAJPengajuanPruCC.Text;
            float PengajuanPruCCAmnt = float.Parse(textBoxSPAJPengajuanPruCCAmnt.Text)/BasicPertanggungan(PengajuanFrequency);

            
            if(checkBoxSPAJPengajuanADD.Checked == true)
            {
                textBoxSPAJPengajuanPruADD.Enabled = true;
                textBoxSPAJPengajuanPruADDAmnt.Enabled = true; 
            }
            string PengajuanPruADD = textBoxSPAJPengajuanPruADD.Text;
            float PengajuanPruADDAmnt = float.Parse(textBoxSPAJPengajuanPruADDAmnt.Text)/ BasicPertanggungan(PengajuanFrequency);

            if(checkBoxSPAJPengajuanPruMed.Checked == true)
            {
                textBoxSPAJPengajuanPruMed.Enabled = true;
                textBoxSPAJPengajuanPruMedAmnt.Enabled = true; 
            }
            string PengajuanPruMed = textBoxSPAJPengajuanPruMed.Text;
            float PengajuanPruMedAmnt = float.Parse(textBoxSPAJPengajuanPruMedAmnt.Text)/ BasicPertanggungan(PengajuanFrequency); 

            if (checkBoxSPAJPengajuanPruPPayor.Checked == true)
            {
                textBoxSPAJPengajuanPruPPayor.Enabled = true;
                textBoxSPAJPengajuanPruPPayorAmnt.Enabled = true; 
            }
            string PengajuanPruPPayor = textBoxSPAJPengajuanPruPPayor.Text;
            float PengajuanPruPPayorAmnt = float.Parse(textBoxSPAJPengajuanPruPPayorAmnt.Text) / BasicPertanggungan(PengajuanFrequency);


            float PengajuanPremi = (PengajuanPertanggungan + PengajuanPruHosp + PengajuanPruPayorAmnt +
                PengajuanPruCCAmnt + PengajuanPruADDAmnt + PengajuanPruMedAmnt + PengajuanPruPPayorAmnt); 
            float PengajuanPruSaver = float.Parse(textBoxSPAJPengajuanPruSaver.Text) / BasicPertanggungan(PengajuanFrequency);
            float PengajuanTotalPremi = (PengajuanPremi + PengajuanPruSaver) * BasicPertanggungan(PengajuanFrequency); 

            PengajuanForm NewPengajuan;
            NewPengajuan = new PengajuanForm(PengajuanFrequency, PengajuanPay, PengajuanCCBankOther,
            PengajuanExpDate, PengajuanCurrency, PengajuanExchange, PengajuanBasic,
            PengajuanPertanggungan, PengajuanPruHosp, PengajuanPruPayor, PengajuanPruPayorAmnt,
            PengajuanPruCC, PengajuanPruCCAmnt, PengajuanPruADD, PengajuanPruADDAmnt,
            PengajuanPruMed, PengajuanPruMedAmnt, PengajuanPruPPayor, PengajuanPruPPayorAmnt,
            PengajuanPremi, PengajuanPruSaver, PengajuanTotalPremi);

            tabControlAddSPAJ.SelectTab(tabPageBeneficiaryInfo);
        }

        private void buttonBeneficiaryAccept_Click(object sender, EventArgs e)
        {
            if(checkBoxSPAJBeneficiary1.Checked == true)
            {
              textBoxSPAJBeneficiaryFName1.Enabled = true;
              textBoxSPAJBeneficiaryLName1.Enabled = true;
              dateTimeSPAJBeneficiary1.Enabled = true;
              comboBoxSPAJBeneficiaryRs1.Enabled = true;
            }
            string BeneficiaryFName1 = textBoxSPAJBeneficiaryFName1.Text;
            string BeneficiaryLName1 = textBoxSPAJBeneficiaryLName1.Text;
            string BeneficiaryDOB1 = dateTimeSPAJBeneficiary1.Text;
            string BeneficiaryRs1 = comboBoxSPAJBeneficiaryRs1.Text;
            if (BeneficiaryRs1 == "Other")
            { comboBoxSPAJBeneficiaryRs1.Enabled = true; }
            string BeneficiaryDetail1 = textBoxSPAJBeneficiaryDetail1.Text;

            if (checkBoxSPAJBeneficiary2.Checked == true)
            {
                textBoxSPAJBeneficiaryFName2.Enabled = true;
                textBoxSPAJBeneficiaryLName2.Enabled = true;
                dateTimeSPAJBeneficiary2.Enabled = true;
                comboBoxSPAJBeneficiaryRs2.Enabled = true;
            }
            string BeneficiaryFName2 = textBoxSPAJBeneficiaryFName2.Text;
            string BeneficiaryLName2 = textBoxSPAJBeneficiaryLName2.Text;
            string BeneficiaryDOB2 = dateTimeSPAJBeneficiary2.Text;
            string BeneficiaryRs2 = comboBoxSPAJBeneficiaryRs2.Text;
            if (BeneficiaryRs2 == "Other")
            { comboBoxSPAJBeneficiaryRs2.Enabled = true; }
            string BeneficiaryDetail2 = textBoxSPAJBeneficiaryDetail2.Text;

            if (checkBoxSPAJBeneficiary3.Checked == true)
            {
                textBoxSPAJBeneficiaryFName3.Enabled = true;
                textBoxSPAJBeneficiaryLName3.Enabled = true;
                dateTimeSPAJBeneficiary3.Enabled = true;
                comboBoxSPAJBeneficiaryRs3.Enabled = true;
            }
            string BeneficiaryFName3 = textBoxSPAJBeneficiaryFName3.Text;
            string BeneficiaryLName3 = textBoxSPAJBeneficiaryLName3.Text;
            string BeneficiaryDOB3 = dateTimeSPAJBeneficiary3.Text;
            string BeneficiaryRs3 = comboBoxSPAJBeneficiaryRs3.Text;
            if (BeneficiaryRs3 == "Other")
            { comboBoxSPAJBeneficiaryRs3.Enabled = true; }
            string BeneficiaryDetail3 = textBoxSPAJBeneficiaryDetail3.Text;

            if (checkBoxSPAJBeneficiary4.Checked == true)
            {
                textBoxSPAJBeneficiaryFName4.Enabled = true;
                textBoxSPAJBeneficiaryLName4.Enabled = true;
                dateTimeSPAJBeneficiary4.Enabled = true;
                comboBoxSPAJBeneficiaryRs4.Enabled = true;
            }
            string BeneficiaryFName4 = textBoxSPAJBeneficiaryFName4.Text;
            string BeneficiaryLName4 = textBoxSPAJBeneficiaryLName4.Text;
            string BeneficiaryDOB4 = dateTimeSPAJBeneficiary4.Text;
            string BeneficiaryRs4 = comboBoxSPAJBeneficiaryRs4.Text;
            if (BeneficiaryRs4 == "Other")
            { comboBoxSPAJBeneficiaryRs4.Enabled = true; }
            string BeneficiaryDetail4 = textBoxSPAJBeneficiaryDetail4.Text;

            if (checkBoxSPAJBeneficiary5.Checked == true)
            {
                textBoxSPAJBeneficiaryFName5.Enabled = true;
                textBoxSPAJBeneficiaryLName5.Enabled = true;
                dateTimeSPAJBeneficiary5.Enabled = true;
                comboBoxSPAJBeneficiaryRs5.Enabled = true;
            }
            string BeneficiaryFName5 = textBoxSPAJBeneficiaryFName5.Text;
            string BeneficiaryLName5 = textBoxSPAJBeneficiaryLName5.Text;
            string BeneficiaryDOB5 = dateTimeSPAJBeneficiary5.Text;
            string BeneficiaryRs5 = comboBoxSPAJBeneficiaryRs5.Text;
            if (BeneficiaryRs5 == "Other")
            { comboBoxSPAJBeneficiaryRs5.Enabled = true; }
            string BeneficiaryDetail5 = textBoxSPAJBeneficiaryDetail5.Text;

            if (checkBoxSPAJBeneficiary6.Checked == true)
            {
                textBoxSPAJBeneficiaryFName6.Enabled = true;
                textBoxSPAJBeneficiaryLName6.Enabled = true;
                dateTimeSPAJBeneficiary6.Enabled = true;
                comboBoxSPAJBeneficiaryRs6.Enabled = true;
            }
            string BeneficiaryFName6 = textBoxSPAJBeneficiaryFName6.Text;
            string BeneficiaryLName6 = textBoxSPAJBeneficiaryLName6.Text;
            string BeneficiaryDOB6 = dateTimeSPAJBeneficiary6.Text;
            string BeneficiaryRs6 = comboBoxSPAJBeneficiaryRs6.Text;
            if (BeneficiaryRs6 == "Other")
            { comboBoxSPAJBeneficiaryRs6.Enabled = true; }
            string BeneficiaryDetail6 = textBoxSPAJBeneficiaryDetail6.Text;



            buttonSPAJNewCreate.Enabled = true; 

        }

        private void buttonSPAJNewCreate_Click(object sender, EventArgs e)
        {
            buttonSPAJNewStoreFiles.Enabled = true;
            buttonSPAJNewCreate.Enabled = false;
            buttonSPAJNewClear.Enabled = false; 
        }



        // PRIVATE METHODS 

        private int NextBday(string DOB)
        {
            DateTime Today = DateTime.Today;
            DateTime Bday = Convert.ToDateTime(DOB);

            return (Today.Year - Bday.Year) + 1; ; 
          

        }

        private int BasicPertanggungan(string Frequency)
        {
            if (Frequency == "Monthly")
            { return 12;  }
            else if (Frequency == "Quarterly")
            { return 4;  }
            else if (Frequency == "Half Yearly")
            { return 2;  } 
            else // yearly 
            { return 1; }
        }
    }
}
