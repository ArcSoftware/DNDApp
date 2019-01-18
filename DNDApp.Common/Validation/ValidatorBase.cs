using System.Collections.Generic;
using System.Threading.Tasks;
using DNDApp.Common.Enums;
using DNDApp.Common.Models;

namespace DNDApp.Common.Validation
{
    public abstract class ValidatorBase<TModel>
    {
        protected ValidationBase<TModel>[] ValidationSequence;

        protected virtual async Task<ValidationRequest<TModel>> ValidateSequence(IEnumerable<TModel> items)
        {
            var request = new ValidationRequest<TModel>
            {
                Items = items
            };

            foreach (var v in ValidationSequence)
            {
                await v.ValidateAsync(request);
            }

            if (request.Messages.Count > 0)
            {
                foreach (var message in request.Messages)
                {
                    request.IsValid = (message.Type != ValidationMessageType.ValidationError);
                }
            }
            else request.IsValid = true;           

            return request;
        }
    }
}