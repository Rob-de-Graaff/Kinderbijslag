using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinderbijslag
{
    public partial class Form1 : Form
    {
        private Benefit _newBenefit1, _newBenefit2;
        private List<Benefit> _benefits;
        private List<int> _ages = new List<int>();
        private double _priceTotal;
        private bool dateAdded = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _benefits = new List<Benefit>();
            _ages = new List<int>();

            _newBenefit1 = new Benefit("kind < 12", 150, 1);
            _newBenefit2 = new Benefit("18 < kind >= 12", 235,1);

            _benefits.Add(_newBenefit1);
            _benefits.Add(_newBenefit2);

            // Fills labels
            int counterBenefits = 0;
            foreach (Label labelSubscription in panelSubscriptions.Controls)
            {
                //if (control.GetType() == typeof(Label))
                labelSubscription.Text = _benefits[counterBenefits].Name;
                counterBenefits++;
            }

            // Fills labels
            int counterPrices = 0;
            foreach (Label labelPrice in panelPrices.Controls)
            {
                labelPrice.Text = _benefits[counterPrices].Price.ToString();
                counterPrices++;
            }

            // Fills numericupdowns
            foreach (NumericUpDown control in panelYear.Controls)
            {
                control.Maximum = DateTime.Today.Year;
                control.Minimum = DateTime.Today.Year - 100;
                control.Value = DateTime.Today.Year;
            }

            numericUpDownMonth1.Maximum = DateTime.Today.Month;
            numericUpDownMonth1.Value = DateTime.Today.Month;

            numericUpDownDay1.Maximum = DateTime.Today.Month;
            numericUpDownDay1.Value = DateTime.Today.Month;

            labelTicketsTotal.Text = $@"aantal: {_benefits.Count}";
            labelPriceTotal.Text = $@"€ {Math.Round(_priceTotal, 2):0.00},-";
        }

        private void ButtonAddDates_Click(object sender, EventArgs e)
        {
            if (ValidateDate())
            {
                listBoxDates.DataSource = null;
                listBoxDates.DataSource = _ages;
                
                dateAdded = true;
            }
            else
            {
                MessageBox.Show($@"Please select the correct day of the month");
            }
        }

        private bool ValidateDate()
        {
            int checkDay = DateTime.DaysInMonth((int)numericUpDownYear1.Value, (int)numericUpDownMonth1.Value);

            if ((int)numericUpDownDay1.Value <= checkDay)
            {
                int age1;
                DateTime dateOfBirth1 = new DateTime((int) numericUpDownYear1.Value,
                    (int) numericUpDownMonth1.Value, (int) numericUpDownDay1.Value);
                age1 = CalculateAge(dateOfBirth1);
                _ages.Add(age1);

                return true;
            }
            else
            {
                return false;
            }
        }

        private static int CalculateAge(DateTime dateOfBirth)
        {
            int age = DateTime.Now.Year - dateOfBirth.Year;  
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)  
                age = age - 1;  
  
            return age; 
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            IEnumerable<int> ageSelection12Min = new List<int>();
            IEnumerable<int> ageSelection12Plus = new List<int>();
            Benefit tempBenefit = null;

            if (dateAdded)
            {
                if (numericUpDownAmount1.Value > 0)
                {
                    tempBenefit = _newBenefit1;

                    ageSelection12Min = 
                        from intergers in _ages
                        where intergers < 12
                        select intergers;

                    // checks if the entered number coresponds with selected number
                    if (ageSelection12Min.Count() == numericUpDownAmount1.Value && ageSelection12Min.Count() != 0)
                    {
                        _priceTotal += tempBenefit.Price * (double)numericUpDownAmount1.Value;
                    }
                    else
                    {
                        MessageBox.Show($"Please select the correct amount of children \nselected {numericUpDownAmount1.Value}, entered {ageSelection12Min.Count()}");
                        return;
                    }
                }

                if (numericUpDownAmount2.Value > 0)
                {
                    tempBenefit = _newBenefit2;

                    ageSelection12Plus = 
                        from intergers in _ages
                        where intergers >= 12
                              && intergers < 18
                        select intergers;

                    // checks if the entered number coresponds with selected number
                    if (ageSelection12Plus.Count() == numericUpDownAmount2.Value && ageSelection12Plus.Count() != 0)
                    {
                        _priceTotal += tempBenefit.Price * (double)numericUpDownAmount2.Value;
                    }
                    else
                    {
                        MessageBox.Show($"Please select the correct amount of children \nselected {numericUpDownAmount1.Value}, entered {ageSelection12Min.Count()}");
                        return;
                    }
                }

                // Checks which discount to select
                switch (_ages.Count)
                {
                   case 3: case 4:
                       tempBenefit.Discount = 0.02;
                       break;
                   case 5:
                       tempBenefit.Discount = 0.03;
                       break;
                   case int c when (c >= 6):
                       tempBenefit.Discount = 0.035;
                       break;
                }

                _priceTotal = _priceTotal * tempBenefit.Discount;
                
                labelTicketsTotal.Text = $@"(kind <12: {ageSelection12Min.Count()} * € {_newBenefit1.Price} + kind >= 12: {ageSelection12Plus.Count()} * € {_newBenefit2.Price}) * korting {(1-tempBenefit.Discount)*100}%";
                labelPriceTotal.Text = $@"€ {Math.Round(_priceTotal, 2):0.00},-";
            }
            else
            {
                MessageBox.Show($@"Please fill an date in and add it");
            }
        }
    }
}
