
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace AvaloniaTreeDataTemplateRepro.ViewModels;
public sealed partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty] private ObservableCollection<NodeViewModel> _items = new();

    public MainWindowViewModel()
    {
        var branches = 5;

        for (int i = 0; i < branches; i++)
            Items.Add(new BranchNodeViewModel());
    }
}
