using System.Threading.Tasks;
using DNDApp.Common.Interfaces;
using DNDApp.Common.Models;
using DNDApp.Common.Validation;
using DNDApp.Data.Entities;

namespace DNDApp.Validation.Validators
{
    public class CreateCampaignValidator : ValidatorBase<CampaignEntity>, IValidator<CampaignEntity>
    {
        private readonly IRepository _repo;

        public CreateCampaignValidator(IRepository repo)
        {
            _repo = repo;
            ValidationSequence = new ValidationBase<CampaignEntity>[]
            {

            };
        }

        public Task<ProcessingRequest<CampaignEntity>> Validate(CampaignEntity entity)
        {
            return ValidateSequence(entity);
        }
    }
}