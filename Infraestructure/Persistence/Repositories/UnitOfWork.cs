using Domain.Repositories;

namespace Infraestructure.Persistence.Repositories
{
    internal sealed class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;

        /// <summary>
        ///  Initialize a new instance of the <see cref="UnitOfWork"/> class.
        /// </summary>
        /// <param name="dbContext"></param>
        public UnitOfWork(ApplicationDbContext dbContext) => _dbContext = dbContext;

        public async Task SaveChangesAsync(CancellationToken cancellationToken = default) =>
                await _dbContext.SaveChangesAsync(cancellationToken);
    }
}
