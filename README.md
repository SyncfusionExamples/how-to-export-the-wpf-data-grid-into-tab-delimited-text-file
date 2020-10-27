# How to get the node in WPF TreeView (SfTreeView)?

How to get the node in WPF TreeView (SfTreeView)?

# About the sample

In SfTreeView, you can get the node based on the item bound with it using SfTreeView.GetItemInfo method.

```c#
var treeViewInfo = sfTreeView.GetItemInfo((this.DataContext as FileManagerViewModel).ImageNodeInfo.FirstOrDefault(x => x.ItemName == "Documents"));
var node = treeViewInfo.Node;
```

## Requirements to run the demo
 Visual Studio 2015 and above versions
