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
    public partial class OldCB : Form
    {
        private static int CustomerBenefitStatus = 0;
        public OldCB()
        {
            InitializeComponent();
        }

        private void cmbBenefit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbBenefit.SelectedIndex == 0)
            {
                btnADD.Visible = false;
                btnSave.Visible = true;
            }
            else
            {
                DisableControls();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerBenefits CB = new CustomerBenefits();
            this.Hide();
            CB.Show();
            
        }

        private void OldCB_Load(object sender, EventArgs e)
        {
            //Disable the Combo Box and Other controls. 
            DisableControls();

            //call new function
            CustomerBenefitStatus = ReadCustomerBenefit();

            EnableControlsBasedOnStatus();
        }

        //ByDefault
        private void DisableControls()
        {
            cmbBenefit.SelectedIndex = -1;
            cmbBenefit.Enabled = false;
            btnADD.Visible = true;
            btnSave.Visible = false;
            btnremo.Visible = false;  

        }

        private void EnableControlsBasedOnStatus()
        {
            if(CustomerBenefitStatus == 1)
            {
                cmbBenefit.Enabled = true;
                btnADD.Visible = false;
                btnSave.Visible = false;
                btnremo.Visible = true;
                cmbBenefit.SelectedIndex = 0;
            }
            else
            {
                cmbBenefit.Enabled = false;
                btnADD.Visible = true;
                btnSave.Visible = false;
                btnremo.Visible = false;
                cmbBenefit.SelectedIndex = -1;
            }
        }


        private int ReadCustomerBenefit(string CustId = "123")
        {
            //0 = No Benefits having
            //1 = Green Benefits having.
            int CustStatus = 0;
            FileUtility f1 = new FileUtility("C:\\E\\Annu-VS\\CustomerBenefits\\CustomerBenefits\\OldCustomerDB.txt");
            string textFile = f1.ReadFile(); // business logic to get exact same customer details.

            Customers c1 = f1.DeserializeJSONData<Customers>(textFile);

            var collectionObj = "asd";
            var temp = collectionObj;

            if(c1 != null)
            {
                CustStatus = 1;
            }

            return CustStatus;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            EnableControlsBasedOnStatus();

            cmbBenefit.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ProcessBenefits p = new ProcessBenefits();
            p.MakeOldEntry("C:\\E\\Annu-VS\\CustomerBenefits\\CustomerBenefits\\OldCustomerDB.txt");
            CustomerBenefitStatus = 1;
            EnableControlsBasedOnStatus();
        }

        private void btnremo_Click(object sender, EventArgs e)
        {
            //int indexval = cmbBenefit.SelectedIndex;
            FileUtility f = new FileUtility();
            f.ReplaceWithNewWrite();
            DisableControls();
            CustomerBenefitStatus = 0;
        }
    }
}
