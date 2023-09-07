namespace Domain.Models;

public class Orders
{
    public int id { get; set;}
    public int user_id { get; set;}
     public string ?product { get; set; }
    public int quantity { get; set; }
}
