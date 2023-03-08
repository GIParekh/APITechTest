using APITechTest.DatabaseContext;
using APITechTest.DataModel;

namespace APITechTest.Repositories
{
    public class DummyData
    {
        public DummyData()
        {
            CreateDummyCompanies();
            CreateDummyClaimTypes();
            CreateDummyClaims();
        }

        private void CreateDummyCompanies()
        {
            using (var context = new MyDatabaseContext())
            {
                var companies = new List<CompanyDataModel>
                {
                    new CompanyDataModel
                    {
                        Id =1,
                        Name ="Company 1",
                        Address1 ="Company 1 Address 1",
                        Address2 ="Company 1 Address 2",
                        Address3 ="Company 1 Address 3",
                        Postcode ="Company 1 Postcode",
                        Country ="Company 1 Country",
                        Active = true,
                        InsuranceEndDate = DateTime.Now.AddMonths(12), //Convert.ToDateTime("2024-03-01 00:00:00"),
                    },
                    new CompanyDataModel
                    {
                        Id =2,
                        Name ="Company 2",
                        Address1 ="Company 2 Address 1",
                        Address2 ="Company 2 Address 2",
                        Address3 ="Company 2 Address 3",
                        Postcode ="Company 2 Postcode",
                        Country = "Company 2 Country",
                        Active = true,
                        InsuranceEndDate = DateTime.Now.AddMonths(10),//Convert.ToDateTime("2025-03-01 00:00:00"),
                    },
                    new CompanyDataModel
                    {
                        Id =3,
                        Name ="Company 3",
                        Address1 ="Company 3 Address 1",
                        Address2 ="Company 3 Address 2",
                        Address3 ="Company 3 Address 3",
                        Postcode ="Company 3 Postcode",
                        Country = "Company 3 Country",
                        Active = true,
                        InsuranceEndDate = DateTime.Now.AddMonths(8), //Convert.ToDateTime("2026-03-01 00:00:00"),
                    },
                };
                context.Companies.AddRange(companies);
                context.SaveChanges();
            }
        }
        private void CreateDummyClaimTypes()
        {
            using (var context = new MyDatabaseContext())
            {
                var claimTypes = new List<ClaimTypeDataModel>
                {
                    new ClaimTypeDataModel
                    {
                        Id = 1,
                        Name = "Claim Type 1",
                    },
                    new ClaimTypeDataModel
                    {
                        Id = 2,
                        Name = "Claim Type 2",
                    },
                };
                context.ClaimTypes.AddRange(claimTypes);
                context.SaveChanges();
            }
        }
        private void CreateDummyClaims()
        {
            using (var context = new MyDatabaseContext())
            {
                var claims = new List<ClaimDataModel>
                {
                    new ClaimDataModel
                    {
                        UCR = "UCR 1",
                        CompanyId =1,
                        ClaimDate = DateTime.Now.AddDays(-30),
                        LossDate = DateTime.Now,
                        AssuredName ="Assured Name 1",
                        IncurredLoss =Convert.ToDecimal("100.89"),
                        Closed = true,
                    },
                    new ClaimDataModel
                    {
                        UCR = "UCR 2",
                        CompanyId =2,
                        ClaimDate = DateTime.Now.AddDays(-20),
                        LossDate = DateTime.Now,
                        AssuredName ="Assured Name 2",
                        IncurredLoss =Convert.ToDecimal("200.89"),
                        Closed = false,
                    },
                    new ClaimDataModel
                    {
                        UCR = "UCR 3",
                        CompanyId =1,
                        ClaimDate = DateTime.Now.AddDays(-5),
                        LossDate = DateTime.Now,
                        AssuredName ="Assured Name 3",
                        IncurredLoss =Convert.ToDecimal("300.89"),
                        Closed = true,
                    },
                };
                context.Claims.AddRange(claims);
                context.SaveChanges();
            }
        }
    }
}
