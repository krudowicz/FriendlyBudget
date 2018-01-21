using System;
using System.Collections.Generic;
using System.Text;
using FriendlyBudget.Web.Backend.Model.Enums;

namespace FriendlyBudget.Web.Backend.Model.Value_Objects
{
    class Money
    {
        public decimal Amount { get;private  set; }
        public Currency Currency { get; private set; }
        
        public Money(decimal amount, Currency currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public void ConvertTo(Currency currency)
        {
            throw new NotImplementedException();
        }

        public static void Convert(Money money, Currency currency)
        {
            throw new NotImplementedException();
        }

        public static Money operator +(Money firstValue, Money secondValue)
        {
            throw new NotImplementedException();
        }

        public static Money operator -(Money firstValue, Money secondValue)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object money)
        {
            throw new NotImplementedException();
        }

        public bool Equals(Money money)
        {
            throw new NotImplementedException();
        }
    }
}
