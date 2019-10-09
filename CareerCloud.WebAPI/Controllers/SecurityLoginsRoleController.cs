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
    public class SecurityLoginsRoleController : ApiController
    {
        private readonly SecurityLoginsRoleLogic _logic;

        public SecurityLoginsRoleController()
        {
            var repository = new EFGenericRepository<SecurityLoginsRolePoco>(false);
            _logic = new SecurityLoginsRoleLogic(repository);
        }

        [HttpGet]
        [Route("loginsrole/{securityLoginsRoleId}")]
        [ResponseType(typeof(SecurityLoginsRolePoco))]
        public IHttpActionResult GetSecurityLoginsRole(Guid securityLoginsRoleId)
        {
            SecurityLoginsRolePoco securityLoginsRole = _logic.Get(securityLoginsRoleId);
            if (securityLoginsRole == null)
            {
                return NotFound();
            }

            return Ok(securityLoginsRole);
        }

        [HttpGet]
        [Route("loginsrole")]
        [ResponseType(typeof(List<SecurityLoginsRolePoco>))]
        public IHttpActionResult GetAllSecurityLoginsRole()
        {
            List<SecurityLoginsRolePoco> listOfSecurityLoginsRole = _logic.GetAll();
            if (listOfSecurityLoginsRole == null)
            {
                return NotFound();
            }
            return Ok(listOfSecurityLoginsRole);
        }

        [HttpPost]
        [Route("loginsrole")]
        public IHttpActionResult PostSecurityLoginRole([FromBody] SecurityLoginsRolePoco[] pocos)
        {
            _logic.Add(pocos);
            return Ok();
        }

        [HttpPut]
        [Route("loginsrole")]
        public IHttpActionResult PutSecurityLoginsRole([FromBody] SecurityLoginsRolePoco[] pocos)
        {
            _logic.Update(pocos);
            return Ok();
        }

        [HttpDelete]
        [Route("loginsrole")]
        public IHttpActionResult DeleteSecurityLoginRole([FromBody] SecurityLoginsRolePoco[] pocos)
        {
            _logic.Delete(pocos);
            return Ok();
        }
    }
}
