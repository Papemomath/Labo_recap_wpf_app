using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommunityToolkit.Mvvm.ComponentModel;

namespace IdeaManager.UI.ViewModels
{
    public abstract class ViewModelBase : ObservableObject
    {
        public virtual Task OnNavigatedToAsync() => Task.CompletedTask;
    }
}
