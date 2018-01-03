using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Components.Core.Abstraction
{
    public abstract class Controller
    {
        protected string _context;
        protected string _view;

        public Controller(string context, string view)
        {
            _context = context;
            _view = view;
        }

        public void Render(string view)
        {
            throw new NotImplementedException();
        }

        protected bool CanRender(string view)
        {
            throw new NotImplementedException();
        }
    }
}
