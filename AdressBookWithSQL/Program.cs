﻿namespace AdressBookWithSQL
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address Book System");
            Console.WriteLine("Choose a option");

            Console.WriteLine("1. Insert contact");
            int option = Convert.ToInt32(Console.ReadLine());

            ContactModel contact = new ContactModel();
            switch (option)
            {
                case 1:
                    InsertContact insert = new InsertContact();

                    contact.FirstName = "Roshan";
                    contact.LastName = "kumar";
                    contact.Address = "Nashik";
                    contact.City = "Nashik";
                    contact.State = "Maharashtra";
                    contact.Zip = 456601;
                    contact.PhoneNumber = 23456789023;
                    contact.Email = "Roshan@gmail.com";

                    insert.AddContact(contact);
                    break;
            }
        }
     }
}