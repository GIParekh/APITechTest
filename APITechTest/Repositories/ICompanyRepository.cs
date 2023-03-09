using APITechTest.DataModel;
using APITechTest.ViewModels;

namespace APITechTest.Repositories
{
    public interface ICompanyRepository
    {
        public CompanyWithInsuranceStatusViewModel GetCompanyWithInsuranceStatusById(int id);
        public IEnumerable<ClaimDataModel> GetClaimsByCompanyId(int companyid);

        public IEnumerable<ClaimViewModel> GetClaimWithDaysById(string ucr);

        public bool UpdateClaim(ClaimDataModel model); 
    }
}
