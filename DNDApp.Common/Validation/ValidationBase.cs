using System.Threading.Tasks;
using DNDApp.Common.Models;

namespace DNDApp.Common.Validation
{
    public abstract class ValidationBase<TModel>
    {
        public abstract Task ValidateAsync(ValidationRequest<TModel> request);
    }
}