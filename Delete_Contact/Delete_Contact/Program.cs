using System;

namespace Delete_Contact
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookModel model = new AddressBookModel();
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            model.FirstName = "Darshan";
            model.LastName = "B";
            model.address = "Bgk";
            model.city = "Bagalkot";
            model.State = "Karnataka";
            model.Zip = "587103";
            model.PhoneNumber = "9901123984";
            model.Email = "darshan@gmail.com";
            if (addressBookRepo.DeleteContact(model))
                Console.WriteLine("Record Deleted Successfully");
        }
    }
}
