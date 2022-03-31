using System;
using System.Collections;
using System.Linq;
using System.Text;
namespace AddressbookDemo
{

    public class AddressProgram
    {
        public static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();

            addressBook.Name = ("Prateek");
            addressBook.Address = ("Bangalore");
            addressBook.MobileNo = (9945007207);
            addressBook.City = ("Bangalore");
            addressBook.Email = ("Prateekvasanthpai@gmail.com");
            addressBook.ZipCode = (5760027);
            addressBook.State = ("Karnataka");

            Console.WriteLine("Name:{0}", addressBook.Name);
            Console.WriteLine("Address: {0}", addressBook.Address);
            Console.WriteLine("City: {0}", addressBook.City);
            Console.WriteLine("State: {0}", addressBook.State);
            Console.WriteLine("Zip Code: {0}", addressBook.ZipCode);
            Console.WriteLine("Mobile: {0}", addressBook.MobileNo);
            Console.WriteLine("Email: {0}", addressBook.Email);

            Console.WriteLine("Press 1 to Delete the Name");
            int Input = Convert.ToInt32(Console.ReadLine());

            if (Input == 1)
            {

                addressBook.Name = "";

                Console.WriteLine("The  name is deleted :{0}", addressBook.Name);
            }
        }

    }
}
