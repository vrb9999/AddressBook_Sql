using System;

namespace Retrive_Alphabetically
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookModel model = new AddressBookModel();
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            addressBookRepo.GetContactAlphabetically();
        }
    }
}
