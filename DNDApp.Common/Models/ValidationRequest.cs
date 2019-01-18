using System.Collections.Generic;
using DNDApp.Common.Enums;

namespace DNDApp.Common.Models
{
    public class ValidationRequest<TModel>
    {
        public ValidationRequest()
        {
            Messages = new List<ValidationMessageModel>();
        }

        public bool IsValid { get; set; }

        public IEnumerable<TModel> Items { get; set; }

        public List<ValidationMessageModel> Messages { get; set; }

        public void AddValidationMessage(string message, ValidationMessageType type)
        {
            Messages.Add(new ValidationMessageModel(message, type));
        }
    }
}