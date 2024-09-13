using ExoApi.Domains;
using ExoApi.Properties;

namespace ExoApi.Repositories
{
    public class ProjetoRepository
    {
        private readonly ExoApiContext _context;

        public ProjetoRepository( ExoApiContext context )
        {
            _context = context;
        }

        public List<Projeto> Listar()
        {
           return _context.Projetos.ToList();
        }

    }
}
