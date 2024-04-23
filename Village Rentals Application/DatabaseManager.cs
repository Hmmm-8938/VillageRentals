using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Village_Rentals_Application
{
    public class DatabaseManager
    {
        public static SQLiteConnection database;

        public DatabaseManager()
        {
            database = new SQLiteConnection(Constants.DbPath);

            database.CreateTable<Equipment>();
            database.CreateTable<Equipment_Categories>();
            database.CreateTable<Client>();
            database.CreateTable<Rental>();
        }

        public static List<Equipment_Categories> GetAllCategorys()
        {
            return database.Query<Equipment_Categories>($@"SELECT * FROM Equipment_Categories");
        }

        public static List<Equipment> GetAllEquipment()
        {
            return database.Query<Equipment>($@"SELECT * FROM Equipment");
        }

        public static void AddEquipment(int equipmentID, string equipmentCategory, string equipmentName, string equipmentDescription, double dailyRentalCost)
        {
            database.Execute($@"INSERT INTO EQUIPMENT (EquipmentId, EquipmentCategory, EquipmentName, EquipmentDescription, EquipmentDailyRentalCost) VALUES ('{equipmentID}', '{equipmentCategory}', '{equipmentName}', '{equipmentDescription}', '{dailyRentalCost}')");
        }

        public static void deleteEquipment(int equipmentID)
        {
            database.Delete<Equipment>(equipmentID);
        }

        public static void AddClient(int clientID, string clientLastName, string clientFirstName, string clientContactPhone, string clientEmail)
        {
            database.Execute($@"INSERT INTO CLIENT (clientID, clientLastName, clientFirstName, clientContactPhone, clientEmail) VALUES ('{clientID}', '{clientLastName}', '{clientFirstName}', '{clientContactPhone}', '{clientEmail}')");
        }

        public static List<Client> GetAllClients()
        {
            return database.Query<Client>($@"SELECT * FROM Client");
        }

        public static void AddRental(int rentalId, DateTime rentalDate, string client, string customerLastName, string rentalEquipment)
        {
            database.Execute($@"INSERT INTO RENTAL (rentalId, rentalDate, client, customerLastName, rentalEquipment) VALUES ('{rentalId}','{rentalDate}','{client}','{customerLastName}','{rentalEquipment}')");
        }
    }
}
