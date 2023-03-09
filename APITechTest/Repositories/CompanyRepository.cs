using APITechTest.DatabaseContext;
using APITechTest.DataModel;
using APITechTest.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Runtime.ConstrainedExecution;

namespace APITechTest.Repositories
{
    public class CompanyRepository: ICompanyRepository
    {
        public static MyDatabaseContext _myDatabaseContext { get; set; }
        public CompanyRepository()
        {
            _myDatabaseContext = new MyDatabaseContext();
        }

        public CompanyWithInsuranceStatusViewModel GetCompanyWithInsuranceStatusById(int id)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException("Id must be a positive number greater than zero.");

            var entity = _myDatabaseContext.Companies.Where(x => x.Id == id).FirstOrDefault();
            CompanyWithInsuranceStatusViewModel result = new CompanyWithInsuranceStatusViewModel
            {
                Id = entity.Id,
                Name = entity.Name,
                Address1 = entity.Address1,
                Address2 = entity.Address2,
                Address3 = entity.Address3,
                Country = entity.Country,
                Postcode = entity.Postcode,
                InsuranceEndDate = entity.InsuranceEndDate,
                Active = entity.Active,

                IsInsurancePolicyActive = DateTime.Now <= Convert.ToDateTime(entity.InsuranceEndDate) ? true : false,
                InsurancePolicyStatus = DateTime.Now <= entity.InsuranceEndDate ? "Active" : "Not Active",
            };
            return result;
        }

        public IEnumerable<ClaimDataModel> GetClaimsByCompanyId(int companyid)
        {
            if (companyid <= 0)
                throw new ArgumentOutOfRangeException("Id must be a positive number greater than zero.");

            IEnumerable<ClaimDataModel> result = _myDatabaseContext.Claims.Where(x => x.CompanyId == companyid).ToList();
            
            return result;
        }

        public IEnumerable<ClaimViewModel> GetClaimWithDaysById(string ucr)
        {
            if (String.IsNullOrEmpty(ucr))
                throw new ArgumentOutOfRangeException("UCR must be a valid name.");

            IEnumerable<ClaimDataModel> entity = _myDatabaseContext.Claims.Where(x => x.UCR.Equals(ucr)).ToList();

            IEnumerable<ClaimViewModel> result = entity.Select(e => new ClaimViewModel
            {
                UCR = e.UCR,
                CompanyId = e.CompanyId,
                ClaimDate = e.ClaimDate,
                LossDate = e.LossDate,
                AssuredName = e.AssuredName,
                IncurredLoss = e.IncurredLoss,
                Closed = e.Closed,

                ClaimDays = (DateTime.Now - Convert.ToDateTime(e.ClaimDate)).Days,
            });

            return result;
        }

        public bool UpdateClaim(ClaimDataModel model)
        {
            bool result = false;

            ClaimDataModel claim = _myDatabaseContext.Claims.Find(model.UCR);
            if (claim != null)
            {
                claim.CompanyId = model.CompanyId;
                claim.ClaimDate = model.ClaimDate;
                claim.LossDate = model.LossDate;
                claim.AssuredName = model.AssuredName;
                claim.Closed = model.Closed;
                claim.IncurredLoss = model.IncurredLoss;

                _myDatabaseContext.SaveChanges();

                result = true;
            }            
            return result;
        }


    }
}
