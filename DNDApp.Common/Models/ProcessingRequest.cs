using System.Collections.Generic;
using DNDApp.Common.Enums;

namespace DNDApp.Common.Models
{
    public class ProcessingRequest<TModelType>
    {
        public ProcessingRequest()
        {
            Messages = new List<ProcessingMessageModel>();
        }

        public bool IsValid { get; set; }

        public TModelType Item { get; set; }

        public List<ProcessingMessageModel> Messages { get; set; }

        public void AddValidationMessage(string message, ProcessingMessageType type)
        {
            Messages.Add(new ProcessingMessageModel(message, type));
        }
    }
}