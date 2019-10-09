using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;

namespace CareerCloud.WebAPI.Controllers
{
    [RoutePrefix("api/careercloud/security/v1")]
    public class SecurityLoginController : ApiController
    {
        private readonly SecurityLoginLogic _logic;

        public SecurityLoginController()
        {
            var repository = new EFGenericRepository<SecurityLoginPoco>(false);
            _logic = new SecurityLoginLogic(repository);
        }

        [HttpGet]
        [Route("login/{securityLoginId}")]
        [ResponseType(typeof(SecurityLoginPoco))]
        public IHttpActionResult GetSecurityLogin(Guid securityLoginId)
        {
            SecurityLoginPoco securityLogin = _logic.Get(securityLoginId);
            if (securityLogin == null)
            {
                return NotFound();
            }

            return Ok(securityLogin);
        }

        [HttpGet]
        [Route("login")]
        [ResponseType(typeof(List<SecurityLoginPoco>))]
        public IHttpActionResult GetAllSecurityLogin()
        {
            List<SecurityLoginPoco> listOfSecurityLogin = _logic.GetAll();
            if (listOfSecurityLogin == null)
            {
                return NotFound();
            }
            return Ok(listOfSecurityLogin);
        }

        [HttpPost]
        [Route("login")]
        public IHttpActionResult PostSecurityLogin([FromBody] SecurityLoginPoco[] pocos)
        {
            _logic.Add(pocos);
            return Ok();
        }

        [HttpPut]
        [Route("login")]
        public IHttpActionResult PutSecurityLogin([FromBody] SecurityLoginPoco[] pocos)
        {
            _logic.Update(pocos);
            return Ok();
        }

        [HttpDelete]
        [Route("login")]
        public IHttpActionResult DeleteSecurityLogin([FromBody] SecurityLoginPoco[] pocos)
        {
            _logic.Delete(pocos);
            return Ok();
        }
    }
}
