using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using si730pc2u202214059.API.Sales.Domain.Services;
using si730pc2u202214059.API.Sales.Interfaces.REST.Resources;
using si730pc2u202214059.API.Sales.Interfaces.REST.Transform;

namespace si730pc2u202214059.API.Sales.Interfaces.REST

{
    [ApiController]
    [Route("api/v1/purchase-orders")]
    [Produces(MediaTypeNames.Application.Json)]
    public class PurchaseOrdersController(IPurchaseOrdersCommandService purchaseOrdersCommandService) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreatePurchaseOrder(CreatePurchaseOrdersResource resource)
        {
            var createPurchaseOrderCommand = CreatePurchaseOrdersCommandFromResourceAssembler.ToCommandFromResource(resource);
            var purchaseOrder = await purchaseOrdersCommandService.Handle(createPurchaseOrderCommand);
            if (purchaseOrder is null) return BadRequest();
            var purchaseOrdersResource = PurchaseOrdersResourceFromEntityAssembler.ToResourceFromEntity(purchaseOrder);
            return new CreatedResult(string.Empty, purchaseOrdersResource);
        }

    }
}