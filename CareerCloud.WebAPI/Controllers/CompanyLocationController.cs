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
    public class CompanyLocationController : ApiController
    {
        private readonly CompanyLocationLogic _logic;

        public CompanyLocationController()
        {
            var repository = new EFGenericRepository<CompanyLocationPoco>(false);
            _logic = new CompanyLocationLogic(repository);
        }

        [HttpGet]
        [Route("location/{companyLocationId}")]
        [ResponseType(typeof(CompanyLocationPoco))]
        public IHttpActionResult GetCompanyLocation(Guid companyLocationId)
        {
            CompanyLocationPoco companyLocation = _logic.Get(companyLocationId);
            if (companyLocation == null)
            {
                return NotFound();
            }

            return Ok(companyLocation);
        }

        [HttpGet]
        [Route("location")]
        [ResponseType(typeof(List<CompanyLocationPoco>))]
        public IHttpActionResult GetAllCompanyLocation()
        {
            List<CompanyLocationPoco> listOfCompanyLocation = _logic.GetAll();
            if (listOfCompanyLocation == null)
            {
                return NotFound();
            }
            return Ok(listOfCompanyLocation);
        }

        [HttpPost]
        [Route("location")]
        public IHttpActionResult PostCompanyLocation([FromBody] CompanyLocationPoco[] pocos)
        {
            _logic.Add(pocos);
            return Ok();
        }

        [HttpPut]
        [Route("location")]
        public IHttpActionResult PutCompanyLocation([FromBody] CompanyLocationPoco[] pocos)
        {
            _logic.Update(pocos);
            return Ok();
        }

        [HttpDelete]
        [Route("location")]
        public IHttpActionResult DeleteCompanyLocation([FromBody] CompanyLocationPoco[] pocos)
        {
            _logic.Delete(pocos);
            return Ok();
        }
    }
}
