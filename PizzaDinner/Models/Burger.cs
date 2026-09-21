using CommunityToolkit.Mvvm.ComponentModel;

namespace PizzaDinner.Models;

public partial class Burger: ObservableObject, IProduct
{
    
    private string _type = "";
    private double _price = 0;
    private int _gramsOfMeat = 0;

    public string Type
    {
        get => _type;
        set => SetProperty(ref _type, value);
    }

    public double Price
    {
        get => _price;
        set => SetProperty(ref _price, value);
    }

    public int GramsOfMeat
    {
        get => _gramsOfMeat;
        set => SetProperty(ref _gramsOfMeat, value);
    }

    public Burger(string type, double price,  int gramsOfMeat)
    {
        Type = type;
        Price = price;
        GramsOfMeat = gramsOfMeat;
    }
}