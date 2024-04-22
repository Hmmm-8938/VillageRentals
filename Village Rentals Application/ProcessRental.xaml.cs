namespace Village_Rentals_Application;

public partial class ProcessRental : ContentPage
{
	public ProcessRental()
	{
		InitializeComponent();
	}
    private async void Home_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new VillageRentalsMenu());
    }
}