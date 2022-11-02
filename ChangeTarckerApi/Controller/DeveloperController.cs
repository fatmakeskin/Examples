using ChangeTarckerApi.Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChangeTarckerApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloperController : ControllerBase
    {
        private DevBusiness devBusiness;
        public DeveloperController(DevBusiness _devBusiness)
        {
            devBusiness = _devBusiness;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var result = devBusiness.Trackerget();
            return Ok(result);
        }
    }
}
