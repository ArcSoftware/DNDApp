using DNDApp.Common.Enums;

namespace DNDApp.Common.Models
{
    public class ValidationMessageModel
    {
        public ValidationMessageModel(string message, ValidationMessageType type)
        {
            Message = message;
            Type = type;
        }

        public string Message { get; }
        public ValidationMessageType Type { get; }
    }
}