using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPICRUD2.Model;
using WebAPICRUD2.Services;

namespace WebAPICRUD2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OurCustomerController : ControllerBase
    {
        private readonly IOurCustomerService _CustomerService;

        public OurCustomerController(IOurCustomerService CustomerService)
        {
            _CustomerService = CustomerService;

        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] bool? isActive = null)
        {
            var Customer = await _CustomerService.GetAllCustomer(isActive);
            return Ok(Customer);
        }

        [HttpGet("{id}")]
        //[Route("{id}")] // /api/OurHero/:id
        public async Task<IActionResult> Get(int id)
        {
            var Customer = await _CustomerService.GetCustomerByID(id);
            if (Customer == null)
            {
                return NotFound();
            }
            return Ok(Customer);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddUpdateCustomer heroObject)
        {
            var Customer = await _CustomerService.AddOurCustomer(heroObject);

            if (Customer == null)
            {
                return BadRequest();
            }

            return Ok(new
            {
                message = "Super Hero Created Successfully!!!",
                id = Customer!.Id
            });
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] AddUpdateCustomer CustomerObject)
        {
            var Customer = await _CustomerService.UpdateOurCustomer(id, CustomerObject);
            if (Customer == null)
            {
                return NotFound();
            }

            return Ok(new
            {
                message = "Super Hero Updated Successfully!!!",
                id = Customer!.Id
            });
        }

        
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            if (!await _CustomerService.DeleteCustomerByID(id))
            {
                return NotFound();
            }

            return Ok(new
            {
                message = "Super Hero Deleted Successfully!!!",
                id = id
            });
        }
    }
    }
