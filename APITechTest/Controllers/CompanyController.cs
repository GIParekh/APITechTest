using APITechTest.DatabaseContext;
using APITechTest.DataModel;
using APITechTest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

using APITechTest.Repositories;

namespace APITechTest.Controllers
{
    
    [ApiController]
    public class CompanyController : ControllerBase
    {

        //private readonly MyDatabaseContext _dbcontext;

        //public CompanyController(MyDatabaseContext dbcontext)
        //{
        //    _dbcontext = dbcontext;
        //}

        private readonly ICompanyRepository _companyRepository;
        public CompanyController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }


        [HttpGet]
        [Route("GetCompanies")]
        public async Task<IActionResult> GetCompanies()
        {
            return Ok(_companyRepository.GetCompanies().ToList());
        }

    }
}
