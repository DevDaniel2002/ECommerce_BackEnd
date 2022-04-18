using BackEndEcommerce.Models;
using BackEndEcommerce.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BackEndEcommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController<User>  
    {
        public UserController(eCommerceContext _context, IRepository<User> _repository): base(_context, _repository)
        {

        }

        [HttpGet]
        [Route("login")]
        public ApiResponses Login([FromQuery] string User, [FromQuery] string Password)
        {
            var UserName = repository.Get().FirstOrDefault(x => x.UserName == User && x.Password == Password);
            ApiResponses apiResponses = new ApiResponses();

            if (UserName != null)
            {
                apiResponses.Success = true;
                apiResponses.Data = UserName;
                return apiResponses;
            }  

            apiResponses.Success = false;
            return apiResponses;
        }
    }
}
