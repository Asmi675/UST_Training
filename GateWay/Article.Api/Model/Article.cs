namespace Article.Api.Model
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int WriterID { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
