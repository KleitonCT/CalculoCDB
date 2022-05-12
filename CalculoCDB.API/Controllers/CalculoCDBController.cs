using CalculoCDB.Domain.Request;
using CalculoCDB.Services.Interfaces;
using System;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CalculoCDB.API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CalculoCDBController : ApiController
    {
        private readonly ICalculoCdbService _service;
        public CalculoCDBController(ICalculoCdbService service)
        {
            _service = service;
        }

        [HttpPost]
        public IHttpActionResult Post([FromBody] CalculoCdbRequest request)
        {
            try
            {
                if (request == null)
                    return BadRequest();

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                return Ok(_service.CalcularCDB(request));

            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
