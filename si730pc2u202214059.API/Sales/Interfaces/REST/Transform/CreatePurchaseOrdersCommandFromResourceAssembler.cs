using si730pc2u202214059.API.Sales.Domain.Model.Commands;
using si730pc2u202214059.API.Sales.Interfaces.REST.Resources;

namespace si730pc2u202214059.API.Sales.Interfaces.REST.Transform

{
    public static class CreatePurchaseOrdersCommandFromResourceAssembler
    {
        public static CreatePurchaseOrdersCommand ToCommandFromResource(CreatePurchaseOrdersResource resource)
        {
            return new CreatePurchaseOrdersCommand(
                resource.Customer, resource.FabricId, resource.Country, resource.ResumeUrl, resource.Quantity);
        }
    }
}