
namespace Writer.Api.Repository
{
    public class WriterRepository : List<Model.Writer>,IWriterRepository
    {
        private readonly static List<Model.Writer> _writer = Populate();

        public static List<Model.Writer> Populate()
        {
            return new List<Model.Writer>
            {
                new Model.Writer
                {
                    Id = 1,
                    Name="Ammu"
                },
                new Model.Writer
                {
                    Id = 2,
                    Name="Simran"
                },new Model.Writer
                {
                    Id = 3,
                    Name="Aparna"
                },
                new Model.Writer
                {
                    Id = 4,
                    Name="Ashna"
                }
            };
        }

        public List<Model.Writer> GetAll()
        {
            return _writer;
        }

        public Model.Writer GetAllById(int id)
        {
            var all = _writer.FirstOrDefault(op => op.Id==id);
            return all;
        }

        public Model.Writer Post(Model.Writer woooo)
        {
             _writer.Add(woooo);
            return woooo;
        }
    }
}
