using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using SQLite;
using Newtonsoft.Json;

namespace Village_Rentals_Application
{
    public class Rental
    {
        [Required][PrimaryKey]
        public int rentalId { get; set; }
        [Required]
        public DateTime rentalDate { get; set; }
        [Required]
        public string client { get; set; }
        [Required]
        public string customerLastName { get; set; }
        [Required]
        public string rentalEquipment { get; set; }

        public override string ToString()
        {
            return ($"{rentalId} {rentalDate} {client} {customerLastName} {rentalEquipment}");
        }

        public Rental()
        {

        }

        public Rental(int rentalId, DateTime rentalDate, string client, string customerLastName, string rentalEquipment)
        {
            this.rentalId = rentalId;
            this.rentalDate = rentalDate;
            this.client = client;
            this.customerLastName = customerLastName;
            this.rentalEquipment = rentalEquipment;
        }
    }
}
