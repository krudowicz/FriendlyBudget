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
            _ruleSet = new Dictionary<string, string>();
        }

        public bool Validate(string entityType, T entity)
        {
            throw new NotImplementedException();
        }

        public bool Validate(List<ValidationRule> ruleSet, T entity)
        {
            ParseValidationRules(ruleSet);
            return ValidateInternal(entity);
        }

        public bool Validate(ValidationRule rule, T entity)
        {
            ParseValidationRules(rule);
            return ValidateInternal(entity);

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
                string ruleName = ruleSetEntities[0].Name;
                string ruleContent = ruleSetEntities[0].Content;
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
            bool result = false;

            foreach(KeyValuePair<string, string> rule in _ruleSet)
            {
                bool valid = CheckValidity(entity);

                if(valid == true)
                {
                    result = true;
                }
            }

            return result;
        }

        private bool CheckValidity(T entity)
        {
            bool result = false;

            Dictionary<string, object> entityProperties = entity.GetType().GetProperties().ToDictionary(x => x.Name, x => x.GetValue(entity));

            foreach (KeyValuePair<string, string> rule in _ruleSet)
            {
                foreach(KeyValuePair<string, object> entityProperty in entityProperties)
                {
                    if(string.Equals(rule.Key.ToLower(), entityProperty.Key.ToLower()))
                    {
                        if(string.Equals(rule.Value.ToLower(), "required") && !string.IsNullOrWhiteSpace(entityProperty.Value.ToString()) && entityProperty.Value != null)
                        {
                            result = true;
                        } else
                        {
                            return false;
                        }
                    }
                }
            }

            return result;
        }
    }
}
