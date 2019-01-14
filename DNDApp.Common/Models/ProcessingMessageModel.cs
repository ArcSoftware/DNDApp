using DNDApp.Common.Enums;

namespace DNDApp.Common.Models
{
    public class ProcessingMessageModel
    {
        public ProcessingMessageModel(string message, ProcessingMessageType type)
        {
            Message = message;
            Type = type;
        }

        public string Message { get; }
        public ProcessingMessageType Type { get; }
    }
}