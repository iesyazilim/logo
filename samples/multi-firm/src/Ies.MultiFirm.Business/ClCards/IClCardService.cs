using System.Collections.Generic;
using System.Threading.Tasks;
using Ies.Logo.DataType.ArAps;
using Ies.Logo.Manager;

namespace Ies.MultiFirm.ClCards
{
    public interface IClCardService : ILogoCrudService<ArAp>
    {
        Task<List<GetClCardListDto>> GetListAsync();
        void PreviousFirmInfo();
    }
}
