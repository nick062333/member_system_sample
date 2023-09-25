using MemberSystem.Domain.SeedWork;

namespace MemberSystem.Domain.AggregatesModel.UserAggregate
{
    public interface IUserRepository : IRepository<User>
    {
        User Add(User order);

        void Update(User order);

        Task<User> GetAsync(int orderId);
    }
}
