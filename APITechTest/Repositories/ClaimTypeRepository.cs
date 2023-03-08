using APITechTest.DatabaseContext;
using APITechTest.DataModel;
using APITechTest.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace APITechTest.Repositories
{
    public class ClaimTypeRepository : IClaimTypeRepository
    {
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
