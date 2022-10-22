using ReservationManagment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManagment.Controller
{
    public class LoginController
    {
        public string ShowMessage(string username, string password)
        {
            using (ReservationDbEntities ex = new ReservationDbEntities())
            {
                var existingUser = ex.UserTables.Where(u => u.Username == username).FirstOrDefault();

                if (existingUser != null)
                {
                    if (existingUser.Password == password)
                    {

                        return null;

                    }

                    else
                    {

                        return "Wrong Password!";

                    }
                }
                else
                {
                    return "No such user!";
                }
            }
        }
    }
}
