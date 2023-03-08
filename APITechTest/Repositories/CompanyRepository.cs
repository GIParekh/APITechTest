using APITechTest.DatabaseContext;
using APITechTest.DataModel;
using APITechTest.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace APITechTest.Repositories
{
    public class CompanyRepository: ICompanyRepository
    {
        //public CompanyRepository()
        //{
        //    using (var context = new MyDatabaseContext())
        //    {
        //        var companies = new List<CompanyDataModel>
        //        {
        //            new CompanyDataModel
        //            {
        //                Id =1,
        //                Name ="Company 1",
        //                Address1 ="Company 1 Address 1",
        //                Address2 ="Company 1 Address 2",
        //                Address3 ="Company 1 Address 3",
        //                Postcode ="Company 1 Postcode",
        //                Country ="Company 1 Country",
        //                Active = true,
        //                InsuranceEndDate = DateTime.Now.AddMonths(12), //Convert.ToDateTime("2024-03-01 00:00:00"),
        //            },
        //            new CompanyDataModel
        //            {
        //                Id =2,
        //                Name ="Company 2",
        //                Address1 ="Company 2 Address 1",
        //                Address2 ="Company 2 Address 2",
        //                Address3 ="Company 2 Address 3",
        //                Postcode ="Company 2 Postcode",
        //                Country = "Company 2 Country",
        //                Active = true,
        //                InsuranceEndDate = DateTime.Now.AddMonths(10),//Convert.ToDateTime("2025-03-01 00:00:00"),
        //            },
        //            new CompanyDataModel
        //            {
        //                Id =3,
        //                Name ="Company 3",
        //                Address1 ="Company 3 Address 1",
        //                Address2 ="Company 3 Address 2",
        //                Address3 ="Company 3 Address 3",
        //                Postcode ="Company 3 Postcode",
        //                Country = "Company 3 Country",
        //                Active = true,
        //                InsuranceEndDate = DateTime.Now.AddMonths(8), //Convert.ToDateTime("2026-03-01 00:00:00"),
        //            },
        //        };
        //        context.Companies.AddRange(companies);
        //        context.SaveChanges();
        //    }
        //}
        public List<CompanyDataModel> GetCompanies()
        {
            using (var context = new MyDatabaseContext())
            {
                var list = context.Companies
                    .ToList();
                return list;
            }
        }


    }
}
