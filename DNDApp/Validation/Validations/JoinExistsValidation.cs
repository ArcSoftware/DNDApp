using System.Threading.Tasks;
using DNDApp.Common.Interfaces;
using DNDApp.Common.Models;
using DNDApp.Common.Validation;

namespace DNDApp.Validation.Validations
{
    public class JoinExistsValidation<TModelType> : ValidationBase<TModelType> 
    where TModelType : DNDObjectBase
    {
        private readonly IRepository _repo;

        public JoinExistsValidation(IRepository repo)
        {
            _repo = repo;
        }

        public override async Task ValidateAsync(ProcessingRequest<TModelType> request)
        {
            if (_repo.GetItem<TModelType>(m => m.Id == request.Item.Id)?.Id == null)
            {
                request.AddValidationErrorMessage($"Object not found by id of type {typeof(TModelType)}");
            }
        }
    }
}