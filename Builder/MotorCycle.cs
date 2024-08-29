using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class MotorCycle : IBuilder
    {
        private string modelName;
        private Product product;

        public MotorCycle(string modelName)
        {
            this.modelName = modelName;
            product = new Product();
        }

        public void AddHeadlines()
        {
            product.Add("1 headline is added");
        }

        public void BuildBody()
        {
            product.Add("This is body of MotorCycle");
        }

        public void EndOperation()
        {
            product.Add(string.Format("MotorCycle model name : {0}", modelName));
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

        }
    }
}
