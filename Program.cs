using System;
namespace AddressbookDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();

            Console.WriteLine("Enter Name");
            addressBook.Name = Console.ReadLine();

            Console.WriteLine("Enter Address");
            addressBook.Address = Console.ReadLine();

            Console.WriteLine("Enter MObile Number");
            addressBook.MobileNo = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter Email ID ");
            addressBook.Email = Console.ReadLine();

            Console.WriteLine("Enter City");
            addressBook.City = Console.ReadLine();

            Console.WriteLine("Enter State");
            addressBook.State = Console.ReadLine();

            Console.WriteLine("Enter Zip Code");
            addressBook.ZipCode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Name:{0}", addressBook.Name);
            Console.WriteLine("Address: {0}", addressBook.Address);
            Console.WriteLine("City: {0}", addressBook.City);
            Console.WriteLine("State: {0}", addressBook.State);
            Console.WriteLine("Zip Code: {0}", addressBook.ZipCode);
            Console.WriteLine("Mobile: {0}", addressBook.MobileNo);
            Console.WriteLine("Email: {0}", addressBook.Email);


        }
    }
}
