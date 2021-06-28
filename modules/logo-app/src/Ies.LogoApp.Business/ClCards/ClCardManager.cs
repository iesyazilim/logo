using Ies.Logo.Core.Configuration;
using Ies.Logo.DataType.ArAps;
using Ies.Logo.Repositories;
using Ies.LogoApp.Abstract;

namespace Ies.LogoApp.ClCards
{
    public class ClCardManager : LogoAppManagerBase<ArAp, GetClCardListDto>, IClCardService
    {
        protected IClCardDal ClCardDal { get; }

        public ClCardManager(
           ILogoConnectionConfiguration configuration,
           ILogoRepository<ArAp> repository,
           IClCardDal clCardDal)
           : base(configuration, repository, clCardDal)
        {
            ClCardDal = clCardDal;
        }
    }
}
