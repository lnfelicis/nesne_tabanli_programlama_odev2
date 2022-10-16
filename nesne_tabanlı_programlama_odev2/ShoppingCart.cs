namespace Product_automation;

public class ShoppingCart
{
    private List<CartItem> _cartItems;

    public ShoppingCart()
    {
        _cartItems = new List<CartItem>();
    }

    public void Add(CartItem item)
    {
        _cartItems.Add(item);
    }

    public void Remove(int id)
    {
        var item = _cartItems.FirstOrDefault(item => item.CartId == id);
        if (item == null) throw new Exception("Belirtilen ürün bulunamadı");
        _cartItems.Remove(item);
    }

    public void GetBalance()
    {
        Console.WriteLine($"Toplam Fiyat : {_cartItems.Sum(item => item.Product.Price * item.Quantity)}");
    }

    public void GetList()
    {
        _cartItems.ForEach(item => Console.WriteLine(item));
    }

}