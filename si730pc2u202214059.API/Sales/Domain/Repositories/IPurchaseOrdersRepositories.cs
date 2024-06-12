using si730pc2u202214059.API.Sales.Domain.Model.Aggregates;
using si730pc2u202214059.API.Sales.Domain.Model.ValueObjects;
using si730pc2u202214059.API.Shared.Domain.Repositories;

namespace si730pc2u202214059.API.Sales.Domain.Repositories;

public interface IPurchaseOrdersRepository : IBaseRepository<PurchaseOrders>
{
    Task<PurchaseOrders?> FindByCustomerAndFabricIdAsync(string customer, EFabricId fabricId);
}