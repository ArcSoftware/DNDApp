using System.Threading.Tasks;
using DNDApp.Common.Models;

namespace DNDApp.Common.Validation
{
    public abstract class ValidationBase<TModelType>
    {
        public abstract Task ValidateAsync(ProcessingRequest<TModelType> request);
    }
}