using System.Linq;
using System.Threading.Tasks;
using DNDApp.Common.Enums;
using DNDApp.Common.Interfaces;
using DNDApp.Common.Models;
using DNDApp.Common.Validation;
using DNDApp.Data.Entities;

namespace DNDApp.Validation.Validations
{
    public class ExistsValidation<TModel> : ValidationBase<TModel> 
    where TModel : EntityBase
    {
        private readonly IRepository _repo;

        public ExistsValidation(IRepository repo)
        {
            _repo = repo;
        }

        public override async Task ValidateAsync(ValidationRequest<TModel> request)
        {
            var tasks = request.Items.Select(item => Task.Run(() =>
                {
                    if (_repo.GetItem<TModel>(m => m.Id == item.Id)?.Id == null)
                    {
                        request.AddValidationMessage($"Object not found by id of type {typeof(TModel)}", ValidationMessageType.ValidationError);
                    }
                }))
                .ToList();

            await Task.WhenAll(tasks);
        }
    }
}