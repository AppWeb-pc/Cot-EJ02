namespace si730pc2u202214059.API.Sales.Domain.Model.Commands;

public record CreatePurchaseOrdersCommand(string Customer, int FabricId, string Country, string ResumeUrl, int Quantity);