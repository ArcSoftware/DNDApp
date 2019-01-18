using System.Collections.Generic;
using System.Threading.Tasks;
using DNDApp.Common.Enums;
using DNDApp.Common.Models;

namespace DNDApp.Common.Validation
{
    public abstract class JoinValidatorBase<TM1,TM2,TJE>
    {
        protected ValidationBase<TM1>[] ValidationSequence1;
        protected ValidationBase<TM2>[] ValidationSequence2;

        protected virtual async Task<ValidationRequest<TJE>> ValidateSequences(TM1 item1, TM2 item2)
        {
            var returnRequest = new ValidationRequest<TJE>();

            var tasks = new List<Task>
            {
                Task.Run(() =>
                    returnRequest.Messages.AddRange(RunValidationAsync(item1, ValidationSequence1).Result)),
                Task.Run(() =>
                    returnRequest.Messages.AddRange(RunValidationAsync(item2, ValidationSequence2).Result))
            };

            await Task.WhenAll(tasks); 

            if (returnRequest.Messages.Count > 0)
            {
                foreach (var message in returnRequest.Messages)
                {
                    returnRequest.IsValid = (message.Type != ValidationMessageType.ValidationError);
                }
            }
            else returnRequest.IsValid = true;

            return returnRequest;
        }

        private async Task<List<ValidationMessageModel>> RunValidationAsync<T>(T item, ValidationBase<T>[] sequence)
        {
            var itemToList = new List<T> {item};
            var request = new ValidationRequest<T>
            {
                Items = itemToList
            };

            foreach (var v in sequence)
            {
                await v.ValidateAsync(request);
            }

            return request.Messages;
        }
    }
}
