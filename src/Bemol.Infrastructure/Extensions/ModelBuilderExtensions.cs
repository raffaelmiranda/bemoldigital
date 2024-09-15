using Bemol.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bemol.Infrastructure.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            Cliente cliente = new Cliente(1, "Alexandre Bruno Ryan da Mota", "61912898047", "69905-102", "Rua Equador", "alexandrebrunodamota@modus.com.br");
            modelBuilder.Entity<Cliente>().HasData(cliente);
        }
    }
}
