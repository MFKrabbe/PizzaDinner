using CommunityToolkit.Mvvm.ComponentModel;

namespace PizzaDinner.Models;

public partial class Pizza : ObservableObject, IProduct
{
    private string _type = "";
    private double _price = 0;

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

    public Pizza(string type, double price)
    {
        Type = type;
        Price = price;
    }
}