using System;

namespace Trendyol_new
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonMeneger person1 = new PersonMeneger();
            person1.ManagePerson();

            Console.WriteLine("Musterisiz yoxsa isci? :");
            string sual = Console.ReadLine();
            if (sual == "musteri")
            {
                Customer customer1 = new Customer();
            }
            else
            {

                Employee empolee2 = new Employee();
            }



        }
    }
}
