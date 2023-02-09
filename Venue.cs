using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lecture5_Notes_Assignment
{
    public class Venue
    {
        string _name;
        decimal _price;
        int _capacity;
        string _zipcode;


        public Venue(string name, decimal price, int capacity, string zipcode)
        {
            _name = name;
            _price = price;
            _capacity = capacity;
            _zipcode = zipcode;

        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                
                if (value == "")
                {
                    MessageBox.Show("Please enter Venue Name");
                }
                else
                {
                    _name = value;
                }
            }
        }
        public decimal Price
        {
            get => _price;
            set
            { 
            }
        }
        public int Capacity
        {
            get => _capacity;
        }
        public string ZipCode
        {
            get => _zipcode;
        }
    }
}
