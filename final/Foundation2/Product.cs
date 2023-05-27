class Product{

    private int _id;
    private string _name;
    private int _price;
    private int _qty;


    public Product (int ID, string name, int price, int qty){
            _id = ID;
            _name=name;
            _price = price;
            _qty = qty;
    }

    public int GetPrice(){
        return _qty * _price;

    }

    public int GetID(){
        return _id;
    }
    
    public string GetName(){
        return _name;
    }
}