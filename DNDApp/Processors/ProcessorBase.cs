using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNDApp.Common.Interfaces;
using DNDApp.Common.Validation;
using DNDApp.Data.Entities;

namespace DNDApp.Processors
{
    public abstract class ProcessorBase<TModel>
    where TModel : class
    {
        private readonly ISingleEntityValidator<TModel> _validator;
        private readonly IRepository _repo;

        protected ProcessorBase(ISingleEntityValidator<TModel> validator, IRepository repo)
        {
            _validator = validator;
            _repo = repo;
        }

        protected virtual async Task<TModel> ProcessCreate(TModel model)
        {
            //Single creation and validation support for now
            var createList = new List<TModel> {model};
            var validationRequest = await _validator.Validate(createList);
            if (validationRequest.IsValid)
            {
                _repo.Create(createList.FirstOrDefault());         
            }

            return validationRequest.Items.FirstOrDefault();
        }

        protected virtual async Task<TJE> Join<TE1,TE2,TJE>(IJoinValidator<TE1,TE2,TJE> validator,
            TE1 item1, TE2 item2) where TJE : EntityBase
        {
            var validationRequest = await validator.Validate(item1, item2);
            if (validationRequest.IsValid)
            {
                _repo.Create(validationRequest.Items.FirstOrDefault());
            }

            return validationRequest.Items.FirstOrDefault();
        }
    }
}