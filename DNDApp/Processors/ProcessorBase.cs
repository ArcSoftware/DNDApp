using System.Linq;
using System.Threading.Tasks;
using DNDApp.Common.Interfaces;
using DNDApp.Common.Models;
using DNDApp.Common.Validation;

namespace DNDApp.Processors
{
    public abstract class ProcessorBase<TModel>
    where TModel : class
    {
        private readonly IValidator<TModel> _validator;
        private readonly IRepository _repo;

        protected ProcessorBase(IValidator<TModel> validator, IRepository repo)
        {
            _validator = validator;
            _repo = repo;
        }

        public abstract ProcessingRequest<TModel> GetById(TModel model);

//        public abstract Task<ProcessingRequest<TModel>> Process(TModel model);

        protected virtual async Task<ProcessingRequest<TModel>> ProcessCreate(TModel model)
        {
            var processingRequest = await _validator.ValidateSequence(model);
            if (processingRequest.IsValid)
            {
                _repo.Create(model);
            }

            return processingRequest;
        }
    }
}