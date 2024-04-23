namespace Village_Rentals_Application;

public partial class VillageRentalsMenu : ContentPage
{
	public VillageRentalsMenu()
	{
		InitializeComponent();
        DatabaseManager database = new DatabaseManager();
	}

    private async void AddDeleteEquipment_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddEquipment());
    }

    private async void AddNewClient_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddNewClient());
    }

    private async void DisplayEquipment_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DisplayEquipment());
    }

    private async void DisplayAllClients_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DisplayAllClients());
    }

    private async void ProcessRental_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProcessRental());
    }
}