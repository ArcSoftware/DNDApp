using System.Collections.Generic;
using DNDApp.Common.Enums;

namespace DNDApp.Common.Models
{
    public class ProcessingRequest<TModelType>
    {
        public ProcessingRequest()
        {
        }

        public bool IsValid { get; set; }

        public TModelType Item { get; set; }

        public List<ProcessingMessageModel> Messages { get; set; }

        public void AddValidationErrorMessage(string message)
        {
            Messages.Add(new ProcessingMessageModel(message, ProcessingMessageType.ValidationError));
        }
    }
}