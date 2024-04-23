using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace Village_Rentals_Application;

public partial class ProcessRental : ContentPage
{
	public ProcessRental()
	{
		InitializeComponent();
        List<Equipment> equipmentList = DatabaseManager.GetAllEquipment();
        equipmentPicker.ItemsSource = equipmentList;
        List<Client> clientList = DatabaseManager.GetAllClients();
        clientPicker.ItemsSource = clientList;
	}
    private async void Home_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new VillageRentalsMenu());
    }

    private async void Submit_Clicked(object sender, EventArgs e)
    {
        int rentalID = int.Parse(RentalId.Text);
        DateTime rentalDate = RentalDate.Date;
        Client client = (Client)clientPicker.SelectedItem;
        string clientLastName = ClientLastName.Text;
        Equipment equipment = (Equipment)equipmentPicker.SelectedItem;

        string clientString = JsonConvert.SerializeObject(client);
        string equipmentString = JsonConvert.SerializeObject(equipment);

        DatabaseManager.AddRental(rentalID, rentalDate, clientString, clientLastName, equipmentString);
        await DisplayAlert("Rental Added", "You have successfully processed a rental.", "OK");
    }

    private void clientPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        string cLast = clientPicker.SelectedItem.ToString();
        string pattern = @"^\d+\s+(\w+)";
        Match match = Regex.Match(cLast, pattern);
        cLast = match.Groups[1].Value;
        ClientLastName.Text = cLast;
    }
}