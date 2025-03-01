using Demo.Module1.ViewModels;
using Demo.Module1.Views;
using Prism.Ioc;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Module1
{
    public class Module1Module : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            
        }

        public void RegisterTypes(IContainerRegistry services)
        {
            services.RegisterForNavigation<ViewC,ViewCViewModel>();
        }
    }
}
