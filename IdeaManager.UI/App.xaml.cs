﻿using IdeaManager.Data;
using IdeaManager.Services;
using IdeaManager.UI.Navigation;
using IdeaManager.UI.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using IdeaManager.UI.Views;

namespace IdeaManager.UI;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public static IServiceProvider ServiceProvider { get; private set; }

    protected override void OnStartup(StartupEventArgs e)
    {
        var services = new ServiceCollection();

        services.AddDataServices("Data Source=D:/projet_Entreprise/Labo_recap_wpf_app/IdeaManager.Data/idea.db");
        services.AddDomainServices();
        services.AddUIServices();
        services.AddSingleton<NavigationService>();
        services.AddSingleton<MainViewModel>();
        services.AddSingleton<IdeaFormViewModel>();
        services.AddSingleton<IdeaListViewModel>();
        services.AddSingleton<DashboardView>();
        


        ServiceProvider = services.BuildServiceProvider();

        var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
        mainWindow.Show();
    }
}

