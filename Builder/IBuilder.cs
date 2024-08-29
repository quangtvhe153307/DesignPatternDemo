using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IBuilder
    {
        void StartUpOperations();
        void BuildBody();
        void InsertWheel();
        void AddHeadlines();
        void EndOperation();
        Product GetVehicle();
    }
}
