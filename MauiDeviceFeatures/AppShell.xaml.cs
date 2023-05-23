

using MauiDeviceFeatures.Views;

namespace MauiDeviceFeatures;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();


        Routing.RegisterRoute(nameof(AddEmployee), typeof(AddEmployee));
    
    }
}
