namespace ReservationManagment.View
{
    partial class TableView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvTableView = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtTableSlot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reservationDbDataSet = new ReservationManagment.ReservationDbDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new ReservationManagment.ReservationDbDataSetTableAdapters.TableTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slotsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smokersDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.checkBoxSmokers = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTableView
            // 
            this.dgvTableView.AutoGenerateColumns = false;
            this.dgvTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.slotsDataGridViewTextBoxColumn,
            this.smokersDataGridViewCheckBoxColumn});
            this.dgvTableView.DataSource = this.tableBindingSource;
            this.dgvTableView.Location = new System.Drawing.Point(411, 44);
            this.dgvTableView.Name = "dgvTableView";
            this.dgvTableView.RowHeadersWidth = 51;
            this.dgvTableView.RowTemplate.Height = 24;
            this.dgvTableView.Size = new System.Drawing.Size(566, 339);
            this.dgvTableView.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(67, 451);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 45);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добави";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(258, 451);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(125, 45);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Премахни";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(443, 451);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 45);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Обнови";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtTableSlot
            // 
            this.txtTableSlot.Location = new System.Drawing.Point(124, 134);
            this.txtTableSlot.Multiline = true;
            this.txtTableSlot.Name = "txtTableSlot";
            this.txtTableSlot.Size = new System.Drawing.Size(95, 38);
            this.txtTableSlot.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Места";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 37);
            this.label3.TabIndex = 9;
            this.label3.Text = "Пушачи";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reservationDbDataSet
            // 
            this.reservationDbDataSet.DataSetName = "ReservationDbDataSet";
            this.reservationDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.reservationDbDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // slotsDataGridViewTextBoxColumn
            // 
            this.slotsDataGridViewTextBoxColumn.DataPropertyName = "Slots";
            this.slotsDataGridViewTextBoxColumn.HeaderText = "Slots";
            this.slotsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.slotsDataGridViewTextBoxColumn.Name = "slotsDataGridViewTextBoxColumn";
            this.slotsDataGridViewTextBoxColumn.Width = 125;
            // 
            // smokersDataGridViewCheckBoxColumn
            // 
            this.smokersDataGridViewCheckBoxColumn.DataPropertyName = "Smokers";
            this.smokersDataGridViewCheckBoxColumn.HeaderText = "Smokers";
            this.smokersDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.smokersDataGridViewCheckBoxColumn.Name = "smokersDataGridViewCheckBoxColumn";
            this.smokersDataGridViewCheckBoxColumn.Width = 125;
            // 
            // checkBoxSmokers
            // 
            this.checkBoxSmokers.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxSmokers.Location = new System.Drawing.Point(165, 215);
            this.checkBoxSmokers.Name = "checkBoxSmokers";
            this.checkBoxSmokers.Size = new System.Drawing.Size(54, 58);
            this.checkBoxSmokers.TabIndex = 10;
            this.checkBoxSmokers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxSmokers.UseVisualStyleBackColor = false;
            // 
            // TableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReservationManagment.Properties.Resources.ImageRes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 592);
            this.Controls.Add(this.checkBoxSmokers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTableSlot);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvTableView);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TableView";
            this.Load += new System.EventHandler(this.TableView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTableView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtTableSlot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ReservationDbDataSet reservationDbDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private ReservationDbDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slotsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn smokersDataGridViewCheckBoxColumn;
        private System.Windows.Forms.CheckBox checkBoxSmokers;
    }
}