using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Village_Rentals_Application
{
    public class Constants
    {
        public const string DatabaseFilename = "VillageRentals.db3";

        public static string DbPath =>
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
        @"..\..\..\..\..\", DatabaseFilename);

        public Constants()
        {

        }
    }
}
