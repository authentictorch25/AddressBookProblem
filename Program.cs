using System;

namespace AddressBookProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            AdressBookMain tool = new AdressBookMain();
            tool.AddNewContact("Aryav", "Tiwari", "Jail Road", "MP","Shahdol", 486789, 9982275907, "AryavTiwari@gmail.com");
            tool.AddNewContact("Monu", "Vivek", "Gali no.2", "Bihar", "Chhapra", 458752, 9587486548, "viveks009@gmail.com");
            tool.EditDetails("Monu", "Vivek");
        }
    }
}
