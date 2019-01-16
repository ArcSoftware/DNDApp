using System.Threading.Tasks;
using DNDApp.Common.Enums;
using DNDApp.Common.Models;
using DNDApp.Common.Validation;

namespace DNDApp.Validation.Validations
{
    public class PlayerNullIdValidation<TModel> : ValidationBase<TModel>
        where TModel : PlayerEntity
    {
        public PlayerNullIdValidation()
        {
        }

        public override async Task ValidateAsync(ProcessingRequest<TModel> request)
        {
            if (request.Item.PlayerId != null)
            {
                await Task.Run(() => request.AddValidationMessage(
                    $"Requested objects to create must have null Ids.",
                    ProcessingMessageType.ValidationError));
            }
        }
    }
}