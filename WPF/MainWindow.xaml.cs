using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using Syncfusion.UI.Xaml.TreeView.Helpers;

namespace GettingStarted_BoundMode
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var treeViewInfo = sfTreeView.GetItemInfo((this.DataContext as FileManagerViewModel).ImageNodeInfo.FirstOrDefault(x => x.ItemName == "Documents"));
            var node = treeViewInfo.Node;
        }
    }
}
