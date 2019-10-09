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
    public class CompanyJobController : ApiController
    {
        private readonly CompanyJobLogic _logic;

        public CompanyJobController()
        {
            var repository = new EFGenericRepository<CompanyJobPoco>(false);
            _logic = new CompanyJobLogic(repository);
        }

        [HttpGet]
        [Route("job/{companyJobId}")]
        [ResponseType(typeof(CompanyJobPoco))]
        public IHttpActionResult GetCompanyJob(Guid companyJobId)
        {
            CompanyJobPoco companyJob = _logic.Get(companyJobId);
            if (companyJob == null)
            {
                return NotFound();
            }

            return Ok(companyJob);
        }

        [HttpGet]
        [Route("job")]
        [ResponseType(typeof(List<CompanyJobPoco>))]
        public IHttpActionResult GetAllCompanyJob()
        {
            List<CompanyJobPoco> listOfCompanyJob = _logic.GetAll();

            if(listOfCompanyJob == null)
            {
                return NotFound();
            }

            return Ok(listOfCompanyJob);
        }

        [HttpPost]
        [Route("job")]
        public IHttpActionResult PostCompanyJob([FromBody] CompanyJobPoco[] pocos)
        {
            _logic.Add(pocos);
            return Ok();
        }

        [HttpPut]
        [Route("job")]
        public IHttpActionResult PutCompanyJob([FromBody] CompanyJobPoco[] pocos)
        {
            _logic.Update(pocos);
            return Ok();
        }

        [HttpDelete]
        [Route("job")]
        public IHttpActionResult DeleteCompanyJob([FromBody] CompanyJobPoco[] pocos)
        {
            _logic.Delete(pocos);
            return Ok();
        }
    }
}
