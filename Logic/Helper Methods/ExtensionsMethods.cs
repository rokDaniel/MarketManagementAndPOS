using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Logic.Business_Layer.Product;

namespace Logic.Extension
{
    public static class ExtensionsMethods
    {
        public static string EnumValue(this eCategory category)
        {
            switch (category)
            {
                case eCategory.FruitsAndVegetables:
                    return "Fruits And Vegetables";
                case eCategory.Diary:
                    return "Diary";
                case eCategory.BakedAndBread:
                    return "Baked And Bread";
                case eCategory.Meat:
                    return "Meat";
                case eCategory.AlcoholAndBeverages:
                    return "Alcohol And Beverages";
                case eCategory.Cooking:
                    return "Cooking";
                default:
                    return "Other";
            }
        }
    }
}
