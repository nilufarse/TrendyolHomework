using System;
using System.Collections.Generic;
using System.Text;
using TTrendyol_new;

namespace Trendyol_new
{
    class PersonMeneger
    {
        public void ManagePerson()
        {
            Person person1 = new Person();

            Console.WriteLine("Adini qeyd edin");
            person1.Name = Console.ReadLine();

            Console.WriteLine("Soyadini qeyd edin");
            person1.Surname = Console.ReadLine();

            Console.WriteLine("Ata adini qeyd edin");
            person1.FatherName = Console.ReadLine();

            Console.WriteLine("Dogum tarixini qeyd edin");
            person1.DateOfBirth = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Emaile giriniz");
            person1.Email = Console.ReadLine();

            Console.WriteLine("Password giriniz");
            person1.Password = Console.ReadLine();

            Console.WriteLine("Cinsini qeyd edin");
            person1.Gender = Console.ReadLine();

            Console.WriteLine("Telefonuna giriniz");
            string response = string.Empty;
            do
            {

                string item = Console.ReadLine();
                person1.AddPhones(item);
                Console.WriteLine("Bashqa telefon varmi? He/yox");
                response = Console.ReadLine();
            }
            while (response == "he");
            Console.WriteLine("Adresini giriniz");
            string responseAddress = string.Empty;
            do
            {

                string item = Console.ReadLine();
                person1.AddAddress(item);
                Console.WriteLine("Bashqa adres varmi? He/yox");
                responseAddress = Console.ReadLine();
            }
            while (responseAddress == "he");

            person1.WritePersonInformation();
        }
    }
}
