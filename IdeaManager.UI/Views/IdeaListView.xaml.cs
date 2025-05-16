using IdeaManager.Core.Interfaces;
using IdeaManager.UI.ViewModels;
using System.Windows.Controls;

namespace IdeaManager.UI.Views
{
    /// <summary>
    /// Logique d'interaction pour IdeaListView.xaml
    /// </summary>
    public partial class IdeaListView : UserControl
    {
        private readonly IIdeaService _ideaService;

        public IdeaListView()
        {
            InitializeComponent();
            var viewModel = new IdeaListViewModel();  
            DataContext = viewModel;
        }
    }
}
