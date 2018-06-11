using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Ioc;
using FirstModule.ViewModel.Interface;
using FirstModule.ViewModel.Implementation;
using FirstModule.View;
using Prism.Mvvm;
using Prism.Regions;

namespace FirstModule
{
    [Module(ModuleName= "RahulFirstModule", OnDemand =false)]
    public class RahulFirstModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            IRegionManager regionManager = containerProvider.Resolve<IRegionManager>();

            // Uncomment this to make it work: --> This call injects view to ShellRegion.
            //regionManager.RegisterViewWithRegion("ShellRegion", () => containerProvider.Resolve<EmployeeFormView>());

            /*
             * But RequestNavigate is not working...
             * Seems like I am doing something wrong, but I need to use journals for making wizard like UI, so I need to understand working of  regionManager.RequestNavigate.
             */
            regionManager.RequestNavigate("ShellRegion", new Uri("EmployeeFormView", UriKind.Relative), this.NavigateCallback);
        }

        private void NavigateCallback(NavigationResult obj)
        {
            //throw new NotImplementedException();
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IEmployeeFormViewModel, EmployeeFormViewModel>();
            containerRegistry.Register<EmployeeFormView>();
            ViewModelLocationProvider.Register<EmployeeFormView, IEmployeeFormViewModel>();
        }
    }
}
