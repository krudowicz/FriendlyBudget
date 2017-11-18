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
        private List<ValidationRule> _ruleSetEntities;

        public bool IsValid { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Validate(string entityType, T entity)
        {
            throw new NotImplementedException();
        }

        public bool Validate(Dictionary<string, string> ruleSet, T entity)
        {
            throw new NotImplementedException();
        }

        public bool Validate(string field, string rule, T entity)
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

        private void ParseValidationRules()
        {
            if(_ruleSetEntities.Count == 0 || _ruleSetEntities == null)
            {
                return;
            }

            if(_ruleSetEntities.Count == 1)
            {
                string ruleName = _ruleSetEntities[1].Name;
                string ruleContent = _ruleSetEntities[1].Content;
                _ruleSet.Add(ruleName, ruleContent);
            }

            if(_ruleSetEntities.Count > 1)
            {
                foreach(ValidationRule rule in _ruleSetEntities)
                {
                    string ruleName = rule.Name;
                    string ruleContent = rule.Content;
                    _ruleSet.Add(ruleName, ruleContent);
                }
            }
        }
    }
}
