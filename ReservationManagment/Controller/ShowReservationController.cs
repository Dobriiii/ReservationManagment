using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReservationManagment.Model;


namespace ReservationManagment.Controller
{
    public class ShowReservationController
    {
        public List<Table> GetAllTables()
        {
            using (ReservationDbEntities ex = new ReservationDbEntities())
            {
                return ex.Tables.ToList();
            }
        }
        public void CreateTable(Table t)
        {
            using (ReservationDbEntities ex = new ReservationDbEntities())
            {
                var lastTable = ex.Tables.ToList().LastOrDefault();
                if (lastTable == null)
                {
                    lastTable = new Table();
                    lastTable.Id = 0;
                }

                t.Id = lastTable.Id + 1;
                ex.Tables.Add(t);
                ex.SaveChanges();
            }
        }
        public void UpdateTable(int id, Table t)
        {
            using (ReservationDbEntities ex = new ReservationDbEntities())
            {
                var TableToUpdate = ex.Tables.Where(p => p.Id == id).FirstOrDefault();
                if (TableToUpdate != null)
                {
                    TableToUpdate.Id = t.Id;
                    TableToUpdate.Slots = t.Slots;
                    TableToUpdate.Smokers = t.Smokers;
                    ex.SaveChanges();
                }
            }
        }
        public void DeleteTable(int id)
        {
            using (ReservationDbEntities ex = new ReservationDbEntities())
            {
                var TableToDelete = ex.Tables.Where(p => p.Id == id).FirstOrDefault();
                if (TableToDelete != null)
                {
                    ex.Tables.Remove(TableToDelete);
                    ex.SaveChanges();
                }
            }
        }
    }
}
