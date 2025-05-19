using CommunityToolkit.Mvvm.ComponentModel;
using IdeaManager.Core.Entities;
using IdeaManager.Core.Interfaces;
using System.Collections.ObjectModel;


namespace IdeaManager.UI.ViewModels
{
    public partial class IdeaListViewModel : ObservableObject
    {
        private readonly IIdeaService _ideaService;

        public IdeaListViewModel(IIdeaService ideaService)
        {
            _ideaService = ideaService;
        }        

        [ObservableProperty]
        private ObservableCollection<Idea> ideasList = new();

        public async Task InitializeAsync()
        {
            var ideas = await _ideaService.GetAllAsync();
            IdeasList = new ObservableCollection<Idea>(ideas);
        }
    }

}