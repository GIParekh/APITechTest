using APITechTest.DatabaseContext;
using APITechTest.DataModel;
using APITechTest.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace APITechTest.Repositories
{
    public class ClaimRepository : IClaimRepository
    {
        //public ClaimRepository()
        //{
        //    using (var context = new MyDatabaseContext())
        //    {
        //        var claims = new List<ClaimDataModel>
        //        {
        //            new ClaimDataModel
        //            {
        //                UCR = "UCR 1",
        //                CompanyId =1,
        //                ClaimDate = DateTime.Now.AddDays(-30),
        //                LossDate = DateTime.Now,
        //                AssuredName ="Assured Name 1",
        //                IncurredLoss =Convert.ToDecimal("100.89"),
        //                Closed = true,
        //            },
        //            new ClaimDataModel
        //            {
        //                UCR = "UCR 2",
        //                CompanyId =2,
        //                ClaimDate = DateTime.Now.AddDays(-20),
        //                LossDate = DateTime.Now,
        //                AssuredName ="Assured Name 2",
        //                IncurredLoss =Convert.ToDecimal("200.89"),
        //                Closed = false,
        //            },
        //        };
        //        context.Claims.AddRange(claims);
        //        context.SaveChanges();
        //    }
        //}
        public List<ClaimDataModel> GetClaims()
        {
            using (var context = new MyDatabaseContext())
            {
                var list = context.Claims
                    .ToList();
                return list;
            }
        }


    }
}
