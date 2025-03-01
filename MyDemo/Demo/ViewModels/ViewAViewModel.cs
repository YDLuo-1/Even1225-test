using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.ViewModels
{
    public class ViewAViewModel:BindableBase
    {
        public ViewAViewModel()
        {
            ViewAText = "ViewAText";
        }

        private string viewAText;

        public string ViewAText
        {
            get { return viewAText; }
            set { viewAText = value; RaisePropertyChanged(); }
        }



    }
}
