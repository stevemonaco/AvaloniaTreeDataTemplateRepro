using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace AvaloniaTreeDataTemplateRepro.ViewModels;
public abstract class NodeViewModel : ObservableObject
{
    public ObservableCollection<NodeViewModel> Children { get; } = new();
}
