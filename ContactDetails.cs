using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProgram
{
    class ContactDetails
    {
        public string firstName, lastName, address, state, city, email;
        public  double zip, phoneNumber;
        public ContactDetails(string firstName, string lastName, string address, string state, string city, double zip, double phoneNumber, string email )
        {
           
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.state = state;
            this.city = city;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }
        
    }
}
