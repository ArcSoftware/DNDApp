using System.Threading.Tasks;
using DNDApp.Common.Models;

namespace DNDApp.Common.Validation
{
    public interface IValidator<TModel>
    {
        Task<ProcessingRequest<TModel>> Validate(TModel item);
    }
}