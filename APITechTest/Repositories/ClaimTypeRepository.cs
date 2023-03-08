using APITechTest.DatabaseContext;
using APITechTest.DataModel;
using APITechTest.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace APITechTest.Repositories
{
    public class ClaimTypeRepository : IClaimTypeRepository
    {
        //public ClaimTypeRepository()
        //{
        //    using (var context = new MyDatabaseContext())
        //    {
        //        var claimTypes = new List<ClaimTypeDataModel>
        //        {
        //            new ClaimTypeDataModel
        //            {
        //                Id = 1,
        //                Name = "Claim Type 1",
        //            },
        //            new ClaimTypeDataModel
        //            {
        //                Id = 2,
        //                Name = "Claim Type 2",
        //            },
        //        };
        //        context.ClaimTypes.AddRange(claimTypes);
        //        context.SaveChanges();
        //    }
        //}
        public List<ClaimTypeDataModel> GetClaimTypes()
        {
            using (var context = new MyDatabaseContext())
            {
                var list = context.ClaimTypes
                    .ToList();
                return list;
            }
        }


    }
}
