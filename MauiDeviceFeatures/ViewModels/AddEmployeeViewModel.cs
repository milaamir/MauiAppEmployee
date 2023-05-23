using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using MauiDeviceFeatures.Models;
using MauiDeviceFeatures.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiDeviceFeatures.ViewModels
{

    [QueryProperty(nameof(AddEmployee), "AddEmployee")]
    public partial class AddEmployeeViewModel : ObservableObject
    {

        [ObservableProperty]
        private Employee employeeDetails = new Employee();

        private readonly IEmployeeService _employeeService;
        public AddEmployeeViewModel(IEmployeeService employeeService)
        {
            _employeeService = employeeService; 
        }




        [ICommand]
        public async  void AddEmployee()
        {
            var response = await _employeeService.AddEmployee(employeeDetails);
            if(response > 0)
            {
                await Shell.Current.DisplayAlert("Record Added", "Employee Details Successfully submitted", "OK");
            }
            else
            {
                await Shell.Current.DisplayAlert("Not Addedd", "Something went wrong with the Employees Details", "OK");

            }
        }


        
    }
}
