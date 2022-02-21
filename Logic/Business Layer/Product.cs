using Logic.Data_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Business_Layer
{
    public class Product
    {
        public enum eCategory
        {
            FruitsAndVegetables,
            Diary,
            BakedAndBread,
            AlcoholAndBeverage,
            CookingAndBaking
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public eCategory Category { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }

        public Product(string productName, string productDescription, int productQuantity, int productCategory, float productPrice)
        {
            Code = generateCode();
            Name = productName;
            Description = productDescription;
            Category = (eCategory)productCategory;
            Price = productPrice;
            Quantity = productQuantity;
        }
        public Product(string productCode, string productName, string productDescription, int productCategory, float productPrice)
        {
            Code = productCode;
            Name = productName;
            Description = productDescription;
            Category = (eCategory)productCategory;
            Price = productPrice;
        }

        private string generateCode()
        {
            string lastProductCode = DbProducts.GetLastProductCode();
            string lastProductDigits = new string(lastProductCode.Where(char.IsDigit).ToArray());
            string lastProductLetters = new string(lastProductCode.Where(char.IsLetter).ToArray());
            int number = int.Parse(lastProductDigits);

            return lastProductLetters + (++number).ToString("D4");
        }
    }
}
