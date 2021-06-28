using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Ies.Logo.Core.Configuration;

namespace Ies.SampleApp.Items
{
    public class ItemDal : IItemDal
    {
        protected ILogoConnectionConfiguration Configuration { get; }

        public ItemDal(ILogoConnectionConfiguration configuration)
        {
            Configuration = configuration;
        }

        public async Task<List<GetItemListDto>> GetListAsync()
        {
            using (var connection = Configuration.Create())
            {
                string query = $@"
                WITH Item AS(
                SELECT LOGICALREF DataReference, CODE Code, NAME Name, ACTIVE Active FROM  LG_{Configuration.FirmNumber}_ITEMS WHERE CARDTYPE<>22
                ) 
                SELECT * FROM Item 
                ";

                return (await connection.QueryAsync<GetItemListDto>(query)).ToList();
            }
        }
    }
}
