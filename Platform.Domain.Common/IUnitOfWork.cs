using System;

namespace Platform.Domain.Common
{
    public interface IUnitOfWork
    {
        int SaveChanges();
    }
}