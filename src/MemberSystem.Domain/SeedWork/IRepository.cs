using MemberSystem.Infrastructure.SeedWork;

namespace MemberSystem.Domain.SeedWork
{
    public interface IRepository<T> where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
