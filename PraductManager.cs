using System;
using System.Collections.Generic;
using System.Text;

namespace Trendyol_new
{
    class PraductManager
    {
        public void ProductManager()
        {

            Product product1 = new Product();
            Console.Write("Mehsulun adini qeyd edin: ");
            product1.Name = Console.ReadLine();
            Console.Write("Mehsulun hansi kateqoriyaya aid oldugunu qeyd edin: ");
            product1.Category = Console.ReadLine();
            Console.Write("Mehsulun kodunu qeyd edin: ");
            product1.Code = Console.ReadLine();
            Console.Write("Mehsulun qiymetini qeyd edin: ");
            product1.Cost = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Mehsulun rengini qeyd edin: ");
            Console.Write("Mehsulun rengini qeyd edin: ");
            product1.Color = Console.ReadLine();    
            Console.WriteLine("Mehsulun olçusunu qeyd edin: ");
            product1.Size = int.Parse(Console.ReadLine());
            Console.WriteLine("Mehsulun materialini qeyd edin: ");
            product1.Matreal = Console.ReadLine();
            string response = string.Empty;
            do
            {
                string item = Console.ReadLine();
                product1.AddColor(item);
                Console.WriteLine("Başqa reng elave etmek isteyirsiniz? He/yox");
                response = Console.ReadLine();

            } while (response == "he");
            Console.WriteLine("Mehsulun olçusunu qeyd edin: ");
            product1.Size = int.Parse(Console.ReadLine());
            Console.WriteLine("Mehsulun materialini qeyd edin: ");
            product1.Matreal = Console.ReadLine();

            product1.WriteProductInformation();

        }

    }
}
