using System;

namespace SizeOfAddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookModel model = new AddressBookModel();
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            addressBookRepo.SizeOfAddressBook();
        }
    }
}
