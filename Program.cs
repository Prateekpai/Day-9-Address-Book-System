using System;
namespace AddressbookDemo
{
    public class Program
    {
        public static void Main(string[]args)
        {
            AddressBook addressBook = new AddressBook();

            addressBook.Name = ("Prateek");
            addressBook.Address = ("Bangalore");
            addressBook.MobileNo = (9945007207);
            addressBook.City = ("Bangalore");
            addressBook.Email = ("Prateekvasanthpai@gmail.com");
            addressBook.ZipCode = (5760027);
            addressBook.State = ("Karnataka");

            Console.WriteLine("Name:{0}",addressBook.Name);
            Console.WriteLine("Address: {0}",addressBook.Address);
            Console.WriteLine("City: {0}", addressBook.City);
            Console.WriteLine("State: {0}", addressBook.State);
            Console.WriteLine("Zip Code: {0}", addressBook.ZipCode);
            Console.WriteLine("Mobile: {0}", addressBook.MobileNo);
            Console.WriteLine("Email: {0}", addressBook.Email);


        }
    }
}
