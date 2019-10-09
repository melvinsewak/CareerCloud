using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;

namespace CareerCloud.WebAPI.Controllers
{
    [RoutePrefix("api/careercloud/system/v1")]
    public class SystemLanguageCodeController : ApiController
    {
        private readonly SystemLanguageCodeLogic _logic;

        public SystemLanguageCodeController()
        {
            var repository = new EFGenericRepository<SystemLanguageCodePoco>(false);
            _logic = new SystemLanguageCodeLogic(repository);
        }

        [HttpGet]
        [Route("languagecode/{systemLanguageCodeId}")]
        [ResponseType(typeof(SystemLanguageCodePoco))]
        public IHttpActionResult GetSystemLanguageCode(string systemLanguageCodeId)
        {
            SystemLanguageCodePoco systemLanguageCode = _logic.Get(systemLanguageCodeId);
            if (systemLanguageCode == null)
            {
                return NotFound();
            }

            return Ok(systemLanguageCode);
        }

        [HttpGet]
        [Route("languagecode")]
        [ResponseType(typeof(List<SystemLanguageCodePoco>))]
        public IHttpActionResult GetAllSystemLanguageCode()
        {
            List<SystemLanguageCodePoco> listOfSystemLanguageCode = _logic.GetAll();
            if (listOfSystemLanguageCode == null)
            {
                return NotFound();
            }
            return Ok(listOfSystemLanguageCode);
        }

        [HttpPost]
        [Route("languagecode")]
        public IHttpActionResult PostSystemLanguageCode([FromBody] SystemLanguageCodePoco[] pocos)
        {
            _logic.Add(pocos);
            return Ok();
        }

        [HttpPut]
        [Route("languagecode")]
        public IHttpActionResult PutSystemLanguageCode([FromBody] SystemLanguageCodePoco[] pocos)
        {
            _logic.Update(pocos);
            return Ok();
        }

        [HttpDelete]
        [Route("languagecode")]
        public IHttpActionResult DeleteSystemLanguageCode([FromBody] SystemLanguageCodePoco[] pocos)
        {
            _logic.Delete(pocos);
            return Ok();
        }
    }
}
