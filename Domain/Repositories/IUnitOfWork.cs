namespace Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task<Guid> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
