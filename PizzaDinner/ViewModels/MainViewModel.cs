using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PizzaDinner.Models;
using PizzaDinner.Services;

namespace PizzaDinner.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    private readonly IProductFactory _productFactory;

    public MainViewModel(IProductFactory productFactory)
    {
        _productFactory = productFactory;
        FillListWithItems();
    }

    [ObservableProperty] private IProduct? _selectedProduct;

    [ObservableProperty] private double _totalPrice;

    public ObservableCollection<IProduct> Cart { get; } = new();

    public ObservableCollection<IProduct> Products { get; } = new();
   

    public bool IsCartVisible => Cart.Count > 0;


    [RelayCommand]
    public void AddProductToCart()
    {
        if (SelectedProduct is not null)
        {
            Cart.Add(SelectedProduct);
            OnPropertyChanged(nameof(IsCartVisible));
            GetTotalPrice();
        }

        //Warning label maybe
    }
    
    private void GetTotalPrice()
    {
        //LINQ alternative Cart.Sum(p => p.Price) very smart;
        
        double totalPrice = 0;
        foreach (var product in Cart)
        {
            totalPrice += product.Price;
        }

        TotalPrice = totalPrice;
    }

    private void FillListWithItems()
    {
        // Pizzas
        Products.Add(_productFactory.CreatePizza("Margherita", 8.50));
        Products.Add(_productFactory.CreatePizza("Pepperoni", 10.00));
        Products.Add(_productFactory.CreatePizza("Hawaiian", 11.50));
        Products.Add(_productFactory.CreatePizza("Vegetarian", 9.50));

        // Burgers
        Products.Add(_productFactory.CreateBurger("Cheese Burger", 7.50, 100));
        Products.Add(_productFactory.CreateBurger("Bacon Burger", 6.50, 110));
        Products.Add(_productFactory.CreateBurger("Bacon Cheese Burger", 7.50, 110));
        Products.Add(_productFactory.CreateBurger("Double Burger", 9.00, 210));

        // Beverages
        Products.Add(_productFactory.CreateBeverage("Pepsi", 1.50, 135, 33));
        Products.Add(_productFactory.CreateBeverage("Pepsi Max", 1.50, 2, 33));
        Products.Add(_productFactory.CreateBeverage("CocaCola", 2, 140, 33));
        Products.Add(_productFactory.CreateBeverage("CocaCola Zero", 2.50, 1, 33));
    }
}