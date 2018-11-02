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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            OnCreating(builder);
        }

        protected virtual void OnCreating(ModelBuilder builder) 
        {

        }        

        public int SaveChages() 
        {
            return 0;
        }
    }
}