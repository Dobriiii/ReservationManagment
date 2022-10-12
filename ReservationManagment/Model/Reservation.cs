using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManagment.Model
{
    public class Reservation
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public DateTime DateTime { get; set; }
        public string Description { get; set; }
    }
}
