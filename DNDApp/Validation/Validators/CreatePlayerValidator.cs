using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNDApp.Common.Interfaces;
using DNDApp.Common.Models;
using DNDApp.Common.Validation;

namespace DNDApp.Validation.Validators
{
    public class CreatePlayerValidator : ValidatorBase<Player>, IValidator<Player>
    {
        private readonly IRepository _repo; 

        public CreatePlayerValidator(IRepository repo)
        {
            _repo = repo;
            ValidationSequence = new ValidationBase<Player>[]
            {
                //Validations here
            };
        }

        public Task<ProcessingRequest<Player>> ValidateSequence(Player model)
        {
            throw new NotImplementedException();
        }
    }
}
