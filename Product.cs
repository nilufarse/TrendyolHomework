using System;
using System.Collections.Generic;
using System.Text;

namespace Trendyol_new
{
    class Product
    {
        public Product()
        {
        }

        public Product(int id, string name, string category, string type, string code,
            decimal cost, string matreal, string color, decimal size)
        {
            Id = id;
            Name = name;
            Category = category;
            Type = type;
            Code = code;
            Cost = cost;
            Matreal = matreal;
            Color = color;
            Size = size;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string Code { get; set; }
        public decimal Cost { get; set; }
        public string Matreal { get; set; }
        public string Color { get; set; }
        public decimal Size { get; set; }


        public void AddColor(string item)
        {
            throw new NotImplementedException();
        }

        public void WriteProductInformation()
        {
            throw new NotImplementedException();
        }
    }
}
