using ReservationManagment.Controller;
using ReservationManagment.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ReservationManagment
{
    public partial class ReservationCreateView : Form
    {
        ReservationTableController reservationTableController = new ReservationTableController();
        public ReservationCreateView()
        {
            InitializeComponent();
        }
        private void RefreshTable()
        {
            dgvReservationView.DataSource = reservationTableController.GetAllTables();
        }
        private void ReservationCreateView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dgvReservation.ReservationTable' table. You can move, or remove it, as needed.
            this.reservationTableTableAdapter.Fill(this.dgvReservation.ReservationTable);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreateRes_Click(object sender, EventArgs e)
        {
            ReservationTable reservationTable = new ReservationTable();
            reservationTable.Id = 1;
            reservationTable.Username = txtFName.Text;
            reservationTable.Date = DateTPicker.Value;
            reservationTable.Description = txtDescription.Text;
            reservationTable.TableNum = int.Parse(txtResTable.Text);
            reservationTableController.CreateTable(reservationTable);
            RefreshTable();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvReservationView.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            reservationTableController.DeleteTable(id);
            RefreshTable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvReservationView.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            ReservationTable r = new ReservationTable();
            r.Id = id;
            r.Username = txtFName.Text;
            r.Date = DateTPicker.Value;
            r.Description = txtDescription.Text ;
            r.TableNum = int.Parse(txtResTable.Text);
            reservationTableController.UpdateTable(id, r);
            RefreshTable();
        }
    }
}
