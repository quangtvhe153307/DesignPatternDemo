using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class BaseEngineering
    {
        public void Paper()
        {
            Math();
            SoftSkills();
            if (IsAdditionalPaperNeeded())
            {
                AdditionalPaper();
            }
            SpecialPaper();
        }
        private void Math()
        {
            Console.WriteLine("Math");
        }
        private void SoftSkills()
        {
            Console.WriteLine("Soft skills");
        }
        private void AdditionalPaper()
        {
            Console.WriteLine("AdditionalPaper");
        }
        protected virtual bool IsAdditionalPaperNeeded()
        {
            return true;
        }
        protected abstract void SpecialPaper();
    }
}
