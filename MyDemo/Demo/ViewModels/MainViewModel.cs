using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prism.DryIoc;
using System.Threading.Tasks;
using Prism.Mvvm;
using Prism.Regions;
using Demo.Views;
using Demo.Core;
using Prism.Commands;
namespace Demo.ViewModels
{
    public class MainViewModel : NavigationViewModel
    {
        public MainViewModel(IRegionManager regionManager)
        {
            MyText = "123";
            this.regionManager = regionManager;
            OpenCommand = new DelegateCommand<string>(Open);

        }



        private string myText;
        private readonly IRegionManager regionManager;

        public DelegateCommand<string> OpenCommand { get; private set; }

        public string MyText
        {
            get { return myText; }
            set { myText = value; RaisePropertyChanged(); }
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            regionManager.Regions["MainViewRegion"].RequestNavigate("ViewA");

        }



        private void Open(string view)
        {
            regionManager.Regions["MainViewRegion"].RequestNavigate(view);
        }
    }
}
