using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Prism.Modularity;
using Prism.Ioc;
using System.IO;

namespace LatestPrismApplicationRahul
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override IModuleCatalog CreateModuleCatalog()
        {
            string absolutePath = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + "../../../Modules");
            DirectoryModuleCatalog directoryModuleCatalog = new DirectoryModuleCatalog() { ModulePath= absolutePath };
            return directoryModuleCatalog;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<GenericShell>();
        }

        protected override void InitializeModules()
        {
            base.InitializeModules();
        }

        protected override Window CreateShell()
        {
            return this.Container.Resolve<GenericShell>();
        }
    }
}
