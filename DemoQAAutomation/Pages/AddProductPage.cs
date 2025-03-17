using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQAAutomation.Pages
{
    public class AddProductPage
    {
        public void AddProduct(string name, int price, int dateStocked)
        {
            Console.WriteLine("NameProducts :" +name+"Price Products :"+price+"Date Stocked :"+dateStocked);
        }
        public void Submit()
        {
            Console.WriteLine("Submit");
        }
        public void Cancel()
        {
            Console.WriteLine("Cancel");
        }
    }
}
