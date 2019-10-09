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
    public class ApplicantEducationController : ApiController
    {
        private readonly ApplicantEducationLogic _logic;

        public ApplicantEducationController()
        {
            var repository = new EFGenericRepository<ApplicantEducationPoco>(false);
            _logic = new ApplicantEducationLogic(repository);
        }

        [HttpGet]
        [Route("education/{applicantEducationId}")]
        [ResponseType(typeof(ApplicantEducationPoco))]
        public IHttpActionResult GetApplicantEducation(Guid applicantEducationId)
        {
            ApplicantEducationPoco applicantEducation = _logic.Get(applicantEducationId);
            if (applicantEducation == null)
            {
                return NotFound();
            }

            return Ok(applicantEducation);
        }

        [HttpGet]
        [Route("education")]
        [ResponseType(typeof(List<ApplicantEducationPoco>))]
        public IHttpActionResult GetAllApplicantEducation()
        {
            List<ApplicantEducationPoco> listOfApplicantEducation = _logic.GetAll();
            if (listOfApplicantEducation == null)
            {
                return NotFound();
            }
            return Ok(listOfApplicantEducation);
        }

        [HttpPost]
        [Route("education")]
        public IHttpActionResult PostApplicantEducation([FromBody] ApplicantEducationPoco[] pocos)
        {
            _logic.Add(pocos);
            return Ok();
        }

        [HttpPut]
        [Route("education")]
        public IHttpActionResult PutApplicantEducation([FromBody] ApplicantEducationPoco[] pocos)
        {
            _logic.Update(pocos);
            return Ok();
        }

        [HttpDelete]
        [Route("education")]
        public IHttpActionResult DeleteApplicantEducation([FromBody] ApplicantEducationPoco[] pocos)
        {
            _logic.Delete(pocos);
            return Ok();
        }
    }
}
