namespace Writer.Api.Repository
{
    public interface IWriterRepository
    {
        List<Model.Writer> GetAll();
        Model.Writer GetAllById(int id);
        Model.Writer Post(Model.Writer woooo);
    }
}
