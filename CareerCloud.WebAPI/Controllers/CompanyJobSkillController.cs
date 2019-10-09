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
    public class CompanyJobSkillController : ApiController
    {
        private readonly CompanyJobSkillLogic _logic;

        public CompanyJobSkillController()
        {
            var repository = new EFGenericRepository<CompanyJobSkillPoco>(false);
            _logic = new CompanyJobSkillLogic(repository);
        }

        [HttpGet]
        [Route("jobskill/{companyJobSkillId}")]
        [ResponseType(typeof(CompanyJobSkillPoco))]
        public IHttpActionResult GetCompanyJobSkill(Guid companyJobSkillId)
        {
            CompanyJobSkillPoco companyJobSkill = _logic.Get(companyJobSkillId);
            if (companyJobSkill == null)
            {
                return NotFound();
            }

            return Ok(companyJobSkill);
        }

        [HttpGet]
        [Route("jobskill")]
        [ResponseType(typeof(List<CompanyJobSkillPoco>))]
        public IHttpActionResult GetAllCompanyJobSkill()
        {
            List<CompanyJobSkillPoco> listOfCompanyJobSkill = _logic.GetAll();
            if (listOfCompanyJobSkill == null)
            {
                return NotFound();
            }
            return Ok(listOfCompanyJobSkill);
        }

        [HttpPost]
        [Route("jobskill")]
        public IHttpActionResult PostCompanyJobSkill([FromBody] CompanyJobSkillPoco[] pocos)
        {
            _logic.Add(pocos);
            return Ok();
        }

        [HttpPut]
        [Route("jobskill")]
        public IHttpActionResult PutCompanyJobSkill([FromBody] CompanyJobSkillPoco[] pocos)
        {
            _logic.Update(pocos);
            return Ok();
        }

        [HttpDelete]
        [Route("jobskill")]
        public IHttpActionResult DeleteCompanyJobSkill([FromBody] CompanyJobSkillPoco[] pocos)
        {
            _logic.Delete(pocos);
            return Ok();
        }
    }
}
