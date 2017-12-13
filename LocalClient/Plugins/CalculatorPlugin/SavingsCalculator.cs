using FriendlyBudget.LocalClient.Components.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Plugins.CalculatorPlugin
{
    class SavingsCalculator
    {

        #region Private fields

        private FamilyMember _familyMember;

        #endregion

        #region Constructors

        public SavingsCalculator(FamilyMember familyMember)
        {
            _familyMember = familyMember;
        }

        #endregion

        #region Public Methods

        public decimal CalculateAmountLeft()
        {
            throw new NotImplementedException();
        }

        public long CalculateTimeLeft()
        {
            throw new NotImplementedException();
        }

        public decimal CalculateRequiredContribution(string periodLenght)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Methods

        #endregion
    }
}
