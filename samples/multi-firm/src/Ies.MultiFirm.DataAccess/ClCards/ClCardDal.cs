using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Ies.MultiFirm.Configuration;

namespace Ies.MultiFirm.ClCards
{
    public class ClCardDal : IClCardDal
    {
        private readonly ILogoExtendedConfiguration _configuration;

        public ClCardDal(ILogoExtendedConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<List<GetClCardListDto>> GetListAsync()
        {
            using (var connection = _configuration.Create())
            {
                string query = string.Format(@"
                WITH ClCards AS(
	                SELECT 
	                LOGICALREF DataReference, 
	                CODE Code, 
	                DEFINITION_ [Definition], 
	                NAME Name, SURNAME Surname, 
	                ACTIVE Active 
	                FROM  LG_{0}_CLCARD 
	                WHERE CARDTYPE<>22
                )
                SELECT * FROM ClCards
                ",_configuration.FirmNumber);

                return (await connection.QueryAsync<GetClCardListDto>(query)).ToList();
            }
        }
    }
}
