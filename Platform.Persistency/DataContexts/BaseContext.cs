using Microsoft.EntityFrameworkCore;
using Platform.Domain.Common;

namespace Platform.Persistency.DataContexts
{
    public abstract class BaseContext<TContext> : DbContext, IUnitOfWork
        where TContext : DbContext
    {
        public BaseContext() { }

        public BaseContext(DbContextOptions<TContext> options)
            : base(options) 
        { 

        }

        public int SaveChages() 
        {
            return 0;
        }
    }
}