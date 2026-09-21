using CommunityToolkit.Mvvm.ComponentModel;

namespace PizzaDinner.Models;

public class Beverage: ObservableObject, IProduct
{
    private string _type = "";
    private double _price = 0;
    private int _calories = 0;
    private double _volume = 0;

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

    public int Calories
    {
        get => _calories;
        set => SetProperty(ref _calories, value);
    }
    
    public double Volume
    {
        get => _volume;
        set => SetProperty(ref _volume, value);
    }

    public Beverage(string type, double price,  int calories, double volume)
    {
        Type = type;
        Price = price;
        Calories = calories;
        Volume = volume;
    }
}