using MemberSystem.Domain.AggregatesModel.UserAggregate;
using MemberSystem.Infrastructure.EntityFrameworkCore;
using MemberSystem.Infrastructure.SeedWork;

namespace MemberSystem.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly MemberContext _context;

        public IUnitOfWork UnitOfWork => _context;

        public UserRepository(MemberContext memberContext) 
        {
            _context = memberContext ?? throw new ArgumentNullException(nameof(memberContext)); 
        }

        public User Add(User order)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetAsync(int orderId)
        {
            throw new NotImplementedException();
        }

        public void Update(User order)
        {
            throw new NotImplementedException();
        }
    }
}
