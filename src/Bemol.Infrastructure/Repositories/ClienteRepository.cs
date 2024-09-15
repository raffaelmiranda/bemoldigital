using Bemol.Domain.Entities;
using Bemol.Domain.Interfaces.Repositories;
using Bemol.Infrastructure.Contexts;

namespace Bemol.Infrastructure.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(BemolContext context) : base(context) { }
      
    }
}
