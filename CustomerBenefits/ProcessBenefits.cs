using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBenefits
{
    public class ProcessBenefits
    {
        public Customers BenefitsAction()
        {
            Customers c1 = new Customers();
            c1.CustomerID = "123";
            c1.Benefit.BenefitName = "Green";
            c1.Benefit.EffectiveDate = "Today";
            c1.Benefit.Description = "Green";
            c1.Benefit.IsActive = "Y";
            c1.Benefit.Details = "24855";

            return c1;

        }

        public bool MakeOldEntry(string filePath)
        {
            bool IsDone = false;
            FileUtility f1 = new FileUtility(filePath);

            Customers c1 = BenefitsAction();
            string customer = f1.SerializeJSONData(c1);

            IsDone = f1.WriteLog(customer);


            return IsDone;
        }

        public bool MakeNewEntry(string filePath, NewCustomers c1)
        {
            bool IsDone = false;
            FileUtility f1 = new FileUtility(filePath);
            NewCB n = new NewCB();
            string customer = f1.SerializeJSONDataNew(c1);

            IsDone = f1.WriteLog(customer);


            return IsDone;
        }

       
    }
}
