using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlyBudget.LocalClient.Components.Core.Interfaces;
using FriendlyBudget.LocalClient.Components.Core.Abstraction;

namespace FriendlyBudget.LocalClient.Components.Validation.MoneyValidatorComponent
{
    public class MoneyValidator : IValidator<MoneyObject>
    {
        private MoneyObject _moneyObject;
        private bool _isValid = false;

        public bool IsValid
        {
            get { return _isValid; }
            set => _isValid = value;
        }

        public bool Validate(MoneyObject item)
        {
            _moneyObject = item;

            TryValidate();

            return IsValid;
        }

        //TODO: Implement way to account for the setting of FamilyMember property, which cannot be null for a MoneyObject
        private void TryValidate()
        {
            if(!String.IsNullOrWhiteSpace(_moneyObject.Name) &&
               _moneyObject.Amount > 0 &&
               _moneyObject.Date != null &&
               _moneyObject.Person != null)
            {
                IsValid = true;
            }
        }
    }
}
