using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;

namespace CareerCloud.WebAPI.Controllers
{
    [RoutePrefix("api/careercloud/company/v1")]
    public class CompanyProfileController : ApiController
    {
        private readonly CompanyProfileLogic _logic;

        public CompanyProfileController()
        {
            var repository = new EFGenericRepository<CompanyProfilePoco>(false);
            _logic = new CompanyProfileLogic(repository);
        }

        [HttpGet]
        [Route("profile/{companyProfileId}")]
        [ResponseType(typeof(CompanyProfilePoco))]
        public IHttpActionResult GetCompanyProfile(Guid companyProfileId)
        {
            CompanyProfilePoco companyProfile = _logic.Get(companyProfileId);
            if (companyProfile == null)
            {
                return NotFound();
            }

            return Ok(companyProfile);
        }

        [HttpGet]
        [Route("profile")]
        [ResponseType(typeof(List<CompanyProfilePoco>))]
        public IHttpActionResult GetAllCompanyProfile()
        {
            List<CompanyProfilePoco> listOfCompanyProfile = _logic.GetAll();
            if (listOfCompanyProfile == null)
            {
                return NotFound();
            }
            return Ok(listOfCompanyProfile);
        }

        [HttpPost]
        [Route("profile")]
        public IHttpActionResult PostCompanyProfile([FromBody] CompanyProfilePoco[] pocos)
        {
            _logic.Add(pocos);
            return Ok();
        }

        [HttpPut]
        [Route("profile")]
        public IHttpActionResult PutCompanyProfile([FromBody] CompanyProfilePoco[] pocos)
        {
            _logic.Update(pocos);
            return Ok();
        }

        [HttpDelete]
        [Route("profile")]
        public IHttpActionResult DeleteCompanyProfile([FromBody] CompanyProfilePoco[] pocos)
        {
            _logic.Delete(pocos);
            return Ok();
        }
    }
}
