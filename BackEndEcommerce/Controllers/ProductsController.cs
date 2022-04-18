using BackEndEcommerce.Models;
using BackEndEcommerce.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BackEndEcommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : BaseController<Product>
    {
        public ProductsController(eCommerceContext _context, IRepository<Product> _repository) : base(_context, _repository)
        {
        }

        // DELETE: api/Base/5
        [HttpDelete("{Id}")]
        public override ActionResult<ApiResponses> DeleteEntity(string Id)
        {
            ApiResponses response = new ApiResponses()
            {
                Success = true,
            };

            try
            {
                repository.Delete(repository.Get(Id));
            }
            catch (Exception ex)
            {
                response.Message = ex.Message.ToString();
                response.Success = false;
            }

            return response;
        }

    }
}
