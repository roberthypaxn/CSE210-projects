using System;

class Order
{
    
    private List<Product> _products;
    private int _cost;
    private string _packingLable;
    private string _shippingLable;
    private int _shippingCost;
    public Order(Customer currentCustomer, List<Product> orderedProducts)
    {
        _products = orderedProducts;
        if(currentCustomer.IsCitizen() == true)
        {
            _shippingCost = 5;
        }else{
            _shippingCost = 35;
        }
        foreach (Product item in _products)
        {
            _cost = _cost + item._price;
            _packingLable += $"\nProduct Name: {item._productName}\nProduct I.d: {item._productId}\n";
            _shippingLable = $"\nCustomer Name: {currentCustomer._name}\nCustomer Address= {currentCustomer.GetAddress()}";
        }

        _cost = _cost + _shippingCost;
    }
    public string GetPackingLable()
    {
        return _packingLable;
    }

    public string GetShippingLable()
    {
        return _shippingLable;
    }
    public int GetShippingCost()
    {
        return _shippingCost;
    }
    public int GetCost()
    {
        return _cost;
    }
}