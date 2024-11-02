using Sylac.Mvvm.Example.ViewModels;
using Sylac.Mvvm.Maui.Controls;

namespace Sylac.Mvvm.Example.Pages;

public partial class ShellTabPage : NavigationablePage
{
    public ShellTabPage(ShellTabPageViewModel pageViewModel)
        : base(pageViewModel)
    {
        InitializeComponent();
    }
}