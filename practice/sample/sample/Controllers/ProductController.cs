using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sample.Model;
using sample.Repository;

namespace sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _repository;
        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> Get() {
            var prs = await _repository.GellAllProduct();
            if (prs == null)
            {
                return NotFound();
            }
            return Ok(prs);

        }
        [HttpGet("{Id}")]
        public async Task<ActionResult<Product>> GetById(int ProductId)
        {
            var prs = await _repository.GetProductById(ProductId);
            if (prs == null)
            {
                return NotFound();
            }
            return Ok(new
            {
                message = "Successfully found the product"
            });


        }
        [HttpPut]
        public async Task<ActionResult<Product>> Put(int ProductId, Product product)
        {
            var prs = await _repository.PutProduct( ProductId,  product);
            if (prs == null)
            {
                return NotFound();
            }
            return Ok(new
            {
                message = "Super Hero Updated Successfully!!!",
                //id = prs!.ProductId
            });

        }

        [HttpPost]
        public async Task<ActionResult<Product>> Post(int ProductId, Product product)
        {
            var prs = await _repository.PostProduct( product);
            if (prs == null)
            {
                return NotFound();
            }
            return Ok(new
            {
                message = "Super Hero Updated Successfully!!!",
                //id = prs!.ProductId
            });

        }
    }
}
