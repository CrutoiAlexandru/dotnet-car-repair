namespace Pitshop.Pages;

public partial class NotificationsPage : ContentPage
{
	public NotificationsPage()
	{
		InitializeComponent();
	}

    private async void HomeButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Welcome());
    }
}