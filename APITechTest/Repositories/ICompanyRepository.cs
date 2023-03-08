using APITechTest.DataModel;

namespace APITechTest.Repositories
{
    public interface ICompanyRepository
    {
        public List<CompanyDataModel> GetCompanies();
    }
}
