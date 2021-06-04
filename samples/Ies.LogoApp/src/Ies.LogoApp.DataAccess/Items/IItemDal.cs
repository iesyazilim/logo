using Allegory.Standart.Filter.Concrete;
using Ies.LogoApp.Entities.Items;

namespace Ies.LogoApp.DataAccess.Items
{
    public interface IItemDal
    {
        ItemDto GetAsync(Condition conditions = null);
    }
}
