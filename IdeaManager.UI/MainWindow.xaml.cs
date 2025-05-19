using IdeaManager.UI.Navigation;
using IdeaManager.UI.ViewModels;
using System.Windows;
using IdeaManager.UI.Views;

namespace IdeaManager.UI
{
    public partial class MainWindow : Window
    {
        private readonly NavigationService _navigationService;
        private readonly IdeaFormViewModel _formViewModel;
        private readonly IdeaListViewModel _formListViewModel;
        private readonly DashboardView _dashboardView;


        public MainWindow(MainViewModel mainViewModel, NavigationService navigationService, IdeaFormViewModel formViewModel, IdeaListViewModel formListViewModel, DashboardView dashboardView)
        {
            InitializeComponent();

            DataContext = mainViewModel;

            _navigationService = navigationService;
            _formViewModel = formViewModel;
            _formListViewModel = formListViewModel;
            _dashboardView = dashboardView;
        }

        private void navigaton_New_Idea(object sender, RoutedEventArgs e)
        {
            _navigationService.NavigateTo(_formViewModel);
        }

        private void navigaton_List_Idea(object sender, RoutedEventArgs e)
        {
            _navigationService.NavigateTo(_formListViewModel);
        }        
        
        private void navigaton_DashBoard(object sender, RoutedEventArgs e)
        {
            _navigationService.NavigateTo(_dashboardView);
        }
    }
}
