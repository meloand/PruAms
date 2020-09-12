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
    public partial class Form3 : Form
    {
       private List<Agent> NewAgents = new List<Agent>(); 
        public Form3()
        {
            InitializeComponent();
        } 

        private void buttonAddAgents_Click(object sender, EventArgs e)
        {
            // declaring variables 
            string AddAgentNum = textBoxAgentNum.Text;
            string AddUsername = textBoxAgentUser.Text;
            string AddPassword = textBoxAgentPass.Text;
            string AddFirstName = textBoxAgentFirstN.Text;
            string AddLastName = textBoxAgentLastN.Text;
            string AddEmail = textBoxAgentEmail.Text;
            string AddJoinDate = dateTimeAgentJoin.Text;
            string AddLevel = comboBoxAgentLevel.Text;
            string AddLeader = comboBoxAgentLeader.Text;
            string AddReligion = textBoxAgentReligion.Text;
            string AddSex = comboBoxAgentSex.Text;
            string AddAddr = textBoxAgentAddr.Text;
            int AddZipCode = int.Parse(textBoxAgentZip.Text);
            int AddHphoneNum = int.Parse(textBoxAgentHP.Text);
            int AddOPhoneNum = int.Parse(textBoxAgentOP.Text);
            string AddPOB = textBoxAgentPOB.Text;
            string AddDOB = dateTimeAgentDOB.Text;
            Agent NewAgent;

            NewAgent = new Agent(AddAgentNum, AddUsername, AddPassword, AddFirstName, AddLastName, AddEmail, AddJoinDate,
                AddLevel, AddLeader, AddReligion, AddSex, AddAddr, AddZipCode, AddHphoneNum, AddOPhoneNum, AddPOB, AddDOB); 

            if (NewAgents.Select(x => x.Number).Contains(AddAgentNum))
            {
                MessageBox.Show("This agent already exists in the database. ");
            }
            else
            {
                NewAgents.Add(NewAgent);
            }
           
        }

        private void buttonAgentBackMenu_Click(object sender, EventArgs e)
        {
            Form1 AMS_Home = new Form1();
            AMS_Home.Show();
            this.Close(); 
        }

        private void buttonClearAdd_Click(object sender, EventArgs e)
        {
            foreach (TextBox control in tabPageAdd.Controls.OfType<TextBox>())
            {
                control.Text = "";
            }
            foreach (DateTimePicker control in tabPageAdd.Controls.OfType<DateTimePicker>())
            {
                control.Text = "";
            }
            foreach (ComboBox control in tabPageAdd.Controls.OfType<ComboBox>())
            {
                control.Text = "";
            }
        }
    }
}
