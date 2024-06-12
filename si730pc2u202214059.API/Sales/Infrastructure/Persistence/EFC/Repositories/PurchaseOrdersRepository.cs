using Microsoft.EntityFrameworkCore;
using si730pc2u202214059.API.Sales.Domain.Model.Aggregates;
using si730pc2u202214059.API.Sales.Domain.Model.ValueObjects;
using si730pc2u202214059.API.Sales.Domain.Repositories;
using si730pc2u202214059.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using si730pc2u202214059.API.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace si730pc2u202214059.API.Sales.Infrastructure.Persistence.EFC.Repositories

{
    public class PurchaseOrdersRepository(AppDbContext context) : BaseRepository<PurchaseOrders>(context), IPurchaseOrdersRepository
    {
     

        public async Task<PurchaseOrders?> FindByCustomerAndFabricIdAsync(string customer, EFabricId fabricId)
        {
            return await context.Set<PurchaseOrders>()
                .FirstOrDefaultAsync(po => po.Customer == customer && po.FabricId == (int)fabricId);
        }
    }
}