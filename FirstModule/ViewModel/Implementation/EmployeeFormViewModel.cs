using FirstModule.ViewModel.Interface;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstModule.ViewModel.Implementation
{
    public class EmployeeFormViewModel : BindableBase, IEmployeeFormViewModel
    {
        private string _name;
        private string _empId;
        private string _city;

        public EmployeeFormViewModel()
        {
            this.Name = "John";
            this.EmpID = "JD-100218";
            this.City = "London";
        }

        public string City
        {
            get { return _city; }
            set { this.SetProperty<string>(ref this._city, value); }
        }


        public string EmpID
        {
            get { return _empId; }
            set { this.SetProperty<string>(ref this._empId, value); }
        }


        public string Name
        {
            get { return _name; }
            set { this.SetProperty<string>(ref this._name, value); }
        }

    }
}
