class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;


    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public int GetTotalPrice()
    {
        int total = 0;
        foreach (Product p in _products){
            total = total + p.GetPrice();
        }
        if (_customer.IsUSA())
            total = total + 5;
        else
            total = total + 35;

        return total;
    }

    public string GetPackingLabel()
    {
        string plabel = "";
        foreach (Product p in _products){
            plabel = plabel + $"{p.GetID().ToString()} - {p.GetName()} \n";
        }
        return plabel;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()} - {_customer.GetAddress().GetAddress()}";

    }


}