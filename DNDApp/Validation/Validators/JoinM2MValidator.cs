using System.Collections.Generic;
using System.Threading.Tasks;
using DNDApp.Common.Interfaces;
using DNDApp.Common.Models;
using DNDApp.Common.Validation;
using DNDApp.Data.Entities;
using DNDApp.Validation.Validations;

namespace DNDApp.Validation.Validators
{
    public class JoinM2MValidator<TE1, TE2, TJE> : JoinValidatorBase<TE1, TE2, TJE>, IJoinValidator<TE1, TE2, TJE> 
        where TE1 : EntityBase 
        where TE2 : EntityBase
        where TJE : EntityBase
    {
        private readonly IRepository _repo;

        public JoinM2MValidator(IRepository repo)
        {
            _repo = repo;
            ValidationSequence1 = new ValidationBase<TE1>[]
            {
                new ExistsValidation<TE1>(repo)
            };
            ValidationSequence2 = new ValidationBase<TE2>[]
            {
                new ExistsValidation<TE2>(repo), 
            };
        }

        public Task<ValidationRequest<TJE>> Validate(TE1 item1, TE2 item2)
        {
            return ValidateSequences(item1, item2);
        }
    }
}