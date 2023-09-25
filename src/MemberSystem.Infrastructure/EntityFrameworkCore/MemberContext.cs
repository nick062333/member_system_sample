using MediatR;
using MemberSystem.Domain.AggregatesModel.OrgAggregate;
using MemberSystem.Domain.AggregatesModel.UserAggregate;
using MemberSystem.Infrastructure.EntityFrameworkCore.EntityTypeConfiguration;
using MemberSystem.Infrastructure.SeedWork;
using Microsoft.EntityFrameworkCore;

namespace MemberSystem.Infrastructure.EntityFrameworkCore
{
    public class MemberContext : DbContext, IUnitOfWork
    {
        public DbSet<Org> Orgs { get; set; }
        public DbSet<ApplyFile> ApplyFiles { get; set; }
        public DbSet<User> Users { get; set; }

        private readonly IMediator _mediator;

        public MemberContext(DbContextOptions<MemberContext> options, IMediator mediator) : base(options)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));


            System.Diagnostics.Debug.WriteLine("MemberContext::ctor ->" + this.GetHashCode());
        }

        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
        {

            await _mediator.DispatchDomainEventsAsync(this);

            _ = await base.SaveChangesAsync(cancellationToken);

            return true;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new OrgEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ApplyFileEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SysLogEntityConfiguration());
        }
    }
}
