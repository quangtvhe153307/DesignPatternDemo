using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Friend
    {
        protected IMediator mediator;
        private string name;
        private string status;
        public string Name { get { return name; } set { name = value; } }
        public string Status { get { return status; } set { status = value; } }

        public Friend(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
