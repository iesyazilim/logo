using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ies.MultiFirm.ClCards
{
    public interface IClCardDal
    {
        Task<List<GetClCardListDto>> GetListAsync();
    }
}
