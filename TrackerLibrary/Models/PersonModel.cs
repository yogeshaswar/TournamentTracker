using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PersonModel
    {
        public int id { get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string CellphoneNumber { get; set; }

        public PersonModel()
        {
            
        }

        public PersonModel(string firstName, string lastName, string email, string cellPhoneNumber)
        {
            FirstName = firstName; LastName = lastName; Email = email; CellphoneNumber = cellPhoneNumber;
        }


    }
}
