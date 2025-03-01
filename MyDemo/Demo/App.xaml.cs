using Demo.Module1;
using Demo.ViewModels;
using Demo.Views;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System.Windows;

namespace Demo
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : PrismApplication
    {
        //1.
        //protected override Window CreateShell()
        //{
        //    var mainView = new MainView();
        //    var region = Container.Resolve<IRegionManager>();

        //    //更新Prism注册区域信息
        //    RegionManager.SetRegionManager(mainView, region);
        //    RegionManager.UpdateRegions();

        //    //调用首页的INavigationAware接口，做一个初始化操作
        //    if (mainView.DataContext is INavigationAware navigationAware) 
        //    {
        //        navigationAware.OnNavigatedTo(null);
        //    }
        //    return mainView;
        //}

        //2.
        protected override Window CreateShell() => null;

        protected override void OnInitialized()
        {
            //从容器中获取MainView的实例对象
            var container = ContainerLocator.Container;
            var shell = container.Resolve<object>("MainView");
            if (shell is Window view)
            {
                //更新Prism注册区域信息
                var regionManager = container.Resolve<IRegionManager>();
                RegionManager.SetRegionManager(view, regionManager);
                RegionManager.UpdateRegions();

                //调用首页的INavigationAware接口，做一个初始化操作
                if (view.DataContext is INavigationAware navigationAware)
                {
                    navigationAware.OnNavigatedTo(null);
                    //呈现首页
                    App.Current.MainWindow = view;
                }
            }

            base.OnInitialized();
        }

        protected override void RegisterTypes(IContainerRegistry services)
        {
            services.RegisterForNavigation<MainView,MainViewModel>();
            services.RegisterForNavigation<ViewA,ViewAViewModel>();
            services.RegisterForNavigation<ViewB,ViewBViewModel>();
            
        }


        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<Module1Module>();


            base.ConfigureModuleCatalog(moduleCatalog);
        }


    }
}
