using PizzaDinner.Services;

namespace PizzaDinner.Models;

public class ProductFactory : IProductFactory
{
    public IProduct CreatePizza(string type, double price) 
        => new Pizza(type, price);

    public IProduct CreateBurger(string type, double price, int gramsOfMeat) 
        => new Burger(type, price, gramsOfMeat);

    public IProduct CreateBeverage(string type, double price, int calories, double volume) 
        => new Beverage(type, price, calories, volume);
}