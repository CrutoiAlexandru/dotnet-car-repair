using Pitshop.Pages;

namespace Pitshop;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new Welcome();
	}
}
