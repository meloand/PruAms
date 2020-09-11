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
            tabControlAddSPAJ.SelectTab(tabPagePolisHolder);

            // Add SPAJ Form 
            int SPAJNum = int.Parse(textBoxSPAJNum.Text);
            string SPAJType = comboBoxSPAJInsType.Text;
            string AgentName = textBoxSPAJAName.Text;
            int AgentNum = int.Parse(textBoxSPAJANum.Text);
            int PruFlyerNum = int.Parse(textBoxPRUFlyerNum.Text);
            string SPAJSubmit = dateTimeSPAJSubmit.Text;

            // Insurer Info Form 
            string InsurerName = textBoxSPAJInsrName.Text;
            string InsurerGender = comboBoxSPAJInsrGender.Text;
            string InsurerDOB = dateTimeSPAJInsrDOB.Text;
            string InsurerMarried = comboBoxSPAJInsrMarriage.Text;
            string InsurerNextBday = NextBday(DateTime.Today); 


            
        }

        private void buttonPolisHolderAccept_Click(object sender, EventArgs e)
        {
            tabControlAddSPAJ.SelectTab(tabPageSpouseInfo);
        }

        private void buttonSpouseAccept_Click(object sender, EventArgs e)
        {
            tabControlAddSPAJ.SelectTab(tabPageParentInfo);
        }

        private void buttonParentAccept_Click(object sender, EventArgs e)
        {
            tabControlAddSPAJ.SelectTab(tabPageAddressInfo);
        }

        private void buttonAddressAccept_Click(object sender, EventArgs e)
        {
            tabControlAddSPAJ.SelectTab(tabPagePengajuanInfo);
        }

        private void buttonPengajuanAccept_Click(object sender, EventArgs e)
        {
            tabControlAddSPAJ.SelectTab(tabPageBeneficiaryInfo);
        }

        private void buttonBeneficiaryAccept_Click(object sender, EventArgs e)
        {
            buttonSPAJNewCreate.Enabled = true; 

        }

        private void buttonSPAJNewCreate_Click(object sender, EventArgs e)
        {
            buttonSPAJNewStoreFiles.Enabled = true;
            buttonSPAJNewCreate.Enabled = false;
            buttonSPAJNewClear.Enabled = false; 
        }



        // PRIVATE METHODS 

        private int NextBday(string InsurerDOB)
        {
           DateTime Today = DateTime.Today; 
           
        

        }

    }
}
