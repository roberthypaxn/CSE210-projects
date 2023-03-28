using System;

class Product
{
    internal string _productId;
    internal string _productName;
    internal int _price;
    private int _quantity;
    public Product(string name, string id, int price, int quantity)
    {
        _productName = name;
        _productId = id;
        _price = price * quantity;
        _quantity = quantity;
    }
}