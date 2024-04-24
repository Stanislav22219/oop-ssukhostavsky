using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Richtexteditorsample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var LanguageCode = Richtexteditorsample.Properties.Settings.Default.LanguageCode;
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(LanguageCode);
            base.OnStartup(e);
        }
    }
}
