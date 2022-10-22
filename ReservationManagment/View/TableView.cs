using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReservationManagment.Controller;
using ReservationManagment.Model;

namespace ReservationManagment.View
{
    
    public partial class TableView : Form
    {
        ShowReservationController showReservationController = new ShowReservationController();
        public TableView()
        {
            InitializeComponent();
        }
        private void RefreshTable()
        {
            dgvTableView.DataSource = showReservationController.GetAllTables();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TableView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reservationDbDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.reservationDbDataSet.Table);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Table table = new Table();
            table.Id = 1;
            table.Slots = int.Parse(txtTableSlot.Text);
            table.Smokers = checkBoxSmokers.Checked;
            showReservationController.CreateTable(table);
            RefreshTable();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvTableView.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            showReservationController.DeleteTable(id);
            RefreshTable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvTableView.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            Table t = new Table();
            t.Id = id;
            t.Slots = int.Parse(txtTableSlot.Text);
            t.Smokers = checkBoxSmokers.Checked;
            showReservationController.UpdateTable(id, t);
            RefreshTable();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

