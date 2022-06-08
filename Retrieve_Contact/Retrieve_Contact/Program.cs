using System;

namespace Retrieve_Contact
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookModel model = new AddressBookModel();
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            if (addressBookRepo.GetAllContact())
                Console.WriteLine("Record Retrived Successfully");
        }
    }
}
