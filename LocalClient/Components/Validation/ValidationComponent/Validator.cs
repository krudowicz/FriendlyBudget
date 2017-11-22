using FriendlyBudget.LocalClient.Components.Core.Abstraction;
using FriendlyBudget.LocalClient.Components.Core.Interfaces;
using FriendlyBudget.LocalClient.Components.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Components.Validation
{
    public class Validator<T> : ValidatorCore<T>, IValidator<T>
    {
        private bool _isValid = false;

        public bool IsValid
        {
            get { return _isValid; }
            set => _isValid = value;
        }

        public Validator()
        {
            
        }

        public bool Validate(string entityType, T entity)
        {
            throw new NotImplementedException();
        }

        public bool Validate(List<ValidationRule> ruleSet, T entity)
        {
            throw new NotImplementedException();
        }

        public bool Validate(ValidationRule rule, T entity)
        {
            throw new NotImplementedException(); 
        }

        private void ParseValidationRules(ValidationRule rule)
        {
            string ruleName = rule.Name;
            string ruleContent = rule.Content;
            _ruleSet.Add(ruleName, ruleContent);
        }

        private void ParseValidationRules(List<ValidationRule> ruleSetEntities)
        {
            if(ruleSetEntities.Count == 0 || ruleSetEntities == null)
            {
                return;
            }

            if(ruleSetEntities.Count == 1)
            {
                string ruleName = ruleSetEntities[1].Name;
                string ruleContent = ruleSetEntities[1].Content;
                _ruleSet.Add(ruleName, ruleContent);
            }

            if(ruleSetEntities.Count > 1)
            {
                foreach(ValidationRule rule in ruleSetEntities)
                {
                    string ruleName = rule.Name;
                    string ruleContent = rule.Content;
                    _ruleSet.Add(ruleName, ruleContent);
                }
            }
        }

        private bool ValidateInternal(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
