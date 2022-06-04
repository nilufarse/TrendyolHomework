using System;
using System.Collections.Generic;
using System.Text;

namespace TTrendyol_new
{
    public class Person
    {
        public Person()
        {
            this.Address = new List<string>();
            this.Phones = new List<string>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<string> Phones { get; set; }
        public List<string> Address { get; set; }
        public string Gender { get; set; }

        public void ChangePassword(string new_password)
        {
            //
        }
        public void AddPhones(string new_phoneNumer)
        {
            this.Phones.Add(new_phoneNumer);
        }
        public void AddAddress(string new_addres)
        {
            this.Address.Add(new_addres);
        }
        public void WritePersonInformation()
        {
            StringBuilder info = new StringBuilder();
            info.Append("Adı: " + this.Name + "\n");
            info.Append("Soyadı: " + this.Surname + "\n");
            info.Append("Ata adı: " + this.FatherName + "\n");
            info.Append("Doğum tarixi: " + this.DateOfBirth + "\n");
            info.Append("Email: " + this.Email + "\n");
            info.Append("Password: " + this.Password + "\n");
            info.Append("Cinsi: " + this.Gender + "\n");

            for (int i = 0; i < this.Phones.Count; i++)
            {
                info.Append($"Telefon nömrəsi: {i + 1}" + this.Phones[i] + "\n");
            }
            for (int i = 0; i < this.Address.Count; i++)
            {
                info.Append($"Adres: {i + 1}" + this.Address[i] + "\n");
            }
            Console.WriteLine(info);
        }
    }
}
