using SCV.UTL;
using SimpleMVVMExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCV.WPF.ViewModels
{
    class HomeViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Inicio";
            }
        }
    }
}
