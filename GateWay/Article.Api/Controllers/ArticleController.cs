using Article.Api.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Article.Api.Controllers
{
    [Route("api/article")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleRepository _articleRepo;
         public ArticleController (IArticleRepository articleRepo)
        {
            _articleRepo = articleRepo;
        }
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var action = _articleRepo.Get(id);
            if (action == null)
            {
                return BadRequest("Id not found");
            }
            return Ok(action);
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_articleRepo.GetAll());
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var act = _articleRepo.Delete(id);
            if ( act == 0)
            {
                return BadRequest();
            }
            return Ok("Succeded");
        }
    }
}
