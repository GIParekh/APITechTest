using APITechTest.DataModel;

namespace APITechTest.Repositories
{
    public interface IClaimRepository
    {
        public List<ClaimDataModel> GetClaims();
    }
}
