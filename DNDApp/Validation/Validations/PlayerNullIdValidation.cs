using System.Threading.Tasks;
using DNDApp.Common.Enums;
using DNDApp.Common.Models;
using DNDApp.Common.Validation;
using DNDApp.Data.Entities;

namespace DNDApp.Validation.Validations
{
    public class PlayerNullIdValidation<TModel> : ValidationBase<TModel>
        where TModel : PlayerEntity
    {
        public PlayerNullIdValidation()
        {
        }

        public override async Task ValidateAsync(ValidationRequest<TModel> request)
        {
//            if (request.FirstItem.Id != null)
//            {
//                await Task.Run(() => request.AddValidationMessage(
//                    $"Requested objects to create must have null Ids.",
//                    ValidationMessageType.ValidationError));
//            }
        }
    }
}