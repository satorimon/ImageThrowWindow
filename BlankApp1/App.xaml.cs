using BlankApp1.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System.Windows;

namespace BlankApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            var subwindow = new PrismWindow1();
            subwindow.Show();
            RegionManager.SetRegionManager(subwindow, Container.Resolve<IRegionManager>());
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
