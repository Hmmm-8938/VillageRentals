namespace Village_Rentals_Application;

public partial class AddEquipment : ContentPage
{
	public AddEquipment()
	{
		InitializeComponent();
	}

    private async void DeleteEquipment_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DeleteEquipment());
    }

    private async void Home_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new VillageRentalsMenu());
    }
}