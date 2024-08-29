using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Car : IBuilder
    {
        private string brandName;
        private Product product;

        public Car(string brandName)
        {
            this.brandName = brandName;
            product = new Product();
        }

        public void AddHeadlines()
        {
            product.Add("2 headlines are added");
        }

        public void BuildBody()
        {
            product.Add("This is body of Car");
        }

        public void EndOperation()
        {

        }

        public Product GetVehicle()
        {
            return product;
        }

        public void InsertWheel()
        {
            product.Add("2 wheels are added")
        }

        public void StartUpOperations()
        {
            product.Add(string.Format("Car model name: {0}", brandName));
        }
    }
}
