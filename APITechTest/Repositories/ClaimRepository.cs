using APITechTest.DatabaseContext;
using APITechTest.DataModel;
using APITechTest.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace APITechTest.Repositories
{
    public class ClaimRepository : IClaimRepository
    {
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
