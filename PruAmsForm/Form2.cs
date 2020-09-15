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
        private List<SPAJ> spajFiles = new List<SPAJ>();
        private SPAJ spaj = new SPAJ();

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
            spaj.SPAJForm = NewSPAJ;

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
            spaj.InsurerForm = NewInsurer;

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
            spaj.PolisForm = NewPolis;
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
            spaj.SpouseForm = NewSpouse;

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
            spaj.ParentForm = NewParent;

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
            spaj.AddressForm = NewAddress;

            tabControlAddSPAJ.SelectTab(tabPagePengajuanInfo);

        }

        private void buttonPengajuanAccept_Click(object sender, EventArgs e)
        {
            string PengajuanFrequency = comboBoxSPAJPengajuanFreq.Text;

            string PengajuanPay = comboBoxSPAJPengajuanPay.Text;
            string PengajuanCCBankOther = textBoxSPAJPengajuanCCBank.Text;
            string PengajuanExpDate = textBoxSPAJPengajuanExpDate.Text; 

            string PengajuanCurrency = comboBoxSPAJPengajuanCurrency.Text; 
            float PengajuanExchange = float.Parse(textBoxSPAJPengajuanExchange.Text); 

            string PengajuanBasic = textBoxSPAJPengajuanBasic.Text;
            float PengajuanPertanggungan = float.Parse(textBoxSPAJPengajuanPrtanggung.Text) / BasicPertanggungan(PengajuanFrequency); // total premi per tahun/ frequency

 
            float PengajuanPruHosp = float.Parse(textBoxSPAJPengajuanPruHosp.Text) / BasicPertanggungan(PengajuanFrequency);

            string PengajuanPruPayor = textBoxSPAJPengajuanPruPayorAmnt.Text;
            float PengajuanPruPayorAmnt = float.Parse(textBoxSPAJPengajuanPruPayorAmnt.Text)/BasicPertanggungan(PengajuanFrequency);

            string PengajuanPruCC = textBoxSPAJPengajuanPruCC.Text;
            float PengajuanPruCCAmnt = float.Parse(textBoxSPAJPengajuanPruCCAmnt.Text)/BasicPertanggungan(PengajuanFrequency);
  
            string PengajuanPruADD = textBoxSPAJPengajuanPruADD.Text;
            float PengajuanPruADDAmnt = float.Parse(textBoxSPAJPengajuanPruADDAmnt.Text)/ BasicPertanggungan(PengajuanFrequency);

 
            string PengajuanPruMed = textBoxSPAJPengajuanPruMed.Text;
            float PengajuanPruMedAmnt = float.Parse(textBoxSPAJPengajuanPruMedAmnt.Text)/ BasicPertanggungan(PengajuanFrequency); 

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
            spaj.PengajuanForm = NewPengajuan;

            tabControlAddSPAJ.SelectTab(tabPageBeneficiaryInfo);
        }

        private void buttonBeneficiaryAccept_Click(object sender, EventArgs e)
        {
            BeneficiaryForm beneficiaryForm = new BeneficiaryForm();
            if (checkBoxSPAJBeneficiary1.Checked)
            {
                string BeneficiaryFName1 = textBoxSPAJBeneficiaryFName1.Text;
                string BeneficiaryLName1 = textBoxSPAJBeneficiaryLName1.Text;
                string BeneficiaryDOB1 = dateTimeSPAJBeneficiary1.Text;
                string BeneficiaryRs1 = comboBoxSPAJBeneficiaryRs1.Text;
                string BeneficiaryDetail1 = textBoxSPAJBeneficiaryDetail1.Text;
                beneficiaryForm.Beneficiary1 = new Beneficiary(BeneficiaryFName1, BeneficiaryLName1, BeneficiaryDOB1, BeneficiaryRs1, BeneficiaryDetail1);
            }

            if (checkBoxSPAJBeneficiary2.Checked)
            {
                string BeneficiaryFName2 = textBoxSPAJBeneficiaryFName2.Text;
                string BeneficiaryLName2 = textBoxSPAJBeneficiaryLName2.Text;
                string BeneficiaryDOB2 = dateTimeSPAJBeneficiary2.Text;
                string BeneficiaryRs2 = comboBoxSPAJBeneficiaryRs2.Text;
                string BeneficiaryDetail2 = textBoxSPAJBeneficiaryDetail2.Text;
                beneficiaryForm.Beneficiary2 = new Beneficiary(BeneficiaryFName2, BeneficiaryLName2, BeneficiaryDOB2, BeneficiaryRs2, BeneficiaryDetail2);
            }
            if (checkBoxSPAJBeneficiary3.Checked)
            {
                string BeneficiaryFName3 = textBoxSPAJBeneficiaryFName3.Text;
                string BeneficiaryLName3 = textBoxSPAJBeneficiaryLName3.Text;
                string BeneficiaryDOB3 = dateTimeSPAJBeneficiary3.Text;
                string BeneficiaryRs3 = comboBoxSPAJBeneficiaryRs3.Text;
                string BeneficiaryDetail3 = textBoxSPAJBeneficiaryDetail3.Text;
                beneficiaryForm.Beneficiary3 = new Beneficiary(BeneficiaryFName3, BeneficiaryLName3, BeneficiaryDOB3, BeneficiaryRs3, BeneficiaryDetail3);
            }
            if (checkBoxSPAJBeneficiary4.Checked)
            {
                string BeneficiaryFName4 = textBoxSPAJBeneficiaryFName4.Text;
                string BeneficiaryLName4 = textBoxSPAJBeneficiaryLName4.Text;
                string BeneficiaryDOB4 = dateTimeSPAJBeneficiary4.Text;
                string BeneficiaryRs4 = comboBoxSPAJBeneficiaryRs4.Text;
                string BeneficiaryDetail4 = textBoxSPAJBeneficiaryDetail4.Text;
                beneficiaryForm.Beneficiary4 = new Beneficiary(BeneficiaryFName4, BeneficiaryLName4, BeneficiaryDOB4, BeneficiaryRs4, BeneficiaryDetail4);
            }
            if (checkBoxSPAJBeneficiary5.Checked)
            {
                string BeneficiaryFName5 = textBoxSPAJBeneficiaryFName5.Text;
                string BeneficiaryLName5 = textBoxSPAJBeneficiaryLName5.Text;
                string BeneficiaryDOB5 = dateTimeSPAJBeneficiary5.Text;
                string BeneficiaryRs5 = comboBoxSPAJBeneficiaryRs5.Text;
                string BeneficiaryDetail5 = textBoxSPAJBeneficiaryDetail5.Text;
                beneficiaryForm.Beneficiary5 = new Beneficiary(BeneficiaryFName5, BeneficiaryLName5, BeneficiaryDOB5, BeneficiaryRs5, BeneficiaryDetail5);
            }
            if (checkBoxSPAJBeneficiary6.Checked)
            {
                string BeneficiaryFName6 = textBoxSPAJBeneficiaryFName6.Text;
                string BeneficiaryLName6 = textBoxSPAJBeneficiaryLName6.Text;
                string BeneficiaryDOB6 = dateTimeSPAJBeneficiary6.Text;
                string BeneficiaryRs6 = comboBoxSPAJBeneficiaryRs6.Text;
                string BeneficiaryDetail6 = textBoxSPAJBeneficiaryDetail6.Text;
                beneficiaryForm.Beneficiary6 = new Beneficiary(BeneficiaryFName6, BeneficiaryLName6, BeneficiaryDOB6, BeneficiaryRs6, BeneficiaryDetail6);
            }

            spaj.BeneficiaryForm = beneficiaryForm;
            buttonSPAJNewCreate.Enabled = true; 

        }

        private void buttonSPAJNewCreate_Click(object sender, EventArgs e)
        {
            buttonSPAJNewStoreFiles.Enabled = true;
            buttonSPAJNewCreate.Enabled = false;
            buttonSPAJNewClear.Enabled = false;

            // spaj now has all completed forms as its properties
            spajFiles.Add(spaj);
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

        private void checkBoxSPAJBeneficiary1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSPAJBeneficiaryFName1.Enabled = checkBoxSPAJBeneficiary1.Checked;
            textBoxSPAJBeneficiaryLName1.Enabled = checkBoxSPAJBeneficiary1.Checked;
            dateTimeSPAJBeneficiary1.Enabled = checkBoxSPAJBeneficiary1.Checked;
            comboBoxSPAJBeneficiaryRs1.Enabled = checkBoxSPAJBeneficiary1.Checked;
        }

        private void checkBoxSPAJBeneficiary2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSPAJBeneficiaryFName2.Enabled = checkBoxSPAJBeneficiary2.Checked;
            textBoxSPAJBeneficiaryLName2.Enabled = checkBoxSPAJBeneficiary2.Checked;
            dateTimeSPAJBeneficiary2.Enabled = checkBoxSPAJBeneficiary2.Checked;
            comboBoxSPAJBeneficiaryRs2.Enabled = checkBoxSPAJBeneficiary2.Checked;
        }

        private void checkBoxSPAJBeneficiary3_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSPAJBeneficiaryFName3.Enabled = checkBoxSPAJBeneficiary3.Checked;
            textBoxSPAJBeneficiaryLName3.Enabled = checkBoxSPAJBeneficiary3.Checked;
            dateTimeSPAJBeneficiary3.Enabled = checkBoxSPAJBeneficiary3.Checked;
            comboBoxSPAJBeneficiaryRs3.Enabled = checkBoxSPAJBeneficiary3.Checked;
        }

        private void checkBoxSPAJBeneficiary4_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSPAJBeneficiaryFName4.Enabled = checkBoxSPAJBeneficiary4.Checked;
            textBoxSPAJBeneficiaryLName4.Enabled = checkBoxSPAJBeneficiary4.Checked;
            dateTimeSPAJBeneficiary4.Enabled = checkBoxSPAJBeneficiary4.Checked;
            comboBoxSPAJBeneficiaryRs4.Enabled = checkBoxSPAJBeneficiary4.Checked;
        }

        private void checkBoxSPAJBeneficiary5_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSPAJBeneficiaryFName5.Enabled = checkBoxSPAJBeneficiary5.Checked;
            textBoxSPAJBeneficiaryLName5.Enabled = checkBoxSPAJBeneficiary5.Checked;
            dateTimeSPAJBeneficiary5.Enabled = checkBoxSPAJBeneficiary5.Checked;
            comboBoxSPAJBeneficiaryRs5.Enabled = checkBoxSPAJBeneficiary5.Checked;
        }

        private void checkBoxSPAJBeneficiary6_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSPAJBeneficiaryFName6.Enabled = checkBoxSPAJBeneficiary6.Checked;
            textBoxSPAJBeneficiaryLName6.Enabled = checkBoxSPAJBeneficiary6.Checked;
            dateTimeSPAJBeneficiary6.Enabled = checkBoxSPAJBeneficiary6.Checked;
            comboBoxSPAJBeneficiaryRs6.Enabled = checkBoxSPAJBeneficiary6.Checked;
        }

        private void comboBoxSPAJBeneficiaryRs1_SelectedValueChanged(object sender, EventArgs e)
        {
            textBoxSPAJBeneficiaryDetail1.Enabled = comboBoxSPAJBeneficiaryRs1.Text == "Other";
        }

        private void comboBoxSPAJBeneficiaryRs2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSPAJBeneficiaryDetail2.Enabled = comboBoxSPAJBeneficiaryRs2.Text == "Other";
        }

        private void comboBoxSPAJBeneficiaryRs3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSPAJBeneficiaryDetail3.Enabled = comboBoxSPAJBeneficiaryRs3.Text == "Other";
        }

        private void comboBoxSPAJBeneficiaryRs4_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSPAJBeneficiaryDetail4.Enabled = comboBoxSPAJBeneficiaryRs4.Text == "Other";
        }

        private void comboBoxSPAJBeneficiaryRs5_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSPAJBeneficiaryDetail5.Enabled = comboBoxSPAJBeneficiaryRs5.Text == "Other";
        }

        private void comboBoxSPAJBeneficiaryRs6_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSPAJBeneficiaryDetail6.Enabled = comboBoxSPAJBeneficiaryRs6.Text == "Other";
        }

        private void comboBoxSPAJPengajuanPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSPAJPengajuanPay.Text == "Credit Card")
            {
                labelPengajuanCCBankOther.Text = "Credit Card Num:";
                labelPengajuanCCExpDate.Text = "Exp. Date:";
                textBoxSPAJPengajuanCCBank.Enabled = true;
                textBoxSPAJPengajuanExpDate.Enabled = true;
            }
            else if (comboBoxSPAJPengajuanPay.Text == "Bank Transfer")
            {
                labelPengajuanCCBankOther.Text = "Account Number:";
                labelPengajuanCCExpDate.Text = "Account Name:";
                textBoxSPAJPengajuanCCBank.Enabled = true;
                textBoxSPAJPengajuanExpDate.Enabled = true;
            }
            else if (comboBoxSPAJPengajuanPay.Text == "Other")
            {
                labelPengajuanCCBankOther.Text = "Type of Payment:";
                labelPengajuanCCExpDate.Enabled = false;
                textBoxSPAJPengajuanCCBank.Enabled = true;
                textBoxSPAJPengajuanExpDate.Enabled = false;
            }
            else
            {
                labelPengajuanCCBankOther.Enabled = false;
                labelPengajuanCCExpDate.Enabled = false;
                textBoxSPAJPengajuanCCBank.Enabled = false;
                textBoxSPAJPengajuanExpDate.Enabled = false;
            }
        }

        private void comboBoxSPAJPengajuanCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSPAJPengajuanCurrency.Text == "Rupiah")
            {
                labelSPAJPengajuanExchRate.Enabled = false;
                textBoxSPAJPengajuanExchange.Enabled = false;
            }
            else if (comboBoxSPAJPengajuanCurrency.Text == "USD")
            {
                labelSPAJPengajuanExchRate.Enabled = true;
                textBoxSPAJPengajuanExchange.Enabled = true;
            }
        }

        private void checkBoxSPAJPengajuanPruHosp_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSPAJPengajuanPruHosp.Enabled = checkBoxSPAJPengajuanPruHosp.Checked;
        }

        private void checkBoxSPAJPengajuanPruPayor_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSPAJPengajuanPruPayor.Enabled = checkBoxSPAJPengajuanPruPayor.Checked;
            textBoxSPAJPengajuanPruPayorAmnt.Enabled = checkBoxSPAJPengajuanPruPayor.Checked;
        }

        private void checkBoxSPAJPengajuanPruCC_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSPAJPengajuanPruCC.Enabled = checkBoxSPAJPengajuanPruCC.Checked;
            textBoxSPAJPengajuanPruCCAmnt.Enabled = checkBoxSPAJPengajuanPruCC.Checked;
        }

        private void checkBoxSPAJPengajuanADD_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSPAJPengajuanPruADD.Enabled = checkBoxSPAJPengajuanADD.Checked;
            textBoxSPAJPengajuanPruADDAmnt.Enabled = checkBoxSPAJPengajuanADD.Checked;
        }

        private void checkBoxSPAJPengajuanPruMed_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSPAJPengajuanPruMed.Enabled = checkBoxSPAJPengajuanPruMed.Checked;
            textBoxSPAJPengajuanPruMedAmnt.Enabled = checkBoxSPAJPengajuanPruMed.Checked;
        }

        private void checkBoxSPAJPengajuanPruPPayor_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSPAJPengajuanPruPPayor.Enabled = checkBoxSPAJPengajuanPruPPayor.Checked;
            textBoxSPAJPengajuanPruPPayorAmnt.Enabled = checkBoxSPAJPengajuanPruPPayor.Checked;
        }

        private void buttonSPAJNewClear_Click(object sender, EventArgs e)
        {
            spaj = new SPAJ();
        }

        private void buttonSpouseIgnore_Click(object sender, EventArgs e)
        {
            buttonSpouseClear_Click(null, null);
            buttonSpouseAccept_Click(null, null);
        }

        private void buttonParentIgnore_Click(object sender, EventArgs e)
        {
            buttonParentClear_Click(null, null);
            buttonParentAccept_Click(null, null);
        }

        private void buttonSpouseClear_Click(object sender, EventArgs e)
        {
            clearTabPage(tabPageSpouseInfo);
        }

        private void buttonParentClear_Click(object sender, EventArgs e)
        {
            clearTabPage(tabPageParentInfo);
        }

        private void buttonPolisHolderClear_Click(object sender, EventArgs e)
        {
            clearTabPage(tabPagePolisHolder);
        }

        private void buttonAddressClear_Click(object sender, EventArgs e)
        {
            clearTabPage(tabPageAddressInfo);
        }

        private void buttonPengajuanClear_Click(object sender, EventArgs e)
        {
            clearTabPage(tabPagePengajuanInfo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearTabPage(tabPageBeneficiaryInfo);
        }

        private void clearTabPage(TabPage page)
        {
            foreach (Control c in page.Controls)
            {
                if (c is TextBox || c is ComboBox || c is DateTimePicker || c is CheckBox)
                {
                    if (c.Text != "0.00")
                    {
                        c.ResetText();
                    }
                }
            }
        }

        private void buttonSPAJEditLoad_Click(object sender, EventArgs e)
        {
            SPAJ spajFile = spajFiles.First(x => x.SPAJForm.SPAJNum == Int32.Parse(textBoxSPAJEditNumber.Text));
            tabControlEditSPAJ.Enabled = true;

            // SPAJ Form
            comboBoxSPAJEditType.SelectedIndex = comboBoxSPAJEditType.Items.IndexOf(spajFile.SPAJForm.SPAJType);
            textBoxSPAJEditAName.Text = spajFile.SPAJForm.AgentName;
            textBoxSPAJEditANumber.Text = spajFile.SPAJForm.AgentNum.ToString();
            textBoxEditPruFlyerNum.Text = spajFile.SPAJForm.PruFlyerNum.ToString();
            dateTimeSPAJEditSubmit.Text = spajFile.SPAJForm.SPAJSubmitDate;
            // Insurer Form
            textBoxSPAJEditInsrName.Text = spajFile.InsurerForm.InsurerName;
            textBoxSPAJEditInsrHeight.Text = spajFile.InsurerForm.InsurerHeight.ToString();
            textBoxSPAJEditInsrWeight.Text = spajFile.InsurerForm.InsurerWeight.ToString();
            textBoxSPAJEditInsrNextBday.Text = spajFile.InsurerForm.InsurerNextBday.ToString();
            radioButtonSPAJEditInsrSmoke.Checked = spajFile.InsurerForm.InsurerSmoke;
            comboBoxSPAJEditInsrGender.Text = spajFile.InsurerForm.InsurerGender;
            comboBoxSPAJEditInsrJobClass.Text = spajFile.InsurerForm.InsurerJobClass;
            comboBoxSPAJEditInsrMarriage.Text = spajFile.InsurerForm.InsurerMarried;
            dateTimeSPAJEditInsrDOB.Text = spajFile.InsurerForm.InsurerDOB;
            // Polis Form
            textBoxSPAJEditPolisName.Text = spajFile.PolisForm.PolisName;
            comboBoxSPAJEditPolisMarriage.Text = spajFile.PolisForm.PolisMarriage;
            comboBoxSPAJEditPolisGender.Text = spajFile.PolisForm.PolisGender;
            comboBoxSPAJEditPolisRs.Text = spajFile.PolisForm.PolisRs;
            dateTimeSPAJEditPolisDOB.Text = spajFile.PolisForm.PolisDOB;
            // Spouse Form
            textBoxSPAJEditSpouseName.Text = spajFile.SpouseForm.SpouseName;
            textBoxSPAJEditSpouseHeight.Text = spajFile.SpouseForm.SpouseHeight.ToString();
            textBoxSPAJEditSpouseNextBday.Text = spajFile.SpouseForm.SpouseNextBday.ToString();
            textBoxSPAJEditSpouseWeight.Text = spajFile.SpouseForm.SpouseWeight.ToString();
            comboBoxSPAJEditSpouseGender.Text = spajFile.SpouseForm.SpouseGender;
            comboBoxSPAJEditSpouseMarriage.Text = spajFile.SpouseForm.SpouseMarriage;
            radioButtonSPAJEditSpouseSmoke.Checked = spajFile.SpouseForm.SpouseSmoke;
            dateTimeSPAJEditSpouseDOB.Text = spajFile.SpouseForm.SpouseDOB;
            // Parent Form
            textBoxSPAJEditParentName.Text = spajFile.ParentForm.ParentName;
            textBoxSPAJEditParentHeight.Text = spajFile.ParentForm.ParentHeight.ToString();
            textBoxSPAJEditParentNextBday.Text = spajFile.ParentForm.ParentNextBday.ToString();
            textBoxSPAJEditParentWeight.Text = spajFile.ParentForm.ParentWeight.ToString();
            comboBoxSPAJEditParentGender.Text = spajFile.ParentForm.ParentGender;
            comboBoxSPAJEditParentMarriage.Text = spajFile.ParentForm.ParentMarriage;
            radioButtonSPAJEditParentSmoke.Checked = spajFile.ParentForm.ParentSmoke;
            dateTimeSPAJEditParentDOB.Text = spajFile.ParentForm.ParentDOB;
            // Address Form
            textBoxSPAJEditAddrCity.Text = spajFile.AddressForm.City;
            textBoxSPAJEditAddrEmail.Text = spajFile.AddressForm.Email;
            textBoxSPAJEditAddrHP.Text = spajFile.AddressForm.HPNumber.ToString();
            textBoxSPAJEditAddrAddress.Text = spajFile.AddressForm.Address;
            textBoxSPAJEditAddrOP.Text = spajFile.AddressForm.OPNumber.ToString();
            textBoxSPAJEditAddrZip.Text = spajFile.AddressForm.ZipCode.ToString();
            // Pengajuan Form
            textBoxSPAJEditPengajuanCCBank.Text = spajFile.PengajuanForm.PengajuanCCBankOther;
            textBoxSPAJEditPengajuanExchange.Text = spajFile.PengajuanForm.PengajuanExchange.ToString();
            textBoxSPAJEditPengajuanExpDate.Text = spajFile.PengajuanForm.PengajuanExpDate;
            textBoxSPAJEditPengajuanPremi.Text = spajFile.PengajuanForm.PengajuanPremi.ToString();
            textBoxSPAJEditPengajuanPremiTotal.Text = spajFile.PengajuanForm.PengajuanTotalPremi.ToString();
            textBoxSPAJEditPengajuanPrtanggung.Text = spajFile.PengajuanForm.PengajuanPertanggungan.ToString();
            textBoxSPAJEditPengajuanPruADD.Text = spajFile.PengajuanForm.PengajuanPruADDAmnt.ToString();
            textBoxSPAJEditPengajuanPruCC.Text = spajFile.PengajuanForm.PengajuanPruCCAmnt.ToString();
            textBoxSPAJEditPengajuanPRUMed.Text = spajFile.PengajuanForm.PengajuanPruMedAmnt.ToString();
            textBoxSPAJEditPengajuanPruPayor.Text = spajFile.PengajuanForm.PengajuanPruPayorAmnt.ToString();
            textBoxSPAJEditPengajuanPruPPayor.Text = spajFile.PengajuanForm.PengajuanPruPPayorAmnt.ToString();
            textBoxSPAJEditPengajuanPruSaver.Text = spajFile.PengajuanForm.PengajuanPruSaver.ToString();
            comboBoxSPAJEditPengajuanBasic.Text = spajFile.PengajuanForm.PengajuanBasic;
            comboBoxSPAJEditPengajuanCurrency.Text = spajFile.PengajuanForm.PengajuanCurrency;
            comboBoxSPAJEditPengajuanFreq.Text = spajFile.PengajuanForm.PengajuanFrequency;
            comboBoxSPAJEditPengajuanPay.Text = spajFile.PengajuanForm.PengajuanPay;
            comboBoxSPAJEditPengajuanPruADD.Text = spajFile.PengajuanForm.PengajuanPruADD;
            comboBoxSPAJEditPengajuanPruCC.Text = spajFile.PengajuanForm.PengajuanPruCC;
            comboBoxSPAJEditPengajuanPruHosp.Text = spajFile.PengajuanForm.PengajuanPruHosp.ToString();
            comboBoxSPAJEditPengajuanPRUMed.Text = spajFile.PengajuanForm.PengajuanPruMed;
            comboBoxSPAJEditPengajuanPruPayor.Text = spajFile.PengajuanForm.PengajuanPruPayor;
            comboBoxSPAJEditPengajuanPruPPayor.Text = spajFile.PengajuanForm.PengajuanPruPPayor;
            // TODO: Setup proper enabling/disabling behavior for Pengajuan Form here.
            // Beneficiary Form
            textBoxSPAJEditBeneficiaryFName1.Text = spajFile.BeneficiaryForm.Beneficiary1.FirstName;
            textBoxSPAJEditBeneficiaryLName1.Text = spajFile.BeneficiaryForm.Beneficiary1.LastName;
            textBoxSPAJEditBeneficiaryDetail1.Text = spajFile.BeneficiaryForm.Beneficiary1.Details;
            dateTimeSPAJEditBeneficiary1.Text = spajFile.BeneficiaryForm.Beneficiary1.Birthdate;
            comboBoxSPAJEditBeneficiaryRs1.Text = spajFile.BeneficiaryForm.Beneficiary1.Relationship;
            textBoxSPAJEditBeneficiaryFName2.Text = spajFile.BeneficiaryForm.Beneficiary2.FirstName;
            textBoxSPAJEditBeneficiaryLName2.Text = spajFile.BeneficiaryForm.Beneficiary2.LastName;
            textBoxSPAJEditBeneficiaryDetail2.Text = spajFile.BeneficiaryForm.Beneficiary2.Details;
            dateTimeSPAJEditBeneficiary2.Text = spajFile.BeneficiaryForm.Beneficiary2.Birthdate;
            comboBoxSPAJEditBeneficiaryRs2.Text = spajFile.BeneficiaryForm.Beneficiary2.Relationship;
            textBoxSPAJEditBeneficiaryFName3.Text = spajFile.BeneficiaryForm.Beneficiary3.FirstName;
            textBoxSPAJEditBeneficiaryLName3.Text = spajFile.BeneficiaryForm.Beneficiary3.LastName;
            textBoxSPAJEditBeneficiaryDetail3.Text = spajFile.BeneficiaryForm.Beneficiary3.Details;
            dateTimeSPAJEditBeneficiary3.Text = spajFile.BeneficiaryForm.Beneficiary3.Birthdate;
            comboBoxSPAJEditBeneficiaryRs3.Text = spajFile.BeneficiaryForm.Beneficiary3.Relationship;
            textBoxSPAJEditBeneficiaryFName4.Text = spajFile.BeneficiaryForm.Beneficiary4.FirstName;
            textBoxSPAJEditBeneficiaryLName4.Text = spajFile.BeneficiaryForm.Beneficiary4.LastName;
            textBoxSPAJEditBeneficiaryDetail4.Text = spajFile.BeneficiaryForm.Beneficiary4.Details;
            dateTimeSPAJEditBeneficiary4.Text = spajFile.BeneficiaryForm.Beneficiary4.Birthdate;
            comboBoxSPAJEditBeneficiaryRs4.Text = spajFile.BeneficiaryForm.Beneficiary4.Relationship;
            textBoxSPAJEditBeneficiaryFName5.Text = spajFile.BeneficiaryForm.Beneficiary5.FirstName;
            textBoxSPAJEditBeneficiaryLName5.Text = spajFile.BeneficiaryForm.Beneficiary5.LastName;
            textBoxSPAJEditBeneficiaryDetail5.Text = spajFile.BeneficiaryForm.Beneficiary5.Details;
            dateTimeSPAJEditBeneficiary5.Text = spajFile.BeneficiaryForm.Beneficiary5.Birthdate;
            comboBoxSPAJEditBeneficiaryRs5.Text = spajFile.BeneficiaryForm.Beneficiary5.Relationship;
            textBoxSPAJEditBeneficiaryFName6.Text = spajFile.BeneficiaryForm.Beneficiary6.FirstName;
            textBoxSPAJEditBeneficiaryLName6.Text = spajFile.BeneficiaryForm.Beneficiary6.LastName;
            textBoxSPAJEditBeneficiaryDetail6.Text = spajFile.BeneficiaryForm.Beneficiary6.Details;
            dateTimeSPAJEditBeneficiary6.Text = spajFile.BeneficiaryForm.Beneficiary6.Birthdate;
            comboBoxSPAJEditBeneficiaryRs6.Text = spajFile.BeneficiaryForm.Beneficiary6.Relationship;
            // TODO: Setup proper enabling/disabling behavior for Beneficiary Form here.
        }
    }
}
