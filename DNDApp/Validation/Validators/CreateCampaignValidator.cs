using System.Collections.Generic;
using System.Threading.Tasks;
using DNDApp.Common.Interfaces;
using DNDApp.Common.Models;
using DNDApp.Common.Validation;
using DNDApp.Data.Entities;

namespace DNDApp.Validation.Validators
{
    public class CreateCampaignValidator : ValidatorBase<CampaignEntity>, ISingleEntityValidator<CampaignEntity>
    {
        private readonly IRepository _repo;

        public CreateCampaignValidator(IRepository repo)
        {
            _repo = repo;
            ValidationSequence = new ValidationBase<CampaignEntity>[]
            {

            };
        }

        public Task<ValidationRequest<CampaignEntity>> Validate(IEnumerable<CampaignEntity> items)
        {
            return ValidateSequence(items);
        }
    }
}