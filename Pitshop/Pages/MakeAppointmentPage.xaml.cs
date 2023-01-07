namespace Pitshop.Pages;

public partial class MakeAppointmentPage : ContentPage
{
	public MakeAppointmentPage()
	{
		InitializeComponent();
	}

    private async void OnMakeAppointmentButtonClicked(object sender, EventArgs e)
    {
        string name = NameField.Text;
        string email = EmailField.Text;
        string plate = PlateField.Text;
        string car_model = CarModelField.Text;
        string issue = IssueField.Text;
        DateTime date = DateField.Date;
        TimeSpan time = TimeField.Time;

        // Send an email with the appointment details
        // ...

        await DisplayAlert("Success", "Appointment made!", "OK");
    }

    private async void HomeButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Welcome());
    }
}