namespace Village_Rentals_Application;

public partial class AddNewClient : ContentPage
{
	public AddNewClient()
	{
		InitializeComponent();
	}
    private async void Home_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new VillageRentalsMenu());
    }

    private async void Submit_Clicked(object sender, EventArgs e)
    {
        int clientIDInt = int.Parse(ClientID.Text);
        string clientLastName = ClientLastName.Text;
        string clientFirstName = ClientFirstName.Text;
        string clientContactPhone = ClientContactPhone.Text;
        string clientEmail = ClientEmail.Text;
        DatabaseManager.AddClient(clientIDInt, clientLastName, clientFirstName, clientContactPhone, clientEmail);
        await DisplayAlert("Client Added", "You have succcessfully added a new client.", "OK");
        await Navigation.PushAsync(new AddNewClient());
    }
}