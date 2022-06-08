using System;

namespace Insert_Contact
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookModel model = new AddressBookModel();
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            model.FirstName = "Darshan";
            model.LastName = "B";
            model.address = "Kbg";
            model.city = "Kalaburagi";
            model.State = "Karnataka";
            model.Zip = "585401";
            model.PhoneNumber = "9901123984";
            model.Email = "darshan@gmail.com";
            if (addressBookRepo.AddContact(model))
                Console.WriteLine("Record Added Successfully..");
        }
    }
}
