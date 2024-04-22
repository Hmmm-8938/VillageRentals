namespace Village_Rentals_Application;

public partial class DeleteEquipment : ContentPage
{
	public DeleteEquipment()
	{
		InitializeComponent();
	}

    private async void AddEquipment_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddEquipment());
    }
    private async void Home_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new VillageRentalsMenu());
    }
}