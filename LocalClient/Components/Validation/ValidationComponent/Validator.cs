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
        private List<ValidationRule> _ruleSetEntities;

        public bool IsValid
        {
            get { return _isValid; }
            set => _isValid = value;
        }

        public Validator()
        {
            _ruleSetEntities = new List<ValidationRule>();
        }

        public bool Validate(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Validate(string entityType, T entity)
        {
            throw new NotImplementedException();
        }

        public bool Validate(Dictionary<string, string> ruleSet, T entity)
        {
            ParseValidationRules(ruleSet);

            bool result = ValidateInternal(entity);

            return result;
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

        private void ParseValidationRules(Dictionary<string, string> ruleSet)
        {
            foreach(KeyValuePair<string, string> rule in ruleSet)
            {
                string name = rule.Key;
                string content = rule.Value;
                ValidationRule ruleEntity = new ValidationRule(name, content);
                _ruleSetEntities.Add(ruleEntity);
            }
        }

        private void ParseValidationRules(string field, string rule)
        {
            ValidationRule ruleEntity = new ValidationRule(field, rule);
            _ruleSetEntities.Add(ruleEntity);
        }

        private void ParseValidationRules(ValidationRule rule)
        {
            _ruleSetEntities.Add(rule);
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

        private bool ValidateInternal(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
