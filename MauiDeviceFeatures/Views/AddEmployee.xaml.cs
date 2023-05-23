using MauiDeviceFeatures.ViewModels;

namespace MauiDeviceFeatures.Views;

public partial class AddEmployee : ContentPage
{
	public AddEmployee(AddEmployeeViewModel viewModel)
	{
		InitializeComponent();

        this.BindingContext = viewModel;
    }
}