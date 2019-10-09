using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;

namespace CareerCloud.WebAPI.Controllers
{
    [RoutePrefix("api/careercloud/applicant/v1")]
    public class ApplicantSkillController : ApiController
    {
        private readonly ApplicantSkillLogic _logic;

        public ApplicantSkillController()
        {
            var repository = new EFGenericRepository<ApplicantSkillPoco>(false);
            _logic = new ApplicantSkillLogic(repository);
        }

        [HttpGet]
        [Route("skill/{applicantSkillId}")]
        [ResponseType(typeof(ApplicantSkillPoco))]
        public IHttpActionResult GetApplicantSkill(Guid applicantSkillId)
        {
            ApplicantSkillPoco applicantSkill = _logic.Get(applicantSkillId);
            if (applicantSkill == null)
            {
                return NotFound();
            }

            return Ok(applicantSkill);
        }

        [HttpGet]
        [Route("skill")]
        [ResponseType(typeof(List<ApplicantSkillPoco>))]
        public IHttpActionResult GetAllApplicantSkill()
        {
            List<ApplicantSkillPoco> listOfApplicantSkill = _logic.GetAll();
            if (listOfApplicantSkill == null)
            {
                return NotFound();
            }
            return Ok(listOfApplicantSkill);
        }

        [HttpPost]
        [Route("skill")]
        public IHttpActionResult PostApplicantSkill([FromBody] ApplicantSkillPoco[] pocos)
        {
            _logic.Add(pocos);
            return Ok();
        }

        [HttpPut]
        [Route("skill")]
        public IHttpActionResult PutApplicantSkill([FromBody] ApplicantSkillPoco[] pocos)
        {
            _logic.Update(pocos);
            return Ok();
        }

        [HttpDelete]
        [Route("skill")]
        public IHttpActionResult DeleteApplicantSkill([FromBody] ApplicantSkillPoco[] pocos)
        {
            _logic.Delete(pocos);
            return Ok();
        }
    }
}
