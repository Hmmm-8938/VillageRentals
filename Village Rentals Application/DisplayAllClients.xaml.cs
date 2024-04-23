namespace Village_Rentals_Application;

public partial class DisplayAllClients : ContentPage
{
	public DisplayAllClients()
	{
		InitializeComponent();

        List<Client> clients = DatabaseManager.GetAllClients();
        clientList.ItemsSource = clients;
	}
    private async void Home_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new VillageRentalsMenu());
    }
}