﻿using CommunityToolkit.Mvvm.ComponentModel;

namespace IdeaManager.UI.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private object currentViewModel;
    }
}
