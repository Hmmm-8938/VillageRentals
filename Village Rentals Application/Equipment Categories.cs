using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Village_Rentals_Application
{
    public class Equipment_Categories
    {
        public int CategoryID { get; set; }
        public string CategoryDescription { get; set; }

        public Equipment_Categories()
        {

        }

        public Equipment_Categories(int categoryID, string categoryDescription)
        {
            this.CategoryID = categoryID;
            this.CategoryDescription = categoryDescription;
        }

        public override string ToString()
        {
            return ($"{CategoryID} || {CategoryDescription}");
        }
    }
}
