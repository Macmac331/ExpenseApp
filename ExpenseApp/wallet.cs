using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseApp
{
    public partial class wallet : UserControl
    {
        public wallet()
        {
            InitializeComponent();
        }

        private void wallet_Load(object sender, EventArgs e)
        {
            displayExpenses();
        }

        private void btnAddXpns_Click(object sender, EventArgs e)
        {
            AddExpensesForm AEF = new AddExpensesForm();
            AEF.ShowDialog();
        }
        public async void displayExpenses()
        {
            string username = FirebaseData.Instance.Username;
            otherFunc o = new otherFunc();
            QuerySnapshot snap = await o.displayExpenses(username);

            foreach (DocumentSnapshot docsnap in snap.Documents)
            {
                FirebaseData fb = docsnap.ConvertTo<FirebaseData>();
                if (docsnap.Exists)
                {
                    dgvExpenses.Rows.Add(fb.Category, fb.Amount.ToString());
                }
            }
        }
    }
}
