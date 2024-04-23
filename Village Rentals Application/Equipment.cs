using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Village_Rentals_Application
{
    public class Equipment
    {
        [Required]
        [PrimaryKey]
        public int EquipmentId { get; set; }
        [Required]
        public string EquipmentCategory { get; set; }
        [Required]
        public string EquipmentName { get; set; }
        [Required]
        public string EquipmentDescription { get; set; }
        [Required]
        public double EquipmentDailyRentalCost { get; set; }


        public override string ToString()
        {
            return $"{EquipmentId} {EquipmentName}";
        }
        public Equipment()
        {

        }

        public Equipment(int equipmentId, string equipmentCategory, string equipmentName, string equipmentDescription, double equipmentDailyRentalCost)
        {
            this.EquipmentId = equipmentId;
            this.EquipmentCategory = equipmentCategory;
            this.EquipmentName = equipmentName;
            this.EquipmentDescription = equipmentDescription;
            this.EquipmentDailyRentalCost = equipmentDailyRentalCost;
        }
    }
}
