

namespace Article.Api.Repository
{
    public class ArticleRepository : List<Model.Article>,  IArticleRepository
    {
        private readonly static List<Model.Article> _articles = Populate();

        private static List<Model.Article> Populate()
        {
            var result = new List<Model.Article>()
            {
                new Model.Article()
                {
                    Id = 1,
                    Title = "First Article",
                    WriterID = 1,
                    UpdatedDate = DateTime.Now
                },
                new Model.Article()
                {
                    Id = 2,
                    Title = "Second Article",
                    WriterID = 2,
                    UpdatedDate = DateTime.Now

                },
                 new Model.Article()
                {
                    Id = 3,
                    Title = "Third Article",
                    WriterID = 3,
                    UpdatedDate = DateTime.Now

                }
            };
            return result;
        }

        public int Delete(int id)
        {
            var arti = _articles.FirstOrDefault(op => op.Id == id);
            if (arti != null)
            {
                _articles.Remove(arti);
                return 1;
            }
            return 0;
        }

        public Model.Article Get(int id)
        {
            var artic = _articles.FirstOrDefault(op => op.Id == id);
            return artic;
        }

        public List<Model.Article> GetAll()
        {
            return _articles;
        }
    }
}
