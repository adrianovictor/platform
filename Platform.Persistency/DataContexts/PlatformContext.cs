using Microsoft.EntityFrameworkCore;
using Platform.Domain.Model.Users;

namespace Platform.Persistency.DataContexts
{
    public class PlatformContext : BaseContext<PlatformContext>
    {
        public DbSet<User> Users { get; set; }

        
    }
}