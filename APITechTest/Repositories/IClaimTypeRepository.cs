using APITechTest.DataModel;

namespace APITechTest.Repositories
{
    public interface IClaimTypeRepository
    {
        public List<ClaimTypeDataModel> GetClaimTypes();
    }
}
