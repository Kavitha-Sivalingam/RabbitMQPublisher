using Microsoft.EntityFrameworkCore;
using RabbitMQPublisher.Entity;

namespace RabbitMQPublisher
{
    public class IOrderDbContext : DbContext
    {
        public IOrderDbContext(DbContextOptions<IOrderDbContext> options)
        : base(options) { }

        public DbSet<OrderDto> inMemory => Set<OrderDto>();
    }
}
