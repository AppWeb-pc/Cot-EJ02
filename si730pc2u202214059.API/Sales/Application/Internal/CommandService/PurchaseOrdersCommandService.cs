using si730pc2u202214059.API.Sales.Domain.Model.Aggregates;
using si730pc2u202214059.API.Sales.Domain.Model.Commands;
using si730pc2u202214059.API.Sales.Domain.Model.ValueObjects;
using si730pc2u202214059.API.Sales.Domain.Repositories;
using si730pc2u202214059.API.Sales.Domain.Services;
using si730pc2u202214059.API.Shared.Domain.Repositories;

namespace si730pc2u202214059.API.Sales.Application.Internal.CommandService
{

    public class  PurchaseOrdersCommandService (IPurchaseOrdersRepository purchaseOrdersRepository, IUnitOfWork unitOfWork) : IPurchaseOrdersCommandService
    { 

        
        public async Task<PurchaseOrders?> Handle(CreatePurchaseOrdersCommand command)
        {
            
            try
            { 
                var existingPurchaseOrder = await purchaseOrdersRepository.FindByCustomerAndFabricIdAsync(command.Customer, (EFabricId)command.FabricId);
                if (existingPurchaseOrder != null)
                {
                    throw new ArgumentException("A purchase order with the same Customer and FabricId already exists.");
                }

                // Check if FabricId is valid
                if (!Enum.IsDefined(typeof(EFabricId), command.FabricId))
                {
                    throw new ArgumentException("FabricId must be a valid value.");
                }

                var purchaseOrder = new PurchaseOrders(command);

                await purchaseOrdersRepository.AddAsync(purchaseOrder);
                await unitOfWork.CompleteAsync();

                return purchaseOrder;
            }
            catch (ArgumentException ex)
            {
                // Catch the exception and rethrow it with only the message
                throw new Exception(ex.Message);
            }
        }
    }
}