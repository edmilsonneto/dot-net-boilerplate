using SCV.DTO;
using SCV.UTL;
using SimpleMVVMExample;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCV.WPF.ViewModels
{
    class ClienteViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Clientes";
            }
        }

        
    }
}
