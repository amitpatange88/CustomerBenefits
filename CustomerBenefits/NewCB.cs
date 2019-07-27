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
    public partial class NewCB : Form
    {
        private List<string> _Benefits = new List<string>() { "Green", "WHD", "ICE", "BHF" }; //"Green","WHD","ICE", "BHF"

        private List<string> CustBenefits = new List<string>() { "Green", "WHD" };


        private List<string> MasterBenefitsList = new List<string>() { "Green", "WHD", "ICE", "BHF" };

        private List<string> CustBenefitsList = new List<string>() { "Green", "BHF" };

        private static int CustomerBenefitStatus = 0;  //0 = No Benefit yet.

        public NewCB()
        {
            InitializeComponent();
        }

        public List<string> RemoveListFromAnother()
        {
            List<string> result = MasterBenefitsList.Except(CustBenefitsList).ToList();

            return result;
        }

        private void NewCB_Load(object sender, EventArgs e)
        {
            int i = 1;
            foreach(var val in CustBenefits)
            {
                //insert rows into datagrid.
                dgCustomerBenefit.Rows.Add(false, i, val, "Today", string.Empty);
                i++;
            }

            foreach (var val in CustBenefits)
            {
                dgCustomerBenefit.Rows.Add(false, i, val, "Today", val);
                i++;
            }


            //ByDefault
            DisableControls();

            List<string> availableBenefits = RemoveListFromAnother();

            //load the combo box values
            LoadComboBoxValuesInitially(availableBenefits);


            //Load Combo Box Customer Wise.
            //LoadCmbCustWise();

            //Load DataGrid Customer Wise.
        }

        private void LoadCmbCustWise()
        {
            FileUtility f1 = new FileUtility("C:\\E\\Annu-VS\\CustomerBenefits\\CustomerBenefits\\NewCustomerDB.txt");
            string textFile = f1.ReadFile(); // business logic to get exact same customer details.

            Customers c1 = f1.DeserializeJSONData<Customers>(textFile);

            if (c1 != null)
            {
                //process

                
            }
        }

        private void DisableControls()
        {
            cmbNEWBENEFITCOLL.Enabled = false;
            btnNEWRemove.Enabled = false;
            btnNEWSave.Visible = false;
            lblICE.Visible = false;
            txtICENumber.Visible = false;
            txtNEWDate.Enabled = false;
        }

        private void LoadComboBoxValuesInitially(List<string> availableBenefits)
        {
            int i = 0;
            foreach(var val in availableBenefits) //MasterBenefitsList
            {
                cmbNEWBENEFITCOLL.Items.Insert(i, val);
                i++;
            }
        }

        private void lblNEWBenefit_Click(object sender, EventArgs e)
        {

        }

        private void lblNEW_Click(object sender, EventArgs e)
        {

        }

        private void lblNEWDate_Click(object sender, EventArgs e)
        {

        }

        private void btnNEWAdd_Click(object sender, EventArgs e)
        {
            cmbNEWBENEFITCOLL.Enabled = true;
        }

        private void btnNEWSave_Click(object sender, EventArgs e)
        {
            NewCustomers BenefitConstant = GetBenefitsAction();
            ProcessBenefits p = new ProcessBenefits();
            p.MakeNewEntry("C:\\E\\Annu-VS\\CustomerBenefits\\CustomerBenefits\\NewCustomerDB.txt", BenefitConstant);
            cmbNEWBENEFITCOLL.Items.RemoveAt(cmbNEWBENEFITCOLL.SelectedIndex);
        }

        private void btnNEWRemove_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgCustomerBenefit.SelectedRows)
            {
                dgCustomerBenefit.Rows.RemoveAt(row.Index);
            }
        }

        private void cmbNEWBENEFITCOLL_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnNEWAdd.Visible = false;
            btnNEWSave.Visible = true;

            if (cmbNEWBENEFITCOLL.SelectedIndex == 2)
            {
                lblICE.Visible = true;
                txtICENumber.Visible = true;
            }
            else
            {
                lblICE.Visible = false;
                txtICENumber.Visible = false;
            }
           
        }

        public NewCustomers GetBenefitsAction()
        {
            NewCustomers c1 = new NewCustomers();
            c1.Benefits[0].BenefitName = cmbNEWBENEFITCOLL.SelectedItem.ToString();
            c1.Benefits[0].EffectiveDate = "Today";
            c1.Benefits[0].Description = cmbNEWBENEFITCOLL.SelectedItem.ToString();
            c1.Benefits[0].IsActive = "Y";
            c1.Benefits[0].Details = cmbNEWBENEFITCOLL.SelectedItem.ToString();

            return c1;

        }
    }
}
