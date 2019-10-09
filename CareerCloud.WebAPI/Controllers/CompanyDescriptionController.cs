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
    public class CompanyDescriptionController : ApiController
    {
        private readonly CompanyDescriptionLogic _logic;

        public CompanyDescriptionController()
        {
            var repository = new EFGenericRepository<CompanyDescriptionPoco>(false);
            _logic = new CompanyDescriptionLogic(repository);
        }

        [HttpGet]
        [Route("description/{companyDescriptionId}")]
        [ResponseType(typeof(CompanyDescriptionPoco))]
        public IHttpActionResult GetCompanyDescription(Guid companyDescriptionId)
        {
            CompanyDescriptionPoco companyDescription = _logic.Get(companyDescriptionId);
            if (companyDescription == null)
            {
                return NotFound();
            }

            return Ok(companyDescription);
        }

        [HttpGet]
        [Route("description")]
        [ResponseType(typeof(List<CompanyDescriptionPoco>))]
        public IHttpActionResult GetAllCompanyDescription()
        {
            List<CompanyDescriptionPoco> listOfCompanyDescription = _logic.GetAll();

            if (listOfCompanyDescription == null)
            {
                return NotFound();
            }

            return Ok(listOfCompanyDescription);
        }

        [HttpPost]
        [Route("description")]
        public IHttpActionResult PostCompanyDescription([FromBody] CompanyDescriptionPoco[] pocos)
        {
            _logic.Add(pocos);
            return Ok();
        }

        [HttpPut]
        [Route("description")]
        public IHttpActionResult PutCompanyDescription([FromBody] CompanyDescriptionPoco[] pocos)
        {
            _logic.Update(pocos);
            return Ok();
        }

        [HttpDelete]
        [Route("description")]
        public IHttpActionResult DeleteCompanyDescription([FromBody] CompanyDescriptionPoco[] pocos)
        {
            _logic.Delete(pocos);
            return Ok();
        }
    }
}
