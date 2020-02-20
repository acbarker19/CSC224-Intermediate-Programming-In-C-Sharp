using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListOfObjects
{
    class Vehicle
    {
        private string make, model;
        private int year;
        private decimal miles, price;

        public Vehicle(string make, string model, int year, decimal miles, decimal price)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Miles = miles;
            this.Price = price;
        }

        public string Make
        {
            get
            {
                return make;
            }

            set
            {
                make = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                if (value < 1900)
                {
                    MessageBox.Show("Year cannot be before 1900 -- using 1900 instead", "Year Error");
                    year = 1900;
                }
                else
                {
                    year = value;
                }
            }
        }

        public decimal Miles
        {
            get
            {
                return miles;
            }

            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Miles cannot be less than zero -- using 0 instead", "Miles Error");
                    miles = 0.0m;
                }
                else
                {
                    miles = value;
                }
            }
        }

        public decimal Price
        {
            get
            {
                return price;
            }

            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Price cannot be less than zero -- using 0 instead", "Price Error");
                    price = 0.0m;
                }
                else
                {
                    price = value;
                }
            }
        }

        public string GetDisplayText()
        {
            return "a " + year + " " + make + " " + model + " with " + miles + " miles, selling for " + price.ToString("c");
        }
    }
}
