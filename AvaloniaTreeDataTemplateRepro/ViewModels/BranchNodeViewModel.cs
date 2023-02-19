using System;

namespace AvaloniaTreeDataTemplateRepro.ViewModels;
public sealed class BranchNodeViewModel : NodeViewModel
{
    private bool _shouldProduceLeaves = true;

    public BranchNodeViewModel()
    {
        if (_shouldProduceLeaves)
        {
            var leaves = Random.Shared.Next(0, 3);

            for (int i = 0; i < leaves; i++)
                Children.Add(new LeafNodeViewModel());
        }

        var branches = Random.Shared.Next(-3, 4);

        for (int i = 0; i < branches; i++)
            Children.Add(new BranchNodeViewModel());
    }
}
