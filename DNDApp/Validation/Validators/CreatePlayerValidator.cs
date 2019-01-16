using System.Threading.Tasks;
using DNDApp.Common.Interfaces;
using DNDApp.Common.Models;
using DNDApp.Common.Validation;
using DNDApp.Data.Entities;
using DNDApp.Validation.Validations;

namespace DNDApp.Validation.Validators
{
    public class CreatePlayerValidator : ValidatorBase<PlayerEntity>, IValidator<PlayerEntity>
    {
        private readonly IRepository _repo; 

        public CreatePlayerValidator(IRepository repo)
        {
            _repo = repo;
            ValidationSequence = new ValidationBase<PlayerEntity>[]
            {
                new PlayerNullIdValidation<PlayerEntity>()
            };
        }

        public Task<ProcessingRequest<PlayerEntity>> Validate(PlayerEntity entity)
        {
            return ValidateSequence(entity);
        }
    }
}