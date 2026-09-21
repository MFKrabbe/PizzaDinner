using System;
using System.Diagnostics.CodeAnalysis;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using PizzaDinner.ViewModels;

namespace PizzaDinner;

/// <summary>
/// Given a view model, returns the corresponding view if possible.
/// </summary>
[RequiresUnreferencedCode(
    "Default implementation of ViewLocator involves reflection which may be trimmed away.",
    Url = "https://docs.avaloniaui.net/docs/concepts/view-locator")]
public class ViewLocator : IDataTemplate
{
    private readonly IServiceProvider _services;

    public ViewLocator(IServiceProvider services)
    {
        _services = services;
    }

    public Control Build(object data)
    {
        return data switch
        {
            _ => new TextBlock { Text = $"No view for {data.GetType().Name}" }
        };
    }

    public bool Match(object data) => data is ViewModelBase;
}