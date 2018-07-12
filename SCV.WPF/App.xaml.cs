using SCV.WPF;
using SCV.WPF.Windows;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace SimpleMVVMExample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            PrincipalWindow app = new PrincipalWindow();
            PrincipalViewModel context = new PrincipalViewModel();
            app.DataContext = context;
            app.Show();
        }
    }
}
