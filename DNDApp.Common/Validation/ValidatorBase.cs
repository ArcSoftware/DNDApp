using System.Threading.Tasks;
using DNDApp.Common.Models;

namespace DNDApp.Common.Validation
{
    public abstract class ValidatorBase<T>
    {
        protected ValidationBase<T>[] ValidationSequence;

        protected virtual async Task<ProcessingRequest<T>> ValidateSequence(T item)
        {
            var request = new ProcessingRequest<T>
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