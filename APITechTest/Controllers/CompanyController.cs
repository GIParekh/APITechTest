using APITechTest.DatabaseContext;
using APITechTest.DataModel;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

using APITechTest.Repositories;
using APITechTest.ViewModels;

using System.Threading.Tasks;
using System.Security.Claims;
using System.Collections.Generic;

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

        /// <summary>
        /// Get the list of all the companies
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetCompanies")]
        public async Task<IActionResult> GetCompanies()
        {
            return Ok(_companyRepository.GetCompanies().ToList());
        }


        /// <summary>
        /// Requirement 1 - Output must be in Json format.
        /// Requirement 2 - We need an endpoint that will give me a single company. 
        /// We need a property to be returned that will tell us if the company has an active insurance policy
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetCompanyWithInsuranceStatusById")]
        public async Task<IActionResult> GetCompanyWithInsuranceStatusById(int Id)
        {
            CompanyWithInsuranceStatusViewModel CompanyWithInsuranceStatusViewModel = _companyRepository.GetCompanyWithInsuranceStatusById(Id);
            if (CompanyWithInsuranceStatusViewModel == null)
            {
                return NotFound();
            }
            return Ok(CompanyWithInsuranceStatusViewModel);
        }

        /// <summary>
        /// Requirement 1 - Output must be in Json format. 
        /// Requirement 3 - We need an endpoint that will give me a list of claims for one company
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetClaimsByCompanyId")]
        public async Task<IActionResult> GetClaimsByCompanyId(int CompanyId)
        {
            IEnumerable<ClaimDataModel> ClaimDataModel = _companyRepository.GetClaimsByCompanyId(CompanyId);
            if (ClaimDataModel == null)
            {
                return NotFound();
            }
            return Ok(ClaimDataModel);
        }

        /// <summary>
        /// Requirement 1 - Output must be in Json format. 
        /// Requirement 4 - We need an endpoint that will give me the details of one claim.
        /// We need a property to be returned that tells us how old the claim is in days
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetClaimWithDaysById")]
        public async Task<IActionResult> GetClaimWithDaysById(string UCR)
        {
            IEnumerable<ClaimViewModel> ClaimViewModel = _companyRepository.GetClaimWithDaysById(UCR);
            if (ClaimViewModel == null)
            {
                return NotFound();
            }
            return Ok(ClaimViewModel);
        }

    }
}
