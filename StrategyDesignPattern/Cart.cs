using Week10.StrategyDesignPattern.strategies;

namespace Week10.StrategyDesignPattern;
/*
* private List<Items> _cart = new();
* public List<Items> ShoppingCart
* {
*   get => _cart;
*   set => _cart = value;
* }
*/
public class Cart
{
    /// <summary>
    /// Creates a new cart with the specified discount strategy.
    /// </summary>
    /// <param name="discountStrategy">The discount strategy the cart will follow.</param>
    public Cart(IDiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }

    /// <summary>
    /// A dictionary mapping an item to a price (int).
    /// </summary>
    public Dictionary<Item, int> ShoppingCart { get; } = new();

    /// <summary>
    /// The IDiscountStrategy strategy using composition.
    /// </summary>
    private IDiscountStrategy _discountStrategy;
    /// <summary>
    /// Switches the discount strategy being used by the cart.
    /// </summary>
    /// <param name="strategy">The IDiscountStrategy strategy to be used within the cart.</param>
    public void SetStrategy(IDiscountStrategy strategy)
    {
        _discountStrategy = strategy;
    }
    
    /// <summary>
    /// Add item to the shopping cart.
    /// </summary>
    /// <param name="itemName">The name of the item.</param>
    /// <param name="quantity">The quantity of the item.</param>
    /// <param name="price">The price of the item.</param>
    public void AddItem(string itemName, int quantity, int price)
    {
        Console.WriteLine($"{itemName} Was Added to the Cart!");
        var item = new Item(itemName, quantity);
        ShoppingCart[item] = price;
    }
    
    /// <summary>
    /// Returns the total price inside the shopping cart.
    /// </summary>
    /// <returns>The total price of your shopping cart.</returns>
    public int TotalPrice()
    {
        int totalPrice = ShoppingCart.Select(itemPricePair => itemPricePair.Value).Sum();
        totalPrice = (int) (totalPrice * _discountStrategy.GetDiscount());
        return totalPrice;
    }
    
}
