using System.ComponentModel.DataAnnotations;
using si730pc2u202214059.API.Sales.Domain.Model.Commands;

namespace si730pc2u202214059.API.Sales.Domain.Model.Aggregates

{

    public partial class PurchaseOrders
    {

        [Key] public int Id { get; private set; }
        
        [Required]
        public string Customer { get; private set; }
        
        [Required]
        public int FabricId { get; private set; }


        [Required]
        public string Country { get; private set; }


        [Required]
        public string ResumeUrl { get; private set; }
        
        [Required]
        public int Quantity { get; private set; }
        
        public PurchaseOrders(string customer, int fabricId, string country, string resumeUrl, int quantity)
        {
            Customer = customer;
            FabricId = fabricId;
            Country = country;
            ResumeUrl = resumeUrl;
            Quantity = quantity;
        }
        
        public PurchaseOrders(CreatePurchaseOrdersCommand command)
        {
            Customer = command.Customer;
            FabricId = command.FabricId;
            Country = command.Country;
            ResumeUrl = command.ResumeUrl;
            Quantity = command.Quantity;
        }
    }
}

    