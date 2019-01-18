using System.Collections.Generic;
using System.Threading.Tasks;
using DNDApp.Common.Models;

namespace DNDApp.Common.Validation
{
    public interface ISingleEntityValidator<TModel>
    {
        Task<ValidationRequest<TModel>> Validate(IEnumerable<TModel> items);
    }
}