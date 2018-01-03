using FriendlyBudget.LocalClient.App.ViewModels;
using FriendlyBudget.LocalClient.Components.Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.App.Controllers
{
    class FamilyController : Controller
    {
        private FamilyViewModel _viewModel;

        public FamilyController() : base("family", "finances")
        {
            _viewModel = new FamilyViewModel();
        }

        public void Finances()
        {
            _view = "finances";
            Render(_view);
        }

        public void Members()
        {
            _view = "members";
            Render(_view);
        }
    }
}
