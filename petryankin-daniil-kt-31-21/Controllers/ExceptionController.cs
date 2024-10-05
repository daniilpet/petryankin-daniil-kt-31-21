using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace petryankin_daniil_kt_31_21.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExceptionController : ControllerBase
    {
        [HttpGet]
        public void CallException()
        {
            throw new NotImplementedException();
        }
    }
}
