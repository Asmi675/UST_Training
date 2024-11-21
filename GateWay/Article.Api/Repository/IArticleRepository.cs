using Article.Api.Model;

namespace Article.Api.Repository
{
    public interface IArticleRepository
    {
        int Delete(int id);
        Model.Article Get (int id);
        List<Model.Article> GetAll();
    }
}
