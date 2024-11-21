using AutoMapper;

using Microsoft.AspNetCore.Mvc;
using Mango.Services.ProductAPI.Data;
using Mango.Services.ProductAPI.Models.Dto;
using Mango.Services.ProductAPI.Models;

namespace Mango.Services.CouponAPI.Controllers
{

    [Route("api/[controller]")]

    [ApiController]

    public class ProductAPIController : ControllerBase

    {

        private readonly ProductDbContext _db;

        private ResponseDto _response;

        private IMapper _mapper;

        public ProductAPIController(ProductDbContext db, IMapper mapper)

        {

            _db = db;

            _mapper = mapper;

            _response = new ResponseDto();

        }

        [HttpGet]

        public ResponseDto Get()

        {

            try

            {

                IEnumerable<Product> objList = _db.Product.ToList();

                _response.Result = _mapper.Map<IEnumerable<ProductDto>>(objList);

            }

            catch (Exception ex)

            {

                _response.IsSuccess = false;

                _response.Message = ex.Message;

            }

            return _response;

        }

        [HttpGet]

        [Route("{id:int}")]

        public ResponseDto Get(int id)

        {

            try

            {

                Product obj = _db.Product.First(u => u.ProductId == id);

                _response.Result = _mapper.Map<ProductDto>(obj);

            }

            catch (Exception ex)

            {

                _response.IsSuccess = false;

                _response.Message = ex.Message;

            }

            return _response;

        }
        
    }
}
