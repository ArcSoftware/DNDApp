using System;
using System.Threading.Tasks;
using DNDApp.Common.Interfaces;
using DNDApp.Common.Models;
using DNDApp.Common.Validation;
using DNDApp.Data.Entities;

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
                //Validations here
            };
        }

        public Task<ProcessingRequest<PlayerEntity>> ValidateSequence(PlayerEntity model)
        {
            throw new NotImplementedException();
        }
    }
}