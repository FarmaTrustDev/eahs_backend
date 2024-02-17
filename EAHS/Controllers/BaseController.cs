using EAHS.Filters;
using Microsoft.AspNetCore.Mvc;

namespace EAHS.Controllers
{
    [AuthManager]
    [Route("[controller]")]
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
    }
}
