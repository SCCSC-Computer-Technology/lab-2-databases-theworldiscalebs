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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cityDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityDetailsDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityDetailsDataSet.CityDetails' table. You can move, or remove it, as needed.
            this.cityDetailsTableAdapter.Fill(this.cityDetailsDataSet.CityDetails);

        }

        private void ShowDetatilsBtn_Click(object sender, EventArgs e)
        {
            CityDetailsForm cityDetailsForm = new CityDetailsForm();//contructor that sets a new cityDetailsForm to the cityDetailsForm variable
            cityDetailsForm.Show(); // displaying the city details form!
        }

        private void ExtBtn_Click(object sender, EventArgs e)
        {
            //closes the form
            MessageBox.Show("Thank you for using the population database have a good day :)");
            this.Close();
        }

        private void ASCPopulationBtn_Click(object sender, EventArgs e)
        {
            //calls the fill by population method
            this.cityDetailsTableAdapter.FillByPopulation(this.cityDetailsDataSet.CityDetails);
        }

        private void DESCPopulationBtn_Click(object sender, EventArgs e)
        {
            //calls the Desc population method
            this.cityDetailsTableAdapter.FillByDESCPopulation(this.cityDetailsDataSet.CityDetails);
        }

        private void SortByCityBtn_Click(object sender, EventArgs e)
        {
            //calls the sort by city method
            this.cityDetailsTableAdapter.FillByCity(this.cityDetailsDataSet.CityDetails);
        }

        private void AveragePopulationBtn_Click(object sender, EventArgs e)
        {
            //declaring variable to hold average population
            int averagePopulation;

            //calling the averagePopulation method 
            averagePopulation = (int)this.cityDetailsTableAdapter.AveragePopulation();

            //displaying the average population
            MessageBox.Show("Average Population of all cities: " + averagePopulation.ToString("n") + " citizens");
        }

        private void TotalPopulationBtn_Click(object sender, EventArgs e)
        {
            //declaring variable to hold average population
            int totalPopulation;

            //calling the averagePopulation method
            totalPopulation = (int) this.cityDetailsTableAdapter.TotalPopulation();

            //displaying the average population
            MessageBox.Show("Total Population of all cities: " + totalPopulation.ToString("n") + " citizens");
        }

        private void HighestPopulation_Click(object sender, EventArgs e)
        {
            int highestPopulation;

            highestPopulation = (int)this.cityDetailsTableAdapter.HighestPopulation();

            MessageBox.Show("The city with the highest population is New York City with " + highestPopulation.ToString("n") + " citizens");
        }

        private void LowestPopulationBtn_Click(object sender, EventArgs e)
        {
            //declaring variable to hold average population
            int lowestPopulation;
           
            //calling the averagePopulation method
            lowestPopulation = (int) this.cityDetailsTableAdapter.LowestPopulation();

            //displaying the average population
            MessageBox.Show("The city with the lowest population is Austin Texas with " + lowestPopulation.ToString("n") + " citizens");

        }
    }
}
