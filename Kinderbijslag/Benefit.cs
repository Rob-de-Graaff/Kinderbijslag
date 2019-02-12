using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinderbijslag
{
    class Benefit
    {
        private string name;
        private double price;
        private double discount;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public double Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        public Benefit(string benefitName, double benefitPrice, double benefitDiscount)
        {
            name = benefitName;
            price = benefitPrice;
            discount = benefitDiscount;
        }
    }
}
