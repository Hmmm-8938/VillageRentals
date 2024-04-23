using Microsoft.Maui.Graphics.Text;
using System.Globalization;

namespace Village_Rentals_Application;

public partial class AddEquipment : ContentPage
{
    public AddEquipment()
    {
        InitializeComponent();
        List<Equipment_Categories> categoryList = DatabaseManager.GetAllCategorys();
        CategoryPicker.ItemsSource = categoryList;
        EquipmentID.IsReadOnly = true;
    }

    private async void DeleteEquipment_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DeleteEquipment());
    }

    private async void Home_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new VillageRentalsMenu());
    }

    private async void Submit_Clicked(object sender, EventArgs e)
    {
        int equipmentIDInt = int.Parse(EquipmentID.Text);
        string equipmentCategory = ($"{EquipmentID.Text[0]}{EquipmentID.Text[1]}");
        string equipmentName = EquipmentName.Text;
        string equipmentDescription = EquipmentDescription.Text;
        double equipmentDailyRentalCost = double.Parse(EquipmentDailyRentalCost.Text);
        DatabaseManager.AddEquipment(equipmentIDInt, equipmentCategory, equipmentName, equipmentDescription, equipmentDailyRentalCost);
        await DisplayAlert("Equipment Added", "You have succcessfully added equipment.", "OK");
        await Navigation.PushAsync(new AddEquipment());
    }

    private async void CategoryPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        string equipmentCategoryAndEquipmentID = CategoryPicker.SelectedItem.ToString();
        equipmentCategoryAndEquipmentID = ($"{equipmentCategoryAndEquipmentID[0]}{equipmentCategoryAndEquipmentID[1]}");
        EquipmentID.Text = ($"{equipmentCategoryAndEquipmentID}");
        EquipmentID.Text = ($"{equipmentCategoryAndEquipmentID}{await DisplayPromptAsync("Specify Equipment ID", $"Specify the item number starting with {equipmentCategoryAndEquipmentID}", "OK", "Cancel", null, 3, null, "")}");
    }
}