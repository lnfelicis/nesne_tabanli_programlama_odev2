using Product_automation;

var product1 = new Product()
{
    ProductId = 1,
    Price = 1000,
    ProductName = "Tablet",
};
var product2 = new Product()
{
    ProductId = 2,
    Price = 2000,
    ProductName = "Telefon",
};

var item1 = new CartItem()
{
    CartId = 1,
    Product = product1,
    Quantity = 3
};
var item2 = new CartItem()
{
    CartId = 2,
    Product = product2,
    Quantity = 4
};
var manager = new ShoppingCart();
manager.Add(item1);
manager.Add(item2);
manager.GetList();
manager.GetBalance();