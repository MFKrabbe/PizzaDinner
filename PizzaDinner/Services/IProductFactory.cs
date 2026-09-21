using PizzaDinner.Models;

namespace PizzaDinner.Services;

public interface IProductFactory
{
    IProduct CreatePizza(string type, double price);
    IProduct CreateBurger(string type, double price, int gramsOfMeat);
    IProduct CreateBeverage(string type, double price, int calories, double volume);
}