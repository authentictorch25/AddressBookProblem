using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProgram
{
    class AdressBookMain
    {
        public static List<ContactDetails> contactlist = new List<ContactDetails>();
        public void AddNewContact(string firstName, string lastName, string address, string state, string city, double zip, double phoneNumber, string email)
        {
            ContactDetails contact = new ContactDetails(firstName, lastName,  address, state, city,  zip,  phoneNumber, email);
            contactlist.Add(contact);

            Console.WriteLine("Conact added successfully Successfully : " + firstName+" "+lastName);
            Console.WriteLine("Address : " + address);
            Console.WriteLine("State : " + state);
            Console.WriteLine("City : " + city);
            Console.WriteLine("ZIP : " + zip);
            Console.WriteLine("Phone Number" + phoneNumber);
            Console.WriteLine("E Mail : " + email+"\n");
        }
        public void EditDetails(string firstName, string lastName)
        {
            
            Console.WriteLine("\nDetails of " + firstName + " " + lastName + ":");
            foreach (var v in contactlist)
            {
                if (firstName == v.firstName && lastName == v.lastName)
                {
                    Console.WriteLine("To edit the contact detail choose option");
                    bool flag = true;
                    while (flag)
                    {
                        Console.WriteLine("1-To update first name\n2-To update last name\n3-To update address\n4-To update city\n5-To update state\n6-To update zip\n7-To update phone number\n8-To update email\n9-To exit edit portal and save updates");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 9)
                        {
                            break;
                        }
                        Console.WriteLine("Enter the new value");
                        var newValue = Console.ReadLine();


                        switch (choice)
                        {
                            case 1:
                                v.firstName = newValue;
                                break;
                            case 2:
                                v.lastName = newValue;
                                break;
                            case 3:
                                v.address = newValue;
                                break;
                            case 4:
                                v.city = newValue;
                                break;
                            case 5:
                                v.state = newValue;
                                break;
                            case 6:
                                v.zip = Convert.ToDouble(newValue);
                                break;
                            case 7:
                                v.phoneNumber = Convert.ToDouble(newValue);
                                break;
                            case 8:
                                v.email = newValue;
                                break;
                            case 9:
                                flag = false;
                                break;
                        }
                    }

                    Console.WriteLine(v.firstName + v.lastName);
                }
            }
        }
        

    }
}
