using IdeaManager.UI.ViewModels;

namespace IdeaManager.UI.Navigation
{
    public class NavigationService
    {
        private readonly MainViewModel _mainViewModel;

        public NavigationService(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }

        public void NavigateTo(object viewModel)
        {
            _mainViewModel.CurrentViewModel = viewModel;
        }
    }
}
