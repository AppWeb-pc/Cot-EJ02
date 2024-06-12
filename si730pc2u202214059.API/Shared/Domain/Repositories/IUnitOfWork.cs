namespace si730pc2u202214059.API.Shared.Domain.Repositories;

public interface IUnitOfWork
{
    Task CompleteAsync();
}