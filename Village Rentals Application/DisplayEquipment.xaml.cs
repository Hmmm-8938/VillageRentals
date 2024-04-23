namespace Village_Rentals_Application;

public partial class DisplayEquipment : ContentPage
{
	public DisplayEquipment()
	{
		InitializeComponent();
        List<Equipment> EquipmentList = DatabaseManager.GetAllEquipment();
        equipmentList.ItemsSource = EquipmentList;
	}
    private async void Home_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new VillageRentalsMenu());
    }
}