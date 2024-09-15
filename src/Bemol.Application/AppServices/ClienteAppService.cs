using Bemol.Application.Interfaces;
using Bemol.Application.Models;
using Bemol.Domain.Entities;
using Bemol.Domain.Interfaces.Repositories;

namespace Bemol.Application.AppServices
{
    public class ClienteAppService: BaseAppService<Cliente>, IClienteAppService
    {
        private readonly IClienteRepository _repository;

        public ClienteAppService(IClienteRepository repository) : base(repository)
        {
            _repository = repository;
        }
  
    }
}
