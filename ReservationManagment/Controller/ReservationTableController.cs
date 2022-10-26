using ReservationManagment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManagment.Controller
{ 
    public  class ReservationTableController
    {
        public List<ReservationTable> GetAllTables()
        {
            using (ReservationDbEntities ex = new ReservationDbEntities())
            {
                return ex.ReservationTables.ToList();
            }
        }
        public void CreateTable(ReservationTable r)
        {
            using (ReservationDbEntities ex = new ReservationDbEntities())
            {
                var lastTable = ex.ReservationTables.ToList().LastOrDefault();
                if (lastTable == null)
                {
                    lastTable = new ReservationTable();
                    lastTable.Id = 0;
                }

                r.Id = lastTable.Id + 1;
                ex.ReservationTables.Add(r);
                ex.SaveChanges();
            }
        }
        public void UpdateTable(int id, ReservationTable r)
        {
            using (ReservationDbEntities ex = new ReservationDbEntities())
            {
                var TableToUpdate = ex.ReservationTables.Where(p => p.Id == id).FirstOrDefault();
                if (TableToUpdate != null)
                {
                    TableToUpdate.Id = r.Id;
                    TableToUpdate.Username = r.Username;
                    TableToUpdate.Date = r.Date;
                    TableToUpdate.Description = r.Description;
                    TableToUpdate.TableNum = r.TableNum;
                    ex.SaveChanges();
                }
            }
        }
        public void DeleteTable(int id)
        {
            using (ReservationDbEntities ex = new ReservationDbEntities())
            {
                var TableToDelete = ex.ReservationTables.Where(p => p.Id == id).FirstOrDefault();
                if (TableToDelete != null)
                {
                    ex.ReservationTables.Remove(TableToDelete);
                    ex.SaveChanges();
                }
            }
        }
    }
}
