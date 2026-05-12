namespace Student_Marketplace.Models;

public class Order
{

    public int Id { get; set; }
    public int Quantity { get; set; } = 1;
    public string Status { get; set; } = "Pending";
    public decimal TotalAmount { get; set; }
    public DateTime OrderDate { get; set; } = DateTime.UtcNow;

    public string ProductId { get; set; } = string.Empty;
    public Product? Product { get; set; }

    public int BuyerId { get; set; }
    public User? Buyer { get; set; } 
}
