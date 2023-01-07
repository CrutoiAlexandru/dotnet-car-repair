namespace Pitshop.Pages;

public partial class PreviousAppointmentsPage : ContentPage
{
	public PreviousAppointmentsPage()
	{
		InitializeComponent();
	}

    private async void OnAppearing(object sender, EventArgs e)
    {
        //var appointments = await _context.Appointments.ToListAsync();
        //AppointmentsListView.ItemsSource = appointments;
    }

    private async void HomeButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Welcome());
    }
}