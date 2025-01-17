﻿using System.Reactive;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Sylac.Mvvm.Abstraction;
using Sylac.Mvvm.Navigation.Abstractions;

namespace Sylac.Mvvm.Example.ViewModels;

public sealed record MainPageViewModelParameters() : IViewModelParameters;

public sealed class MainPageViewModel : ViewModelBase<MainPageViewModelParameters>
{
    public MainPageViewModel(INavigationService navigationService)
    {
        ButtonCommand = ReactiveCommand.CreateFromObservable(() => navigationService
            .NavigateTo<ExamplePageViewModel, ExamplePageViewModelParameters>(new(EnteredText)));
    }

    [Reactive]
    public string EnteredText { get; set; } = "";
    public ReactiveCommand<Unit, Unit> ButtonCommand { get; }
}
