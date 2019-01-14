using System.Threading.Tasks;
using DNDApp.Common.Models;

namespace DNDApp.Common.Validation
{
    public interface IValidator<TModelType>
    {
        Task<ProcessingRequest<TModelType>> ValidateSequence(TModelType model); 
    }
}