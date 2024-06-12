using si730pc2u202214059.API.Sales.Domain.Model.Aggregates;
using si730pc2u202214059.API.Sales.Domain.Model.Commands;

namespace si730pc2u202214059.API.Sales.Domain.Services;

public interface IPurchaseOrdersCommandService
{
    
    Task<PurchaseOrders?> Handle(CreatePurchaseOrdersCommand command);
    
    
}