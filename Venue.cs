using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_Notes_Assignment
{
    public class Venue
    {
        //Fields
        public string VenueName;
        public decimal VenuePrice;
        public int VenueCapacity;
        public string VenueZipCode;

        //Constructor to take all information
        public Venue(string venueName, decimal venuePrice, int venueCapacity, string venueZipCode)
        {
            VenueName = venueName;
            VenuePrice = venuePrice;
            VenueCapacity = venueCapacity;
            VenueZipCode = venueZipCode;
        }
        //property is a mechanism to display information (get/read) or change information (set/write)
        //define property type, Access Modifier = type of the field - name of the field - no paranthesis
        //get allows user to READ value
        //set allows user to WRITE value
        private string VName
        {
            //if you only have get, its read only
            get => VName;
            set => VName = value;
        }
    }
}
