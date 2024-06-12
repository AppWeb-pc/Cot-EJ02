using si730pc2u202214059.API.Sales.Domain.Model.Aggregates;
using si730pc2u202214059.API.Sales.Interfaces.REST.Resources;

namespace si730pc2u202214059.API.Sales.Interfaces.REST.Transform

{
    public static class PurchaseOrdersResourceFromEntityAssembler
    {
        public static PurchaseOrdersResource ToResourceFromEntity(PurchaseOrders entity)
        {
            return new PurchaseOrdersResource(
                entity.Id, 
                entity.Customer,
                entity.FabricId,
                entity.Country,
                entity.ResumeUrl,
                entity.Quantity
            );
        }
    }
}