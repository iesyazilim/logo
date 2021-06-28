using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ies.Logo.DataType.ArAps;
using Ies.Logo.Manager;
using Ies.Logo.Repositories;
using Ies.MultiFirm.Configuration;

namespace Ies.MultiFirm.ClCards
{
    public class ClCardManager : LogoCrudManager<ArAp>, IClCardService
    {
        private readonly IClCardDal _clCardDal;
        private readonly ILogoExtendedConfiguration _extendedConfiguration;

        public ClCardManager(
            ILogoExtendedConfiguration configuration,
            ILogoRepository<ArAp> repository,
            IClCardDal clCardDal)
            : base(configuration, repository)
        {
            _clCardDal = clCardDal;
            _extendedConfiguration = configuration;
        }

        public async Task<List<GetClCardListDto>> GetListAsync() => await _clCardDal.GetListAsync();

        public void PreviousFirmInfo()
        {
            Console.WriteLine("Önceki firma no : {0}", _extendedConfiguration.OldFirmNumber);
            Console.WriteLine("Önceki firma dönem : {0}", _extendedConfiguration.OldFirmPeriod);
        }
    }
}
