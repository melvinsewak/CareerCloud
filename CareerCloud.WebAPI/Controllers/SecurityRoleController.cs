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
    public class SecurityRoleController : ApiController
    {
        private readonly SecurityRoleLogic _logic;

        public SecurityRoleController()
        {
            var repository = new EFGenericRepository<SecurityRolePoco>(false);
            _logic = new SecurityRoleLogic(repository);
        }

        [HttpGet]
        [Route("role/{securityRoleId}")]
        [ResponseType(typeof(SecurityRolePoco))]
        public IHttpActionResult GetSecurityRole(Guid securityRoleId)
        {
            SecurityRolePoco securityRole = _logic.Get(securityRoleId);
            if (securityRole == null)
            {
                return NotFound();
            }

            return Ok(securityRole);
        }

        [HttpGet]
        [Route("role")]
        [ResponseType(typeof(List<SecurityRolePoco>))]
        public IHttpActionResult GetAllSecurityRole()
        {
            List<SecurityRolePoco> listOfSecurityRole = _logic.GetAll();
            if (listOfSecurityRole == null)
            {
                return NotFound();
            }
            return Ok(listOfSecurityRole);
        }

        [HttpPost]
        [Route("role")]
        public IHttpActionResult PostSecurityRole([FromBody] SecurityRolePoco[] pocos)
        {
            _logic.Add(pocos);
            return Ok();
        }

        [HttpPut]
        [Route("role")]
        public IHttpActionResult PutSecurityRole([FromBody] SecurityRolePoco[] pocos)
        {
            _logic.Update(pocos);
            return Ok();
        }

        [HttpDelete]
        [Route("role")]
        public IHttpActionResult DeleteSecurityRole([FromBody] SecurityRolePoco[] pocos)
        {
            _logic.Delete(pocos);
            return Ok();
        }
    }
}
