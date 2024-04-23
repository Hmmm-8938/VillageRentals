using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Village_Rentals_Application
{
    public class Client
    {
        [Required]
        [PrimaryKey]
        public int clientID { get; set; }
        [Required]
        public string clientLastName { get; set; }
        [Required]
        public string clientFirstName { get; set; }
        [Required]
        public string clientContactPhone { get; set; }
        [Required]
        public string clientEmail { get; set; }

        public override string ToString()
        {
            return ($"{clientID} {clientLastName} {clientFirstName} {clientContactPhone} {clientEmail}");
        }

        public Client()
        {
            
        }

        public Client(int clientID, string clientLastName, string clientFirstName, string clientContactPhone, string clientEmail)
        {
            this.clientID = clientID;
            this.clientLastName = clientLastName;
            this.clientFirstName = clientFirstName;
            this.clientContactPhone = clientContactPhone;
            this.clientEmail = clientEmail;
        }
    }
}
