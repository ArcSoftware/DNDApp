using System.Threading.Tasks;
using DNDApp.Common.Models;

namespace DNDApp.Common.Validation
{
    public interface IJoinValidator<TE1, TE2, TJE>
    {
        Task<ValidationRequest<TJE>> Validate(TE1 item1, TE2 item2);
    }
}