using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerBenefits
{
    public partial class CustomerBenefits : Form
    {
        public CustomerBenefits()
        {
            InitializeComponent();
        }

        private void btnocb_Click(object sender, EventArgs e)
        {
            OldCB OCB = new OldCB();
            this.Hide();
            OCB.Show();
            //this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessBenefits p = new ProcessBenefits();
            p.MakeOldEntry("C:\\E\\Annu-VS\\CustomerBenefits\\CustomerBenefits\\Test.txt");
        }

        private void btnncb_Click(object sender, EventArgs e)
        {
            NewCB NCB = new NewCB();
            this.Hide();
            NCB.Show();
        }
    }
}
