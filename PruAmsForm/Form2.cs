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
        private SPAJ SpajFileUpd;
        private List<SPAJ> SPAJUpdate = new List<SPAJ>();
        private List<SPAJStatusChange> SPAJStatusChanges = new List<SPAJStatusChange>();
        private int addTabCurrentlySelected = 0;

        public Form2()
        {
            InitializeComponent();
            dataGridViewSPAJUpdate.DataSource = SPAJStatusChanges;
        }

        private void buttonSPAJClearBackMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// ADD SPAJ CONTROLS 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonInsInfoAccept_Click(object sender, EventArgs e)
        {


            try
            {
                // Insurer Info Form 
                string InsurerName = textBoxSPAJInsrName.Text;
                string InsurerGender = comboBoxSPAJInsrGender.Text;
                string InsurerDOB = dateTimeSPAJInsrDOB.Text;
                string InsurerMarried = comboBoxSPAJInsrMarriage.Text;
                int InsurerNextBday = NextBday(InsurerDOB);
                textBoxSPAJInsrNextBday.Text = InsurerNextBday.ToString();
                textBoxSPAJInsrNextBday.ReadOnly = true;

                int InsurerHeight = int.Parse(textBoxSPAJInsrHeight.Text);
                int InsurerWeight = int.Parse(textBoxSPAJInsrWeight.Text);
                bool InsurerSmoke = radioButtonSPAJInsrSmoke.Checked;
                string InsurerJobClass = comboBoxSPAJJobClass.Text;
                InsurerForm NewInsurer;

                NewInsurer = new InsurerForm(InsurerName, InsurerGender, InsurerDOB, InsurerMarried, InsurerNextBday,
                                             InsurerHeight, InsurerWeight, InsurerSmoke, InsurerJobClass);
                spaj.InsurerForm = NewInsurer;

                addTabNext();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill all required textboxes. ");
            }

        }

        private void buttonPolisHolderAccept_Click(object sender, EventArgs e)
        {
            try
            {
                string PolisName = textBoxSPAJPolisName.Text;
                string PolisGender = comboBoxSPAJPolisGender.Text;
                string PolisDOB = dateTimeSPAJPolisDOB.Text;
                string PolisMarriage = comboBoxSPAJPolisMarriage.Text;
                string PolisRs = comboBoxSPAJPolisRs.Text;

                if (PolisName == "" || PolisGender == "" || PolisDOB == "" || PolisMarriage == "" || PolisRs == "")
                {
                    throw new ArgumentException();
                }

                PolisForm NewPolis;


                NewPolis = new PolisForm(PolisName, PolisGender, PolisDOB, PolisMarriage, PolisRs);
                spaj.PolisForm = NewPolis;
                addTabNext();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill all required textboxes. ");
            }
        }

        private void buttonSpouseAccept_Click(object sender, EventArgs e)
        {
            try
            {
                string SpouseName = textBoxSPAJSpouseName.Text;
                string SpouseGender = comboBoxSPAJSpouseGender.Text;
                string SpouseDOB = dateTimeSPAJSpouseDOB.Text;
                string SpouseMarriage = comboBoxSPAJSpouseMarriage.Text;
                int SpouseNextBday = NextBday(SpouseDOB);
                textBoxSPAJSpouseNextBday.ReadOnly = true;
                textBoxSPAJSpouseNextBday.Text = SpouseNextBday.ToString("N0");
                int SpouseHeight = int.Parse(textBoxSPAJSpouseHeight.Text);
                int SpouseWeight = int.Parse(textBoxSPAJSpouseWeight.Text);
                bool SpouseSmoke = radioButtonSPAJSpouseSmoke.Checked;
                SpouseForm NewSpouse;

                NewSpouse = new SpouseForm(SpouseName, SpouseGender, SpouseDOB, SpouseMarriage, SpouseNextBday,
                    SpouseHeight, SpouseWeight, SpouseSmoke);
                spaj.SpouseForm = NewSpouse;

                addTabNext();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill all required textboxes. ");
            }
        }

        private void buttonParentAccept_Click(object sender, EventArgs e)
        {
            try
            {
                string ParentName = textBoxSPAJParentName.Text;
                string ParentGender = comboBoxSPAJParentGender.Text;
                string ParentDOB = dateTimeSPAJParentDOB.Text;
                string ParentMarriage = comboBoxSPAJParentMarriage.Text;
                int ParentNextBday = NextBday(ParentDOB);
                textBoxSPAJParentNextBday.ReadOnly = true;
                textBoxSPAJSpouseNextBday.Text = NextBday(ParentDOB).ToString("N0");
                int ParentHeight = int.Parse(textBoxSPAJParentHeight.Text);
                int ParentWeight = int.Parse(textBoxSPAJParentWeight.Text);
                bool ParentSmoke = radioButtonSPAJParentSmoke.Checked;
                ParentForm NewParent;

                NewParent = new ParentForm(ParentName, ParentGender, ParentDOB, ParentMarriage, ParentNextBday, ParentHeight, ParentWeight, ParentSmoke);
                spaj.ParentForm = NewParent;

                addTabNext();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill all required textboxes. ");
            }
        }

        private void buttonAddressAccept_Click(object sender, EventArgs e)
        {
            try
            {
                string Address = textBoxSPAJAddrAddress.Text;
                string AddrCity = textBoxSPAJAddrCity.Text;
                int AddrZipCode = int.Parse(textBoxSPAJAddrZip.Text);
                string AddrEmail = textBoxSPAJAddrEmail.Text;
                long AddrHPNumber = long.Parse(textBoxSPAJAddrHP.Text);
                long AddrOPNumber = long.Parse(textBoxSPAJAddrOP.Text);
                AddressForm NewAddress;

                NewAddress = new AddressForm(Address, AddrCity, AddrZipCode, AddrEmail, AddrHPNumber, AddrOPNumber);
                spaj.AddressForm = NewAddress;

                addTabNext();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill all required textboxes. ");
            }
        }

        private void buttonPengajuanAccept_Click(object sender, EventArgs e)
        {
            
            
                string PengajuanFrequency = comboBoxSPAJPengajuanFreq.Text;

                string PengajuanPay = comboBoxSPAJPengajuanPay.Text;
                string PengajuanCCBankOther = textBoxSPAJPengajuanCCBank.Text;
                string PengajuanExpDate = textBoxSPAJPengajuanExpDate.Text;

                string PengajuanCurrency = comboBoxSPAJPengajuanCurrency.Text;
                double PengajuanExchange = double.Parse(textBoxSPAJPengajuanExchange.Text);

                string PengajuanBasic = textBoxSPAJPengajuanBasic.Text;
                double PengajuanPertanggungan = double.Parse(textBoxSPAJPengajuanPrtanggung.Text) / BasicPertanggungan(PengajuanFrequency);
                textBoxSPAJPengajuanPrtanggung.Text = PengajuanPertanggungan.ToString(); 

                double PengajuanPruHosp = double.Parse(textBoxSPAJPengajuanPruHosp.Text) / BasicPertanggungan(PengajuanFrequency);
                textBoxSPAJPengajuanPruHosp.Text = PengajuanPruHosp.ToString(); 


                string PengajuanPruPayor = textBoxSPAJPengajuanPruPayorAmnt.Text;
                double PengajuanPruPayorAmnt = double.Parse(textBoxSPAJPengajuanPruPayorAmnt.Text) / BasicPertanggungan(PengajuanFrequency);
                textBoxSPAJPengajuanPruPayorAmnt.Text = PengajuanPruPayorAmnt.ToString(); 

                string PengajuanPruCC = textBoxSPAJPengajuanPruCC.Text;
                double PengajuanPruCCAmnt = double.Parse(textBoxSPAJPengajuanPruCCAmnt.Text) / BasicPertanggungan(PengajuanFrequency);
                textBoxSPAJPengajuanPruCC.Text = PengajuanPruCCAmnt.ToString(); 
            
                string PengajuanPruADD = textBoxSPAJPengajuanPruADD.Text;
                double PengajuanPruADDAmnt = double.Parse(textBoxSPAJPengajuanPruADDAmnt.Text) / BasicPertanggungan(PengajuanFrequency);
                textBoxSPAJPengajuanPruADDAmnt.Text = PengajuanPruADDAmnt.ToString(); 


                string PengajuanPruMed = textBoxSPAJPengajuanPruMed.Text;
                double PengajuanPruMedAmnt = double.Parse(textBoxSPAJPengajuanPruMedAmnt.Text) / BasicPertanggungan(PengajuanFrequency);
                textBoxSPAJPengajuanPruMedAmnt.Text = PengajuanPruMedAmnt.ToString(); 

                string PengajuanPruPPayor = textBoxSPAJPengajuanPruPPayor.Text;
                double PengajuanPruPPayorAmnt = double.Parse(textBoxSPAJPengajuanPruPPayorAmnt.Text) / BasicPertanggungan(PengajuanFrequency);
                textBoxSPAJPengajuanPruADDAmnt.Text = PengajuanPruPPayorAmnt.ToString();

                double PengajuanPremi = (PengajuanPertanggungan + PengajuanPruHosp + PengajuanPruPayorAmnt +
                    PengajuanPruCCAmnt + PengajuanPruADDAmnt + PengajuanPruMedAmnt + PengajuanPruPPayorAmnt);
                double PengajuanPruSaver = double.Parse(textBoxSPAJPengajuanPruSaver.Text) * 0.075;
                double PengajuanTotalPremi = (PengajuanPremi * PremiMultiply(PengajuanFrequency)) + PengajuanPruSaver;
                textBoxSPAJPengajuanPremi.Text = PengajuanPremi.ToString();
                textBoxSPAJPengajuanPruSaver.Text = PengajuanPruSaver.ToString();
                textBoxSPAJPengajuanPremiTotal.Text = PengajuanTotalPremi.ToString(); 
                


                PengajuanForm NewPengajuan;
                NewPengajuan = new PengajuanForm(PengajuanFrequency, PengajuanPay, PengajuanCCBankOther,
                PengajuanExpDate, PengajuanCurrency, PengajuanExchange, PengajuanBasic,
                PengajuanPertanggungan, PengajuanPruHosp, PengajuanPruPayor, PengajuanPruPayorAmnt,
                PengajuanPruCC, PengajuanPruCCAmnt, PengajuanPruADD, PengajuanPruADDAmnt,
                PengajuanPruMed, PengajuanPruMedAmnt, PengajuanPruPPayor, PengajuanPruPPayorAmnt,
                PengajuanPremi, PengajuanPruSaver, PengajuanTotalPremi);
                spaj.PengajuanForm = NewPengajuan;

            


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
           // try
           //{
                if (spajFiles.Any(x => x.SPAJForm.SPAJNum == int.Parse(textBoxSPAJNum.Text)))
                {
                    MessageBox.Show("SPAJ file with that number already exists.");
                }
                else
                {
                    // Add SPAJ Form 
                    long SPAJNum = long.Parse(textBoxSPAJNum.Text);
                    string SPAJType = textBoxSPAJInsType.Text;
                    string AgentName = textBoxSPAJAName.Text;
                    int AgentNum = int.Parse(textBoxSPAJANum.Text);
                    int PruFlyerNum = int.Parse(textBoxPRUFlyerNum.Text);
                    string SPAJSubmitDate = dateTimeSPAJSubmit.Text;
                    SPAJForm NewSPAJ; 

                   

                    NewSPAJ = new SPAJForm(SPAJNum, SPAJType, AgentName, AgentNum, PruFlyerNum, SPAJSubmitDate);
                    spaj.SPAJForm = NewSPAJ;



                    buttonSPAJNewCreate.Enabled = false;
                    buttonSPAJNewClear.Enabled = true;


                    // spaj now has all completed forms as its properties
                    spajFiles.Add(spaj);
                }
           // }
            
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Please fill all required textboxes. ");
            //}

            
        }

        // EDIT SPAJ 

        private void buttonSPAJEditLoad_Click(object sender, EventArgs e)
        {
            if (spajFiles.Any(x => x.SPAJForm.SPAJNum == Int32.Parse(textBoxSPAJEditNumber.Text)))
            {
                SPAJ spajFile = spajFiles.First(x => x.SPAJForm.SPAJNum == Int32.Parse(textBoxSPAJEditNumber.Text));
                tabControlEditSPAJ.Enabled = true;

                // SPAJ Form
                textBoxSPAJEditType.Text = spajFile.SPAJForm.SPAJType;
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
                textBoxSPAJEditPengajuanPrtanggung.Text = spajFile.PengajuanForm.PengajuanPertanggungan.ToString();
                textBoxSPAJEditPengajuanPruADDAmnt.Text = spajFile.PengajuanForm.PengajuanPruADDAmnt.ToString();
                textBoxSPAJEditPengajuanPruCCAmnt.Text = spajFile.PengajuanForm.PengajuanPruCCAmnt.ToString();
                textBoxSPAJEditPengajuanPRUMedAmnt.Text = spajFile.PengajuanForm.PengajuanPruMedAmnt.ToString();
                textBoxSPAJEditPengajuanPruPayorAmnt.Text = spajFile.PengajuanForm.PengajuanPruPayorAmnt.ToString();
                textBoxSPAJEditPengajuanPruPPayorAmnt.Text = spajFile.PengajuanForm.PengajuanPruPPayorAmnt.ToString();
                textBoxSPAJEditPengajuanBasic.Text = spajFile.PengajuanForm.PengajuanBasic;
                comboBoxSPAJEditPengajuanCurrency.Text = spajFile.PengajuanForm.PengajuanCurrency;
                comboBoxSPAJEditPengajuanFreq.Text = spajFile.PengajuanForm.PengajuanFrequency;
                comboBoxSPAJEditPengajuanPay.Text = spajFile.PengajuanForm.PengajuanPay;
                textBoxSPAJEditPengajuanPruADD.Text = spajFile.PengajuanForm.PengajuanPruADD;
                textBoxSPAJEditPengajuanPruCC.Text = spajFile.PengajuanForm.PengajuanPruCC;
                textBoxSPAJEditPengajuanPruHosp.Text = spajFile.PengajuanForm.PengajuanPruHosp.ToString();
                textBoxSPAJEditPengajuanPRUMed.Text = spajFile.PengajuanForm.PengajuanPruMed;
                textBoxSPAJEditPengajuanPruPayor.Text = spajFile.PengajuanForm.PengajuanPruPayor;
                textBoxSPAJEditPengajuanPruPPayor.Text = spajFile.PengajuanForm.PengajuanPruPPayor;

                textBoxSPAJEditPengajuanPremi.Text = spajFile.PengajuanForm.PengajuanPremi.ToString();
                textBoxSPAJEditPengajuanPruSaver.Text = spajFile.PengajuanForm.PengajuanPruSaver.ToString();
                textBoxSPAJEditPengajuanPremiTotal.Text = spajFile.PengajuanForm.PengajuanTotalPremi.ToString();

                // controls: 
                // currency : if idr disables exch rate 
                if (comboBoxSPAJEditPengajuanCurrency.Text == "Rupiah")
                { textBoxSPAJEditPengajuanExchange.Enabled = false; }
                //  pay: if other disables the exp date textbox. 
                if (comboBoxSPAJEditPengajuanPay.Text == "Other")
                { textBoxSPAJEditPengajuanExpDate.Enabled = false; }
                // checkboxes: if textbox and textbox amnt != "", checkbox.checked 
                if (textBoxSPAJEditPengajuanPruHosp.Text != "0.00")
                { checkBoxSPAJEditPengajuanPruHosp.Checked = true; }
                else
                {
                    checkBoxSPAJEditPengajuanPruHosp.Checked = false;
                    textBoxSPAJEditPengajuanPruHosp.Enabled = false;
                }

                if (textBoxSPAJEditPengajuanPruPayor.Text != "" && textBoxSPAJEditPengajuanPruPayorAmnt.Text != "0.00")
                { checkBoxSPAJEditPengajuanPruPPayor.Checked = true; }
                else
                {
                    checkBoxSPAJEditPengajuanPruPPayor.Checked = false;
                    textBoxSPAJEditPengajuanPruPayor.Enabled = false;
                    textBoxSPAJEditPengajuanPruPayorAmnt.Enabled = false;
                }

                if (textBoxSPAJEditPengajuanPruCC.Text != "" && textBoxSPAJEditPengajuanPruCCAmnt.Text != "0.00")
                { checkBoxSPAJEditPengajuanPruCC.Checked = true; }
                else
                {
                    checkBoxSPAJEditPengajuanPruCC.Checked = false;
                    textBoxSPAJEditPengajuanPruCC.Enabled = false;
                    textBoxSPAJEditPengajuanPruCCAmnt.Enabled = false;
                }

                if (textBoxSPAJEditPengajuanPruADD.Text != "" && textBoxSPAJEditPengajuanPruADDAmnt.Text != "0.00")
                { checkBoxSPAJEditPengajuanADD.Checked = true; }
                else
                {
                    checkBoxSPAJEditPengajuanADD.Checked = false;
                    textBoxSPAJEditPengajuanPruADD.Enabled = false;
                    textBoxSPAJEditPengajuanPruADDAmnt.Enabled = false;
                }
                if (textBoxSPAJEditPengajuanPRUMed.Text != "" && textBoxSPAJEditPengajuanPRUMedAmnt.Text != "0.00")
                { checkBoxSPAJEditPengajuanPRUMed.Checked = true; }
                else
                {
                    checkBoxSPAJEditPengajuanPRUMed.Checked = false;
                    textBoxSPAJEditPengajuanPRUMed.Enabled = false;
                    textBoxSPAJEditPengajuanPRUMedAmnt.Enabled = false;
                }
                if (textBoxSPAJEditPengajuanPruPPayor.Text != "" && textBoxSPAJEditPengajuanPruPPayor.Text != "0.00")
                { checkBoxSPAJEditPengajuanPruPPayor.Checked = true; }
                else
                {
                    checkBoxSPAJEditPengajuanPruPPayor.Checked = false;
                    textBoxSPAJEditPengajuanPruPPayor.Enabled = false;
                    textBoxSPAJEditPengajuanPruPPayorAmnt.Enabled = false;
                }
                // premi + total premi is readonly, prusaver only enabled if frequency == berkala || tunggal. 
                textBoxSPAJEditPengajuanPremi.ReadOnly = true;
                textBoxSPAJEditPengajuanPruSaver.ReadOnly = true;
                textBoxSPAJEditPengajuanPremiTotal.ReadOnly = true;
                if (comboBoxSPAJEditPengajuanFreq.Text == "Berkala" || comboBoxSPAJEditPengajuanFreq.Text == "Tunggal")
                { textBoxSPAJEditPengajuanPruSaver.ReadOnly = false; }


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
                // Enabling/disabling behavior for Beneficiary Form
                if (textBoxSPAJEditBeneficiaryFName1.Text != "")
                    checkBoxSPAJEditBeneficiary1.Checked = true;
                if (textBoxSPAJEditBeneficiaryFName2.Text != "")
                    checkBoxSPAJEditBeneficiary2.Checked = true;
                if (textBoxSPAJEditBeneficiaryFName3.Text != "")
                    checkBoxSPAJEditBeneficiary2.Checked = true;
                if (textBoxSPAJEditBeneficiaryFName4.Text != "")
                    checkBoxSPAJEditBeneficiary2.Checked = true;
                if (textBoxSPAJEditBeneficiaryFName5.Text != "")
                    checkBoxSPAJEditBeneficiary2.Checked = true;
                if (textBoxSPAJEditBeneficiaryFName6.Text != "")
                    checkBoxSPAJEditBeneficiary2.Checked = true;
            }
            else
            {
                MessageBox.Show("SPAJ file of that number does not exist.");
            }
        }



        // UPDATE SPAJ 

        private void buttonSPAJUpdateLoad_Click(object sender, EventArgs e)
        {
            if (SPAJUpdate.Any(x => x.SPAJForm.SPAJNum == Int32.Parse(textBoxSPAJUpdateNumber.Text)))
            {
                SpajFileUpd = SPAJUpdate.First(x => x.SPAJForm.SPAJNum == Int32.Parse(textBoxSPAJUpdateNumber.Text));

                textBoxSPAJUpdateInsName.Text = SpajFileUpd.InsurerForm.InsurerName;
                textBoxSPAJUpdateInsDOB.Text = SpajFileUpd.InsurerForm.InsurerDOB;
                comboBoxSPAJUpdateStatus.Text = SpajFileUpd.UpdateForm.UpdateStatus;
                dateTimeSPAJUpdateInforce.Text = SpajFileUpd.UpdateForm.UpdateInsDOB;
                textBoxSPAJUpdatePolisNum.Text = SpajFileUpd.UpdateForm.UpdatePolis;
                textBoxSPAJUpdateInfo.Text = SpajFileUpd.UpdateForm.UpdateInfo;

            }
            else
            {
                MessageBox.Show("No updates for given SPAJ file number.");
            }
        }

        private void comboBoxSPAJUpdateStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string UpdateStatus = comboBoxSPAJUpdateStatus.Text;
            bool shouldShow = UpdateStatus == "Inforce";
            labelSPAJInforce.Enabled = shouldShow;
            labelSPAJInforcePolis.Enabled = shouldShow;
            dateTimeSPAJUpdateInforce.Enabled = shouldShow;
            textBoxSPAJUpdatePolisNum.Enabled = shouldShow;
        }

        private void buttonSPAJUpdateUpdate_Click(object sender, EventArgs e)
        {
            if (SpajFileUpd != null)
            {
                string UpdateInsName = textBoxSPAJUpdateInsName.Text;
                string UpdateInsDOB = textBoxSPAJUpdateInsDOB.Text;
                string UpdateStatus = comboBoxSPAJUpdateStatus.Text;
                string UpdateDate = dateTimeSPAJUpdateInforce.Text;
                string UpdatePolis = textBoxSPAJUpdatePolisNum.Text;
                string UpdateInfo = textBoxSPAJUpdateInfo.Text;

                if (UpdateStatus != SpajFileUpd.UpdateForm.UpdateStatus)
                {
                    SPAJStatusChanges.Add(new SPAJStatusChange { DateTime = DateTime.Now.ToString(), StatusChangedTo = UpdateStatus });
                }

                UpdateForm NewUpdate;
                NewUpdate = new UpdateForm(UpdateInsName, UpdateInsDOB, UpdateStatus, UpdateDate, UpdatePolis, UpdateInfo);
                SpajFileUpd.UpdateForm = NewUpdate;
            }
            else
            {
                MessageBox.Show("No SPAJ file has been loaded.");
            }

        }

        // PRIVATE METHODS 

        private int NextBday(string DOB)
        {
            DateTime Today = DateTime.Today;
            DateTime Bday = Convert.ToDateTime(DOB);

            return (Today.Year - Bday.Year) + 1;


        }

        private int BasicPertanggungan(string Frequency)
        {
            if (Frequency == "Monthly (Bulanan)")
            { return 12; }
            else if (Frequency == "Quarterly (3 Bulan)")
            { return 4; }
            else if (Frequency == "Half Yearly (Semesteran)")
            { return 2; }
            else if (Frequency == "Yearly (Tahunan)" || Frequency == "Tunggal")
            { return 1; }
            else // Berkala
            { return 11; }
        }

        private double PremiMultiply(string Frequency)
        {
            if (Frequency == "Monthly (Bulanan)" || Frequency == "Berkala")
            { return 12; }
            else if (Frequency == "Quarterly (3 Bulan)")
            { return 4; }
            else if (Frequency == "Half Yearly (Semesteran)")
            { return 2; }
            else if (Frequency == "Yearly (Tahunan)")
            { return 1; }
            else // Tunggal
            { return 0.075; }
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

        private void comboBoxSPAJPengajuanFreq_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enable = comboBoxSPAJPengajuanFreq.Text == "Berkala" || comboBoxSPAJPengajuanFreq.Text == "Tunggal";
            textBoxSPAJPengajuanPruSaver.Enabled = !enable;
            
            textBoxSPAJPengajuanPremi.ReadOnly = enable;
            textBoxSPAJPengajuanPremiTotal.ReadOnly = enable; 
            
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
            labelSPAJPengajuanPruHosp.Enabled = true; 
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
            foreach (TabPage page in tabControlAddSPAJ.TabPages)
            {
                clearTabPage(page);
            }
            clearTabPage(tabPageSPAJAdd);
        }

        private void buttonSpouseIgnore_Click(object sender, EventArgs e)
        {
            spaj.SpouseForm = new SpouseForm();
            addTabNext();
        }

        private void addTabNext()
        {
            addTabCurrentlySelected++;
            tabControlAddSPAJ.SelectTab(addTabCurrentlySelected);
        }

        private void buttonParentIgnore_Click(object sender, EventArgs e)
        {
            spaj.ParentForm = new ParentForm();
            addTabNext();
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

        private void buttonBeneficiaryClear_Click(object sender, EventArgs e)
        {
            clearTabPage(tabPageBeneficiaryInfo);
            checkBoxSPAJBeneficiary1.Checked = true;
        }

        private void clearTabPage(TabPage page)
        {
            foreach (Control c in page.Controls)
            {
                if (c is TextBox || c is ComboBox || c is DateTimePicker)
                {
                    if (c.Text != "0.00")
                    {
                        c.ResetText();
                    }
                }
                else if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
            }
        }

        // Edit SPAJPengajuan: Frequency 
        private void comboBoxSPAJEditPengajuanFreq_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSPAJEditPengajuanCurrency.Text == "Berkala" || comboBoxSPAJEditPengajuanFreq.Text == "Tunggal")
            { textBoxSPAJEditPengajuanPruSaver.Enabled = false; }
            else
            {
                textBoxSPAJEditPengajuanPremi.ReadOnly = true;
                textBoxSPAJEditPengajuanPremiTotal.ReadOnly = true;
            }

            int Divide = BasicPertanggungan(comboBoxSPAJEditPengajuanFreq.Text);

            float Pertanggung = float.Parse(textBoxSPAJEditPengajuanPrtanggung.Text);
            textBoxSPAJEditPengajuanPrtanggung.Text = (Pertanggung / Divide).ToString();

            float PruHosp = float.Parse(textBoxSPAJEditPengajuanPruHosp.Text);
            textBoxSPAJEditPengajuanPruHosp.Text = (PruHosp / Divide).ToString();

            float PruPayor = float.Parse(textBoxSPAJEditPengajuanPruPayorAmnt.Text);
            textBoxSPAJEditPengajuanPruPayorAmnt.Text = (PruPayor / Divide).ToString();

            float PruCC = float.Parse(textBoxSPAJEditPengajuanPruCCAmnt.Text);
            textBoxSPAJEditPengajuanPruCCAmnt.Text = (PruCC / Divide).ToString();

            float PruADD = float.Parse(textBoxSPAJEditPengajuanPruADDAmnt.Text);
            textBoxSPAJEditPengajuanPruADDAmnt.Text = (PruADD / Divide).ToString();

            float PruMed = float.Parse(textBoxSPAJEditPengajuanPRUMedAmnt.Text);
            textBoxSPAJEditPengajuanPRUMedAmnt.Text = (PruMed / Divide).ToString();

            float PruPPayor = float.Parse(textBoxSPAJEditPengajuanPruPPayorAmnt.Text);
            textBoxSPAJEditPengajuanPruPPayorAmnt.Text = (PruPPayor / Divide).ToString();

            // code below to be transferred to the EditPengajuanAccept button 

            textBoxSPAJEditPengajuanPremi.Text = calculatePremi().ToString();

            float PruSaver = float.Parse(textBoxSPAJEditPengajuanPruSaver.Text);
            textBoxSPAJEditPengajuanPruSaver.Text = (PruSaver * 0.0075).ToString();

            float PremiMulti = float.Parse(textBoxSPAJEditPengajuanPremi.Text);
            textBoxSPAJEditPengajuanPremiTotal.Text = (PremiMulti * PremiMultiply(comboBoxSPAJEditPengajuanFreq.Text)).ToString() 
                + textBoxSPAJEditPengajuanPruSaver.Text; 

        }

        private float calculatePremi()
        {
            return float.Parse(textBoxSPAJEditPengajuanPrtanggung.Text) + float.Parse(textBoxSPAJEditPengajuanPruHosp.Text) +
                                       float.Parse(textBoxSPAJEditPengajuanPruPayorAmnt.Text) + float.Parse(textBoxSPAJEditPengajuanPruCCAmnt.Text) + float.Parse(textBoxSPAJEditPengajuanPruADDAmnt.Text) +
                                       float.Parse(textBoxSPAJEditPengajuanPRUMedAmnt.Text) + float.Parse(textBoxSPAJEditPengajuanPruPPayorAmnt.Text);
        }

        private void textBoxSPAJEditPengajuanPrtanggung_TextChanged(object sender, EventArgs e)
        {
            int Divide = BasicPertanggungan(comboBoxSPAJEditPengajuanFreq.Text);
            float a = float.Parse(textBoxSPAJEditPengajuanPrtanggung.Text);
            textBoxSPAJEditPengajuanPrtanggung.Text = (a / Divide).ToString();

            textBoxSPAJEditPengajuanPremi.Text = calculatePremi().ToString();

            float PruSaver = float.Parse(textBoxSPAJEditPengajuanPruSaver.Text);
            textBoxSPAJEditPengajuanPruSaver.Text = (PruSaver * 0.0075).ToString();

            float PremiMulti = float.Parse(textBoxSPAJEditPengajuanPremi.Text);
            textBoxSPAJEditPengajuanPremiTotal.Text = (PremiMulti * PremiMultiply(comboBoxSPAJEditPengajuanFreq.Text)).ToString()
                + textBoxSPAJEditPengajuanPruSaver.Text;


        }



        private void textBoxSPAJEditPengajuanPruHosp_TextChanged(object sender, EventArgs e)
        {
            int Divide = BasicPertanggungan(comboBoxSPAJEditPengajuanFreq.Text);
            float a = float.Parse(textBoxSPAJEditPengajuanPruHosp.Text);
            textBoxSPAJEditPengajuanPruHosp.Text = (a / Divide).ToString();

            textBoxSPAJEditPengajuanPremi.Text = calculatePremi().ToString();

            float PruSaver = float.Parse(textBoxSPAJEditPengajuanPruSaver.Text);
            textBoxSPAJEditPengajuanPruSaver.Text = (PruSaver * 0.0075).ToString();

            float PremiMulti = float.Parse(textBoxSPAJEditPengajuanPremi.Text);
            textBoxSPAJEditPengajuanPremiTotal.Text = (PremiMulti * PremiMultiply(comboBoxSPAJEditPengajuanFreq.Text)).ToString()
                + textBoxSPAJEditPengajuanPruSaver.Text;


        }

        private void textBoxSPAJEditPengajuanPruPayorAmnt_TextChanged(object sender, EventArgs e)
        {
            int Divide = BasicPertanggungan(comboBoxSPAJEditPengajuanFreq.Text);
            float a = float.Parse(textBoxSPAJEditPengajuanPruPayorAmnt.Text);
            textBoxSPAJEditPengajuanPruPayorAmnt.Text = (a / Divide).ToString();

            textBoxSPAJEditPengajuanPremi.Text = calculatePremi().ToString();

            float PruSaver = float.Parse(textBoxSPAJEditPengajuanPruSaver.Text);
            textBoxSPAJEditPengajuanPruSaver.Text = (PruSaver * 0.0075).ToString();

            float PremiMulti = float.Parse(textBoxSPAJEditPengajuanPremi.Text);
            textBoxSPAJEditPengajuanPremiTotal.Text = (PremiMulti * PremiMultiply(comboBoxSPAJEditPengajuanFreq.Text)).ToString()
                + textBoxSPAJEditPengajuanPruSaver.Text;

        }

        private void textBoxSPAJEditPengajuanPruCCAmnt_TextChanged(object sender, EventArgs e)
        {
            int Divide = BasicPertanggungan(comboBoxSPAJEditPengajuanFreq.Text);
            float a = float.Parse(textBoxSPAJEditPengajuanPruCCAmnt.Text);
            textBoxSPAJEditPengajuanPruCCAmnt.Text = (a / Divide).ToString();

            textBoxSPAJEditPengajuanPremi.Text = calculatePremi().ToString();

            float PruSaver = float.Parse(textBoxSPAJEditPengajuanPruSaver.Text);
            textBoxSPAJEditPengajuanPruSaver.Text = (PruSaver * 0.0075).ToString();

            float PremiMulti = float.Parse(textBoxSPAJEditPengajuanPremi.Text);
            textBoxSPAJEditPengajuanPremiTotal.Text = (PremiMulti * PremiMultiply(comboBoxSPAJEditPengajuanFreq.Text)).ToString()
                + textBoxSPAJEditPengajuanPruSaver.Text;

        }

        private void textBoxSPAJEditPengajuanPruADDAmnt_TextChanged(object sender, EventArgs e)
        {
            int Divide = BasicPertanggungan(comboBoxSPAJEditPengajuanFreq.Text);
            float a = float.Parse(textBoxSPAJEditPengajuanPruADDAmnt.Text);
            textBoxSPAJEditPengajuanPruADDAmnt.Text = (a / Divide).ToString();

            textBoxSPAJEditPengajuanPremi.Text = calculatePremi().ToString();

            float PruSaver = float.Parse(textBoxSPAJEditPengajuanPruSaver.Text);
            textBoxSPAJEditPengajuanPruSaver.Text = (PruSaver * 0.0075).ToString();

            float PremiMulti = float.Parse(textBoxSPAJEditPengajuanPremi.Text);
            textBoxSPAJEditPengajuanPremiTotal.Text = (PremiMulti * PremiMultiply(comboBoxSPAJEditPengajuanFreq.Text)).ToString()
                + textBoxSPAJEditPengajuanPruSaver.Text;

        }

        private void textBoxSPAJEditPengajuanPRUMedAmnt_TextChanged(object sender, EventArgs e)
        {
            int Divide = BasicPertanggungan(comboBoxSPAJEditPengajuanFreq.Text);
            float a = float.Parse(textBoxSPAJEditPengajuanPRUMedAmnt.Text);
            textBoxSPAJEditPengajuanPRUMedAmnt.Text = (a / Divide).ToString();

            textBoxSPAJEditPengajuanPremi.Text = calculatePremi().ToString();

            float PruSaver = float.Parse(textBoxSPAJEditPengajuanPruSaver.Text);
            textBoxSPAJEditPengajuanPruSaver.Text = (PruSaver * 0.0075).ToString();

            float PremiMulti = float.Parse(textBoxSPAJEditPengajuanPremi.Text);
            textBoxSPAJEditPengajuanPremiTotal.Text = (PremiMulti * PremiMultiply(comboBoxSPAJEditPengajuanFreq.Text)).ToString()
                + textBoxSPAJEditPengajuanPruSaver.Text;

        }

        private void textBoxSPAJEditPengajuanPruPPayorAmnt_TextChanged(object sender, EventArgs e)
        {
            int Divide = BasicPertanggungan(comboBoxSPAJEditPengajuanFreq.Text);
            float a = float.Parse(textBoxSPAJEditPengajuanPruPPayorAmnt.Text);
            textBoxSPAJEditPengajuanPruPPayorAmnt.Text = (a / Divide).ToString();

            textBoxSPAJEditPengajuanPremi.Text = calculatePremi().ToString();

            float PruSaver = float.Parse(textBoxSPAJEditPengajuanPruSaver.Text);
            textBoxSPAJEditPengajuanPruSaver.Text = (PruSaver * 0.0075).ToString();

            float PremiMulti = float.Parse(textBoxSPAJEditPengajuanPremi.Text);
            textBoxSPAJEditPengajuanPremiTotal.Text = (PremiMulti * PremiMultiply(comboBoxSPAJEditPengajuanFreq.Text)).ToString()
                + textBoxSPAJEditPengajuanPruSaver.Text;


        }





        // Edit SPAJPengajuan: Pay 

        private void comboBoxSPAJEditPengajuanPay_TextUpdate(object sender, EventArgs e)
        {
            if (comboBoxSPAJEditPengajuanPay.Text == "Credit Card")
            {
                labelSPAJEditPengajuanCCBankOther.Text = "Credit Card Num:";
                labelSPAJEditPengajuanCCExpDate.Text = "Exp. Date:";
                textBoxSPAJEditPengajuanCCBank.Enabled = true;
                textBoxSPAJEditPengajuanExpDate.Enabled = true;
            }
            else if (comboBoxSPAJPengajuanPay.Text == "Bank Transfer")
            {
                labelSPAJEditPengajuanCCBankOther.Text = "Account Number:";
                labelSPAJEditPengajuanCCExpDate.Text = "Account Name:";
                textBoxSPAJEditPengajuanCCBank.Enabled = true;
                textBoxSPAJEditPengajuanExpDate.Enabled = true;
            }
            else if (comboBoxSPAJPengajuanPay.Text == "Other")
            {
                labelSPAJEditPengajuanCCBankOther.Text = "Type of Payment:";
                labelSPAJEditPengajuanCCExpDate.Enabled = false;
                textBoxSPAJEditPengajuanCCBank.Enabled = true;
                textBoxSPAJEditPengajuanExpDate.Enabled = false;
            }
            else
            {
                labelSPAJEditPengajuanCCBankOther.Enabled = false;
                labelSPAJEditPengajuanCCExpDate.Enabled = false;
                textBoxSPAJEditPengajuanCCBank.Enabled = false;
                textBoxSPAJEditPengajuanExpDate.Enabled = false;
            }
        }
        // Edit SPAJPengajuan : Currency 
        private void comboBoxSPAJEditPengajuanCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSPAJEditPengajuanCurrency.Text == "Rupiah")
            {
                labelSPAJEditPengajuanExRate.Enabled = false;
                textBoxSPAJEditPengajuanExchange.Enabled = false;
            }
            else if (comboBoxSPAJEditPengajuanCurrency.Text == "USD")
            {
                labelSPAJEditPengajuanExRate.Enabled = true;
                textBoxSPAJEditPengajuanExchange.Enabled = true;
            }
        }

        // Edit SPAJPengajuan: Beneficiary 

        private void checkBoxSPAJEditBeneficiary1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSPAJEditBeneficiaryDetail1.Enabled = checkBoxSPAJEditBeneficiary1.Checked;
            textBoxSPAJEditBeneficiaryFName1.Enabled = checkBoxSPAJEditBeneficiary1.Checked;
            textBoxSPAJEditBeneficiaryLName1.Enabled = checkBoxSPAJEditBeneficiary1.Checked;
            dateTimeSPAJEditBeneficiary1.Enabled = checkBoxSPAJEditBeneficiary1.Checked;
            comboBoxSPAJEditBeneficiaryRs1.Enabled = checkBoxSPAJEditBeneficiary1.Checked;
        }

        private void checkBoxSPAJEditBeneficiary2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSPAJEditBeneficiaryDetail2.Enabled = checkBoxSPAJEditBeneficiary2.Checked;
            textBoxSPAJEditBeneficiaryFName2.Enabled = checkBoxSPAJEditBeneficiary2.Checked;
            textBoxSPAJEditBeneficiaryLName2.Enabled = checkBoxSPAJEditBeneficiary2.Checked;
            dateTimeSPAJEditBeneficiary2.Enabled = checkBoxSPAJEditBeneficiary2.Checked;
            comboBoxSPAJEditBeneficiaryRs2.Enabled = checkBoxSPAJEditBeneficiary2.Checked;
        }

        private void checkBoxSPAJEditBeneficiary3_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSPAJEditBeneficiaryDetail3.Enabled = checkBoxSPAJEditBeneficiary3.Checked;
            textBoxSPAJEditBeneficiaryFName3.Enabled = checkBoxSPAJEditBeneficiary3.Checked;
            textBoxSPAJEditBeneficiaryLName3.Enabled = checkBoxSPAJEditBeneficiary3.Checked;
            dateTimeSPAJEditBeneficiary3.Enabled = checkBoxSPAJEditBeneficiary3.Checked;
            comboBoxSPAJEditBeneficiaryRs3.Enabled = checkBoxSPAJEditBeneficiary3.Checked;
        }

        private void checkBoxSPAJEditBeneficiary4_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSPAJEditBeneficiaryDetail4.Enabled = checkBoxSPAJEditBeneficiary4.Checked;
            textBoxSPAJEditBeneficiaryFName4.Enabled = checkBoxSPAJEditBeneficiary4.Checked;
            textBoxSPAJEditBeneficiaryLName4.Enabled = checkBoxSPAJEditBeneficiary4.Checked;
            dateTimeSPAJEditBeneficiary4.Enabled = checkBoxSPAJEditBeneficiary4.Checked;
            comboBoxSPAJEditBeneficiaryRs4.Enabled = checkBoxSPAJEditBeneficiary4.Checked;
        }

        private void checkBoxSPAJEditBeneficiary5_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSPAJEditBeneficiaryDetail5.Enabled = checkBoxSPAJEditBeneficiary5.Checked;
            textBoxSPAJEditBeneficiaryFName5.Enabled = checkBoxSPAJEditBeneficiary5.Checked;
            textBoxSPAJEditBeneficiaryLName5.Enabled = checkBoxSPAJEditBeneficiary5.Checked;
            dateTimeSPAJEditBeneficiary5.Enabled = checkBoxSPAJEditBeneficiary5.Checked;
            comboBoxSPAJEditBeneficiaryRs5.Enabled = checkBoxSPAJEditBeneficiary5.Checked;
        }

        private void checkBoxSPAJEditBeneficiary6_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSPAJEditBeneficiaryDetail6.Enabled = checkBoxSPAJEditBeneficiary6.Checked;
            textBoxSPAJEditBeneficiaryFName6.Enabled = checkBoxSPAJEditBeneficiary6.Checked;
            textBoxSPAJEditBeneficiaryLName6.Enabled = checkBoxSPAJEditBeneficiary6.Checked;
            dateTimeSPAJEditBeneficiary6.Enabled = checkBoxSPAJEditBeneficiary6.Checked;
            comboBoxSPAJEditBeneficiaryRs6.Enabled = checkBoxSPAJEditBeneficiary6.Checked;
        }

        private void buttonSPAJUpdateClear_Click(object sender, EventArgs e)
        {
            textBoxSPAJUpdateNumber.Text = SpajFileUpd.SPAJForm.SPAJNum.ToString();
            buttonSPAJUpdateLoad_Click(null, null);
        }

        private void buttonSPAJEditInsrClear_Click(object sender, EventArgs e)
        {
            clearTabPage(tabPageEditInsInfo);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            clearTabPage(tabPageEditPolisInfo);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            clearTabPage(tabPageEditSpouseInfo);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            clearTabPage(tabPageEditParentInfo);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            clearTabPage(tabPageEditAddrInfo);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            clearTabPage(tabPageEditPengajuanInfo);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            clearTabPage(tabPageEditBeneficiaryInfo);
        }



        // Edit SPAJPengajuan: Additional 

        private void checkBoxSPAJEditPengajuanPruHosp_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSPAJEditPengajuanPruHosp.Enabled = checkBoxSPAJEditPengajuanPruHosp.Checked;
        }

        private void checkBoxSPAJEditPengajuanPruPayor_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSPAJEditPengajuanPruPayor.Enabled = checkBoxSPAJEditPengajuanPruPayor.Checked;
            textBoxSPAJEditPengajuanPruPayorAmnt.Enabled = checkBoxSPAJEditPengajuanPruPayor.Checked;
        }

        private void checkBoxSPAJEditPengajuanPruCC_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSPAJEditPengajuanPruCC.Enabled = checkBoxSPAJEditPengajuanPruCC.Checked;
            textBoxSPAJEditPengajuanPruCCAmnt.Enabled = checkBoxSPAJEditPengajuanPruCC.Checked;
        }

        private void checkBoxSPAJEditPengajuanADD_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSPAJEditPengajuanPruADD.Enabled = checkBoxSPAJEditPengajuanADD.Checked;
            textBoxSPAJEditPengajuanPruADDAmnt.Enabled = checkBoxSPAJEditPengajuanADD.Checked;
        }

        private void checkBoxSPAJEditPengajuanPRUMed_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSPAJEditPengajuanPRUMed.Enabled = checkBoxSPAJEditPengajuanPRUMed.Checked;
            textBoxSPAJEditPengajuanPRUMedAmnt.Enabled = checkBoxSPAJEditPengajuanPRUMed.Checked;
        }

        private void checkBoxSPAJEditPengajuanPruPPayor_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSPAJEditPengajuanPruPPayor.Enabled = checkBoxSPAJEditPengajuanPruPPayor.Checked;
            textBoxSPAJEditPengajuanPruPPayorAmnt.Enabled = checkBoxSPAJEditPengajuanPruPPayor.Checked;
        }

        // Edit SPAJ Insurer, Spouse, Parent Next Bday 

        private void dateTimeSPAJEditInsrDOB_ValueChanged(object sender, EventArgs e)
        {
            textBoxSPAJEditInsrNextBday.Text = (NextBday(dateTimeSPAJEditInsrDOB.Text)).ToString(); 
        }

        private void dateTimeSPAJEditSpouseDOB_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxSPAJEditSpouseNextBday.Text = (NextBday(dateTimeSPAJEditSpouseDOB.Text)).ToString();
            } catch (Exception ex)
            {
                
            }
        }

        private void dateTimeSPAJEditParentDOB_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxSPAJEditParentNextBday.Text = (NextBday(dateTimeSPAJEditParentDOB.Text)).ToString();
            } catch (Exception ex)
            {

            }
        }

        private void buttonInsInfoEdit_Click(object sender, EventArgs e)
        {
            tabControlEditSPAJ.SelectTab(tabPageEditPolisInfo);
        }

        private void buttonPolisInfoEdit_Click(object sender, EventArgs e)
        {
            tabControlEditSPAJ.SelectTab(tabPageEditSpouseInfo);
        }

        private void buttonSpouseEdit_Click(object sender, EventArgs e)
        {
            tabControlEditSPAJ.SelectTab(tabPageEditParentInfo); 
        }

        private void buttonParentEdit_Click(object sender, EventArgs e)
        {
            tabControlEditSPAJ.SelectTab(tabPageEditAddrInfo);
        }

        private void buttonAddressEdit_Click(object sender, EventArgs e)
        {
            tabControlEditSPAJ.SelectTab(tabPageEditPengajuanInfo);
        }

        private void buttonPengajuanEdit_Click(object sender, EventArgs e)
        {
            tabControlEditSPAJ.SelectTab(tabPageEditBeneficiaryInfo);
        }

        private void buttonBeneficiaryEdit_Click(object sender, EventArgs e)
        {
            buttonSPAJEditUpdate.Enabled = true; 
        }

        private void buttonSPAJEditUpdate_Click(object sender, EventArgs e)
        {
            SPAJ spajFile = spajFiles.First(x => x.SPAJForm.SPAJNum == Int32.Parse(textBoxSPAJEditNumber.Text));

            // SPAJ Form
            spajFile.SPAJForm.SPAJType = textBoxSPAJEditType.Text;
            spajFile.SPAJForm.AgentName = textBoxSPAJEditAName.Text;
            spajFile.SPAJForm.AgentNum = int.Parse(textBoxSPAJEditANumber.Text);
            spajFile.SPAJForm.PruFlyerNum = int.Parse(textBoxEditPruFlyerNum.Text);
            spajFile.SPAJForm.SPAJSubmitDate = dateTimeSPAJEditSubmit.Text;
            // Insurer Form
            spajFile.InsurerForm.InsurerName = textBoxSPAJEditInsrName.Text;
            spajFile.InsurerForm.InsurerHeight = int.Parse(textBoxSPAJEditInsrHeight.Text);
            spajFile.InsurerForm.InsurerWeight = int.Parse(textBoxSPAJEditInsrWeight.Text);
            spajFile.InsurerForm.InsurerNextBday = int.Parse(textBoxSPAJEditInsrNextBday.Text);
            spajFile.InsurerForm.InsurerSmoke = radioButtonSPAJEditInsrSmoke.Checked;
            spajFile.InsurerForm.InsurerGender = comboBoxSPAJEditInsrGender.Text;
            spajFile.InsurerForm.InsurerJobClass = comboBoxSPAJEditInsrJobClass.Text;
            spajFile.InsurerForm.InsurerMarried = comboBoxSPAJEditInsrMarriage.Text;
            spajFile.InsurerForm.InsurerDOB = dateTimeSPAJEditInsrDOB.Text;
            // Polis Form
            spajFile.PolisForm.PolisName = textBoxSPAJEditPolisName.Text;
            spajFile.PolisForm.PolisMarriage = comboBoxSPAJEditPolisMarriage.Text;
            spajFile.PolisForm.PolisGender = comboBoxSPAJEditPolisGender.Text;
            spajFile.PolisForm.PolisRs = comboBoxSPAJEditPolisRs.Text;
            spajFile.PolisForm.PolisDOB = dateTimeSPAJEditPolisDOB.Text;
            // Spouse Form
            spajFile.SpouseForm.SpouseName = textBoxSPAJEditSpouseName.Text;
            spajFile.SpouseForm.SpouseHeight = int.Parse(textBoxSPAJEditSpouseHeight.Text);
            spajFile.SpouseForm.SpouseNextBday = int.Parse(textBoxSPAJEditSpouseNextBday.Text);
            spajFile.SpouseForm.SpouseWeight = int.Parse(textBoxSPAJEditSpouseWeight.Text);
            spajFile.SpouseForm.SpouseGender = comboBoxSPAJEditSpouseGender.Text;
            spajFile.SpouseForm.SpouseMarriage = comboBoxSPAJEditSpouseMarriage.Text;
            spajFile.SpouseForm.SpouseSmoke = radioButtonSPAJEditSpouseSmoke.Checked;
            spajFile.SpouseForm.SpouseDOB = dateTimeSPAJEditSpouseDOB.Text;
            // Parent Form
            spajFile.ParentForm.ParentName = textBoxSPAJEditParentName.Text;
            spajFile.ParentForm.ParentHeight = int.Parse(textBoxSPAJEditParentHeight.Text);
            spajFile.ParentForm.ParentNextBday = int.Parse(textBoxSPAJEditParentNextBday.Text);
            spajFile.ParentForm.ParentWeight = int.Parse(textBoxSPAJEditParentWeight.Text);
            spajFile.ParentForm.ParentGender = comboBoxSPAJEditParentGender.Text;
            spajFile.ParentForm.ParentMarriage = comboBoxSPAJEditParentMarriage.Text;
            spajFile.ParentForm.ParentSmoke = radioButtonSPAJEditParentSmoke.Checked;
            spajFile.ParentForm.ParentDOB = dateTimeSPAJEditParentDOB.Text;
            // Address Form
            spajFile.AddressForm.City = textBoxSPAJEditAddrCity.Text;
            spajFile.AddressForm.Email = textBoxSPAJEditAddrEmail.Text;
            spajFile.AddressForm.HPNumber = int.Parse(textBoxSPAJEditAddrHP.Text);
            spajFile.AddressForm.Address = textBoxSPAJEditAddrAddress.Text;
            spajFile.AddressForm.OPNumber = int.Parse(textBoxSPAJEditAddrOP.Text);
            spajFile.AddressForm.ZipCode = int.Parse(textBoxSPAJEditAddrZip.Text);
            // Pengajuan Form
            spajFile.PengajuanForm.PengajuanCCBankOther = textBoxSPAJEditPengajuanCCBank.Text;
            spajFile.PengajuanForm.PengajuanExchange = int.Parse(textBoxSPAJEditPengajuanExchange.Text);
            spajFile.PengajuanForm.PengajuanExpDate = textBoxSPAJEditPengajuanExpDate.Text;
            spajFile.PengajuanForm.PengajuanPertanggungan = int.Parse(textBoxSPAJEditPengajuanPrtanggung.Text);
            spajFile.PengajuanForm.PengajuanPruADDAmnt = int.Parse(textBoxSPAJEditPengajuanPruADDAmnt.Text);
            spajFile.PengajuanForm.PengajuanPruCCAmnt = int.Parse(textBoxSPAJEditPengajuanPruCCAmnt.Text);
            spajFile.PengajuanForm.PengajuanPruMedAmnt = int.Parse(textBoxSPAJEditPengajuanPRUMedAmnt.Text);
            spajFile.PengajuanForm.PengajuanPruPayorAmnt = int.Parse(textBoxSPAJEditPengajuanPruPayorAmnt.Text);
            spajFile.PengajuanForm.PengajuanPruPPayorAmnt = int.Parse(textBoxSPAJEditPengajuanPruPPayorAmnt.Text);
            spajFile.PengajuanForm.PengajuanBasic = textBoxSPAJEditPengajuanBasic.Text;
            spajFile.PengajuanForm.PengajuanCurrency = comboBoxSPAJEditPengajuanCurrency.Text;
            spajFile.PengajuanForm.PengajuanFrequency = comboBoxSPAJEditPengajuanFreq.Text;
            spajFile.PengajuanForm.PengajuanPay = comboBoxSPAJEditPengajuanPay.Text;
            spajFile.PengajuanForm.PengajuanPruADD = textBoxSPAJEditPengajuanPruADD.Text;
            spajFile.PengajuanForm.PengajuanPruCC = textBoxSPAJEditPengajuanPruCC.Text;
            spajFile.PengajuanForm.PengajuanPruHosp = int.Parse(textBoxSPAJEditPengajuanPruHosp.Text);
            spajFile.PengajuanForm.PengajuanPruMed = textBoxSPAJEditPengajuanPRUMed.Text;
            spajFile.PengajuanForm.PengajuanPruPayor = textBoxSPAJEditPengajuanPruPayor.Text;
            spajFile.PengajuanForm.PengajuanPruPPayor = textBoxSPAJEditPengajuanPruPPayor.Text;

            spajFile.PengajuanForm.PengajuanPremi = int.Parse(textBoxSPAJEditPengajuanPremi.Text);
            spajFile.PengajuanForm.PengajuanPruSaver = int.Parse(textBoxSPAJEditPengajuanPruSaver.Text);
            spajFile.PengajuanForm.PengajuanTotalPremi = int.Parse(textBoxSPAJEditPengajuanPremiTotal.Text);


            // Beneficiary Form
            spajFile.BeneficiaryForm.Beneficiary1.FirstName = textBoxSPAJEditBeneficiaryFName1.Text;
            spajFile.BeneficiaryForm.Beneficiary1.LastName = textBoxSPAJEditBeneficiaryLName1.Text;
            spajFile.BeneficiaryForm.Beneficiary1.Details = textBoxSPAJEditBeneficiaryDetail1.Text;
            spajFile.BeneficiaryForm.Beneficiary1.Birthdate = dateTimeSPAJEditBeneficiary1.Text;
            spajFile.BeneficiaryForm.Beneficiary1.Relationship = comboBoxSPAJEditBeneficiaryRs1.Text;
            spajFile.BeneficiaryForm.Beneficiary2.FirstName = textBoxSPAJEditBeneficiaryFName2.Text;
            spajFile.BeneficiaryForm.Beneficiary2.LastName = textBoxSPAJEditBeneficiaryLName2.Text;
            spajFile.BeneficiaryForm.Beneficiary2.Details = textBoxSPAJEditBeneficiaryDetail2.Text;
            spajFile.BeneficiaryForm.Beneficiary2.Birthdate = dateTimeSPAJEditBeneficiary2.Text;
            spajFile.BeneficiaryForm.Beneficiary2.Relationship = comboBoxSPAJEditBeneficiaryRs2.Text;
            spajFile.BeneficiaryForm.Beneficiary3.FirstName = textBoxSPAJEditBeneficiaryFName3.Text;
            spajFile.BeneficiaryForm.Beneficiary3.LastName = textBoxSPAJEditBeneficiaryLName3.Text;
            spajFile.BeneficiaryForm.Beneficiary3.Details = textBoxSPAJEditBeneficiaryDetail3.Text;
            spajFile.BeneficiaryForm.Beneficiary3.Birthdate = dateTimeSPAJEditBeneficiary3.Text;
            spajFile.BeneficiaryForm.Beneficiary3.Relationship = comboBoxSPAJEditBeneficiaryRs3.Text;
            spajFile.BeneficiaryForm.Beneficiary4.FirstName = textBoxSPAJEditBeneficiaryFName4.Text;
            spajFile.BeneficiaryForm.Beneficiary4.LastName = textBoxSPAJEditBeneficiaryLName4.Text;
            spajFile.BeneficiaryForm.Beneficiary4.Details = textBoxSPAJEditBeneficiaryDetail4.Text;
            spajFile.BeneficiaryForm.Beneficiary4.Birthdate = dateTimeSPAJEditBeneficiary4.Text;
            spajFile.BeneficiaryForm.Beneficiary4.Relationship = comboBoxSPAJEditBeneficiaryRs4.Text;
            spajFile.BeneficiaryForm.Beneficiary5.FirstName = textBoxSPAJEditBeneficiaryFName5.Text;
            spajFile.BeneficiaryForm.Beneficiary5.LastName = textBoxSPAJEditBeneficiaryLName5.Text;
            spajFile.BeneficiaryForm.Beneficiary5.Details = textBoxSPAJEditBeneficiaryDetail5.Text;
            spajFile.BeneficiaryForm.Beneficiary5.Birthdate = dateTimeSPAJEditBeneficiary5.Text;
            spajFile.BeneficiaryForm.Beneficiary5.Relationship = comboBoxSPAJEditBeneficiaryRs5.Text;
            spajFile.BeneficiaryForm.Beneficiary6.FirstName = textBoxSPAJEditBeneficiaryFName6.Text;
            spajFile.BeneficiaryForm.Beneficiary6.LastName = textBoxSPAJEditBeneficiaryLName6.Text;
            spajFile.BeneficiaryForm.Beneficiary6.Details = textBoxSPAJEditBeneficiaryDetail6.Text;
            spajFile.BeneficiaryForm.Beneficiary6.Birthdate = dateTimeSPAJEditBeneficiary6.Text;
            spajFile.BeneficiaryForm.Beneficiary6.Relationship = comboBoxSPAJEditBeneficiaryRs6.Text;
        }

        private void buttonSPAJDeleteDelete_Click(object sender, EventArgs e)
        {
            spajFiles.Remove(spajFiles.First(x => x.SPAJForm.SPAJNum == int.Parse(textBoxSPAJDeleteNum.Text)));
        }

        private void buttonSPAJDeleteCheck_Click(object sender, EventArgs e)
        {
            bool exists = spajFiles.Any(x => x.SPAJForm.SPAJNum == int.Parse(textBoxSPAJDeleteNum.Text));
            buttonSPAJDeleteDelete.Enabled = exists;
            buttonSPAJDeleteClear.Enabled = exists;
            if (!exists)
            {
                MessageBox.Show("SPAJ file with that number does not exist.");
            }
        }

        private void buttonInsInfoClear_Click(object sender, EventArgs e)
        {
            clearTabPage(tabPageInsInfo);
        }

        private void textBoxSPAJPengajuanPrtanggung_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControlAddSPAJ_Selecting(object sender, TabControlCancelEventArgs e)
        {
            int selectedTab = tabControlAddSPAJ.SelectedIndex;
            if (addTabCurrentlySelected != selectedTab)
            {
                tabControlAddSPAJ.SelectTab(addTabCurrentlySelected);
            }
        }

        private void addFormTabBack()
        {
            addTabCurrentlySelected--;
            tabControlAddSPAJ.SelectTab(addTabCurrentlySelected);
        }

        private void buttonAddSPAJPolisBack_Click(object sender, EventArgs e)
        {
            addFormTabBack();
        }

        private void buttonAddSPAJBeneficiaryBack_Click(object sender, EventArgs e)
        {
            addFormTabBack();
        }

        private void buttonAddSPAJPengajuanBack_Click(object sender, EventArgs e)
        {
            addFormTabBack();
        }

        private void buttonAddSPAJAddressBack_Click(object sender, EventArgs e)
        {
            addFormTabBack();
        }

        private void buttonAddSPAJParentBack_Click(object sender, EventArgs e)
        {
            addFormTabBack();
        }

        private void buttonAddSPAJSpouseBack_Click(object sender, EventArgs e)
        {
            addFormTabBack();
        }

        private void buttonSpouseEditIgnore_Click(object sender, EventArgs e)
        {

        }

        private void buttonSPAJPengajuanSave_Click(object sender, EventArgs e)
        {
            addTabNext();
        }
    }
}
 