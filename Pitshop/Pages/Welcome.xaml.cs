namespace Pitshop.Pages;

public partial class Welcome : ContentPage
{
	public Welcome()
	{
		InitializeComponent();
	}

    private async void OnMakeAppointmentButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new MakeAppointmentPage());
    }

    private async void OnPreviousAppointmentsButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new PreviousAppointmentsPage());
    }

    private async void OnNotificationsButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new NotificationsPage());
    }
}