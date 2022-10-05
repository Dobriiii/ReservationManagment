using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManagment.Model
{
    public class Reservation
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateTime { get; set; }
        public int PhoneNumber { get; set; }
        public string Description { get; set; }

        public int Smokers { get; set; }
    }
}
