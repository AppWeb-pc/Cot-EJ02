namespace si730pc2u202214059.API.Sales.Interfaces.REST.Resources;

public record CreatePurchaseOrdersResource(string Customer, int FabricId, string Country, string ResumeUrl, int Quantity);