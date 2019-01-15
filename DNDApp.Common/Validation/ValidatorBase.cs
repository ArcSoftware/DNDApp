using System.Threading.Tasks;
using DNDApp.Common.Models;

namespace DNDApp.Common.Validation
{
    public abstract class ValidatorBase<TModel>
    {
        protected ValidationBase<TModel>[] ValidationSequence;

        protected virtual async Task<ProcessingRequest<TModel>> ValidateSequence(TModel item)
        {
            var request = new ProcessingRequest<TModel>
            {
                Item = item
            };

            foreach (var v in ValidationSequence)
            {
                await v.ValidateAsync(request);
            }

            return request;
        }
    }
}