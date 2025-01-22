using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThompsonCPT206DatabasesLab2
{
    public partial class CityDetailsForm : Form
    {
        public CityDetailsForm()
        {
            InitializeComponent();
        }

        private void cityDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityDetailsDataSet);

        }

        private void CityDetailsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityDetailsDataSet.CityDetails' table. You can move, or remove it, as needed.
            this.cityDetailsTableAdapter.Fill(this.cityDetailsDataSet.CityDetails);

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
