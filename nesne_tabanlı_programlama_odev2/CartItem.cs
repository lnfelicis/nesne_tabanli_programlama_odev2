namespace Product_automation;
public class CartItem
{
    public int CartId { get; set; }
    public Product Product { get; set; } = null!;
    public int Quantity { get; set; }

    public override string ToString()
    {
        return $" Ürün Adı : {Product.ProductName}\n" +
               $" Fiyat : {Product.Price} \n " +
               $"Adet : {Quantity} \n";
    }
}