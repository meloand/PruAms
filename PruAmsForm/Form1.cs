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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void buttonMenuSPAJ_Click(object sender, EventArgs e)
        {
            
            Form2 AMS_SPAJ = new Form2();

            AMS_SPAJ.Show();
            this.Hide(); 
            
        }

        private void buttonMenuAgent_Click(object sender, EventArgs e)
        {

            Form3 AMS_Agent = new Form3();

            AMS_Agent.Show();
            this.Hide(); 
            
        }

       
    }
}
