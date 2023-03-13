namespace Week10.StrategyDesignPattern;

public class Item
{
    public Item(string itemName, int quantity)
    {
        ItemName = itemName;
        Quantity = quantity;
    }
    public string ItemName { get; set; }
    public int Quantity { get; set; }
}