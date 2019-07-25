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
        public Customers BenefitConstant;

        private static int CustomerBenefitStatus = 0;  //0 = No Benefit yet.

        public NewCB()
        {
            InitializeComponent();
        }

        private void NewCB_Load(object sender, EventArgs e)
        {
            

            //ByDefault
            DisableControls();

            //load the combo box values
            LoadComboBoxValuesInitially();


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

                //list.ForEach(s =>
                //{
                //    if (remove.Contains(s))
                //    {
                //        list.Remove(s);
                //    }
                //});
            }

            //List<string> remove = new List<string>() { "2" };

            //list.ForEach(s =>
            //{
            //    if (remove.Contains(s))
            //    {
            //        list.Remove(s);
            //    }
            //});
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

        private void LoadComboBoxValuesInitially()
        {
            int i = 0;
            foreach(var val in _Benefits)
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
            BenefitConstant = GetBenefitsAction();
            ProcessBenefits p = new ProcessBenefits();
            p.MakeNewEntry("C:\\E\\Annu-VS\\CustomerBenefits\\CustomerBenefits\\NewCustomerDB.txt", BenefitConstant);
            cmbNEWBENEFITCOLL.Items.RemoveAt(cmbNEWBENEFITCOLL.SelectedIndex);
        }

        private void btnNEWRemove_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        public Customers GetBenefitsAction()
        {
            Customers c1 = new Customers();
            c1.CustomerID = "898";
            c1.Benefit.BenefitName = cmbNEWBENEFITCOLL.SelectedItem.ToString();
            c1.Benefit.EffectiveDate = "Today";
            c1.Benefit.Description = cmbNEWBENEFITCOLL.SelectedItem.ToString();
            c1.Benefit.IsActive = "Y";
            c1.Benefit.Details = cmbNEWBENEFITCOLL.SelectedItem.ToString();

            return c1;

        }
    }
}
