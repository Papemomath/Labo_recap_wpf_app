using IdeaManager.Core.Interfaces;
using IdeaManager.UI.ViewModels;
using System.Windows.Controls;
using IdeaManager.Data.DB;

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
            var dbContext = new IdeaDbContextFactory().CreateDbContext(null);
            //var ideaService = new IdeaService(dbContext);
            //DataContext = new IdeaListViewModel(ideaService);           
        }
        
    }
}
