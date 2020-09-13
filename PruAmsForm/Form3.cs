using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PruAmsForm;

namespace PruAmsForm
{
    public partial class Form3 : Form
    {
       private List<Agent> NewAgents = new List<Agent>();
       private List<Agent> AAM = new List<Agent>();
       private List<Agent> AAD = new List<Agent>();
       private List<Agent> AD = new List<Agent>();
        private List<AgentLevelChange> agentLevelChanges = new List<AgentLevelChange>();

        public Form3()
        {
            InitializeComponent();
        }

        private void buttonAgentBackMenu_Click(object sender, EventArgs e)
        {
            Form1 AMS_Home = new Form1();
            AMS_Home.Show();
            this.Close();
        }

        /// <summary>
        /// ADD AGENTS TAB 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            long AddHphoneNum = int.Parse(textBoxAgentHP.Text);
            long AddOPhoneNum = int.Parse(textBoxAgentOP.Text);
            string AddPOB = textBoxAgentPOB.Text;
            string AddDOB = dateTimeAgentDOB.Text;
            Agent NewAgent;

            // add variables into NewAgent 
            NewAgent = new Agent(AddAgentNum, AddUsername, AddPassword, AddFirstName, AddLastName, AddEmail, AddJoinDate,
                AddLevel, AddLeader, AddReligion, AddSex, AddAddr, AddZipCode, AddHphoneNum, AddOPhoneNum, AddPOB, AddDOB); 


            if (NewAgents.Select(x => x.Number).Contains(AddAgentNum))
            {
                MessageBox.Show("This agent already exists in the database. ");
            }
            else
            {
                NewAgents.Add(NewAgent);
                agentBindingSource.Add(NewAgent);
            }
           
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

        /// <summary>
        /// EDIT AGENTS TAB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAgentEditSearch_Click(object sender, EventArgs e)
        {
            Agent agent = (Agent)comboBoxAgentModify.SelectedItem;

            textBoxAgentEditNum.Text = agent.Number;
            textBoxAgentEditUser.Text = agent.Username;
            textBoxAgentEditPass.Text = agent.Password;
            textBoxAgentEditFName.Text = agent.FirstName;
            textBoxAgentEditLName.Text = agent.LastName;
            textBoxAgentEditEmail.Text = agent.Email;
            dateTimeAgentEditJoin.Text = agent.JoinDate;
            comboBoxAgentEditLevel.Text = agent.Level;
            comboBoxAgentEditLeader.Text = agent.Leader;
            textBoxAgentEditReligion.Text = agent.Religion;
            comboBoxAgentEditSex.Text = agent.Sex;
            textBoxAgentEditAddr.Text = agent.Addr;
            textBoxAgentEditZip.Text = agent.ZipCode.ToString();
            textBoxAgentEditHP.Text = agent.HphoneNum.ToString();
            textBoxAgentEditOP.Text = agent.OPhoneNum.ToString();
            textBoxAgentEditPOB.Text = agent.POB;
            dateTimeAgentEditDOB.Text = agent.DOB; 


        }

        private void buttonEditAgents_Click(object sender, EventArgs e)
        {
            Agent agent = (Agent)comboBoxAgentModify.SelectedItem;

            if (agent.Level != comboBoxAgentEditLevel.Text)
            {
                agentLevelChanges.Add(new AgentLevelChange(agent.FirstName, agent.LastName, agent.Number, DateTime.Now, agent.Level, comboBoxAgentEditLevel.Text));
            }

            agent.Number = textBoxAgentEditNum.Text;
            agent.Username = textBoxAgentEditUser.Text;
            agent.Password = textBoxAgentEditPass.Text;
            agent.FirstName = textBoxAgentEditFName.Text;
            agent.LastName = textBoxAgentEditLName.Text;
            agent.Email = textBoxAgentEditEmail.Text;
            agent.JoinDate = dateTimeAgentEditJoin.Text;
            agent.Level = comboBoxAgentEditLevel.Text;
            agent.Leader = comboBoxAgentEditLeader.Text;
            agent.Religion = textBoxAgentEditReligion.Text;
            agent.Sex = comboBoxAgentEditSex.Text;
            agent.Addr = textBoxAgentEditZip.Text;
            agent.ZipCode = int.Parse(textBoxAgentEditZip.Text);
            agent.HphoneNum = long.Parse(textBoxAgentEditHP.Text);
            agent.OPhoneNum = long.Parse(textBoxAgentEditOP.Text);
            agent.POB = textBoxAgentEditPOB.Text;
            agent.DOB = dateTimeAgentEditDOB.Text; 

        }

        private void buttonClearEdit_Click(object sender, EventArgs e)
        {
            buttonAgentEditSearch_Click(null, null); 
        }

        /// <summary>
        /// LEVEL HISTORY TAB
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAgentLevelHistory_Click(object sender, EventArgs e)
        {
            Agent agent = (Agent)comboBoxAgentLevelHist.SelectedItem;
            var bindingList = new BindingList<AgentLevelChange>(agentLevelChanges.Where(x => x.Number == agent.Number).ToList());
            var bindingSource = new BindingSource(bindingList, null);
            dataGridView2.DataSource = bindingSource;
        }

        private void textBoxViewAgentNum_TextChanged(object sender, EventArgs e)
        {
            if (textBoxViewAgentNum.Text != String.Empty)
            {
                foreach (Control c in new Control[] { textBoxViewAgentFirstN, textBoxViewAgentLastN, comboBoxViewAgentDateDay,
                comboBoxViewAgentDateMonth, comboBoxViewAgentDateYear, comboBoxViewAgentLeader, comboBoxViewAgentLevel })
                {
                    c.Enabled = false;
                }
            } else
            {
                foreach (Control c in new Control[] { textBoxViewAgentFirstN, textBoxViewAgentLastN, comboBoxViewAgentDateDay,
                comboBoxViewAgentDateMonth, comboBoxViewAgentDateYear, comboBoxViewAgentLeader, comboBoxViewAgentLevel })
                {
                    c.Enabled = true;
                }
            }
        }

        private void buttonViewAgent_Click(object sender, EventArgs e)
        {
            List<Agent> list = new List<Agent>();
            list.AddRange(agentBindingSource.List.OfType<Agent>().ToList());
            IEnumerable<Agent> source = list;
            if (textBoxViewAgentNum.Text != String.Empty)
            {
                source.First(x => x.Number == textBoxViewAgentNum.Text);
            }
            else
            {
                if (textBoxViewAgentFirstN.Text != String.Empty)
                {
                    source = source.Where(x => x.FirstName == textBoxViewAgentFirstN.Text).ToList();
                }
                if (textBoxViewAgentLastN.Text != String.Empty)
                {
                    source = source.Where(x => x.LastName == textBoxViewAgentLastN.Text).ToList();
                }
                if (comboBoxViewAgentDateDay.Text != String.Empty)
                {
                    source = source.Where(x => x.DayOfBirth == comboBoxViewAgentDateDay.Text).ToList();
                }
                if (comboBoxViewAgentDateMonth.Text != String.Empty)
                {
                    source = source.Where(x => x.MonthOfBirth == comboBoxViewAgentDateMonth.Text).ToList();
                }
                if (comboBoxViewAgentDateYear.Text != String.Empty)
                {
                    source = source.Where(x => x.YearOfBirth == comboBoxViewAgentDateYear.Text).ToList();
                }
                if (comboBoxViewAgentLeader.Text != String.Empty) {
                    source = source.Where(x => x.Leader == comboBoxViewAgentLeader.Text).ToList();
                }
            }
            dataGridView1.DataSource = source;
        }
    }
}
