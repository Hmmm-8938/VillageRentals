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
            Equipment equipment = new Equipment(equipmentID, equipmentCategory, equipmentName, equipmentDescription, dailyRentalCost);
            database.Execute($@"INSERT INTO EQUIPMENT (EquipmentId, EquipmentCategory, EquipmentName, EquipmentDescription, EquipmentDailyRentalCost) VALUES ('{equipmentID}', '{equipmentCategory}', '{equipmentName}', '{equipmentDescription}', '{dailyRentalCost}')");
        }

        public static void deleteEquipment(int equipmentID)
        {
            database.Delete<Equipment>(equipmentID);
        }
    }
}
