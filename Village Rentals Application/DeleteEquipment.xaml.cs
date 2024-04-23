using System.Text.RegularExpressions;
namespace Village_Rentals_Application;

public partial class DeleteEquipment : ContentPage
{
	public DeleteEquipment()
	{
		InitializeComponent();
        List<Equipment> equipmentList = DatabaseManager.GetAllEquipment();
        equipmentPicker.ItemsSource = equipmentList;
    }

    private async void AddEquipment_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddEquipment());
    }
    private async void Home_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new VillageRentalsMenu());
    }

    private async void Submit_Clicked(object sender, EventArgs e)
    {
        string equipmentID = equipmentPicker.SelectedItem.ToString();
        string pattern = @"^\d+";
        Match match = Regex.Match(equipmentID, pattern);
        int equipmentIDDelete = int.Parse(match.Value);
        DatabaseManager.deleteEquipment(equipmentIDDelete);
        await DisplayAlert("Equipment Deleted", "Equipment was successfully deleted", "OK");
        await Navigation.PushAsync(new DeleteEquipment());
    }
}