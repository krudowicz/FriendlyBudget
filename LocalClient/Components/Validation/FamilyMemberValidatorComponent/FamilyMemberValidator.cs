using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlyBudget.LocalClient.Core.Interfaces;
using FriendlyBudget.LocalClient.Components.DAL.DTO;

namespace FriendlyBudget.LocalClient.Components.Validation.FamilyMemberValidatorComponent
{
    public class FamilyMemberValidator : IValidator<FamilyMember>
    {
        private FamilyMember _familyMember;
        private bool _isValid = false;
        

        public bool IsValid
        {
            get { return _isValid; }
            set => _isValid = value;
        }

        public bool Validate(FamilyMember familyMember)
        {
            _familyMember = familyMember;

            TryValidate();

            return IsValid;
        }

        private void TryValidate()
        {
            if(!String.IsNullOrWhiteSpace(_familyMember.FirstName) &&
               !String.IsNullOrWhiteSpace(_familyMember.LastName))
            {
                IsValid = true;
            }
        }
    }
}
