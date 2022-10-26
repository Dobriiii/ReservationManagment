namespace ReservationManagment
{
    partial class ReservationCreateView
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
            this.lblResCreate = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.DateTPicker = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnCreateRes = new System.Windows.Forms.Button();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblDateTPicker = new System.Windows.Forms.Label();
            this.lblTableNum = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtResTable = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvReservationView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvReservation = new ReservationManagment.dgvReservation();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.reservationTableTableAdapter = new ReservationManagment.dgvReservationTableAdapters.ReservationTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResCreate
            // 
            this.lblResCreate.BackColor = System.Drawing.Color.Transparent;
            this.lblResCreate.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResCreate.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblResCreate.Location = new System.Drawing.Point(25, 21);
            this.lblResCreate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResCreate.Name = "lblResCreate";
            this.lblResCreate.Size = new System.Drawing.Size(188, 65);
            this.lblResCreate.TabIndex = 0;
            this.lblResCreate.Text = "Създаване на резервация";
            this.lblResCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(25, 145);
            this.txtFName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFName.Multiline = true;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(188, 29);
            this.txtFName.TabIndex = 1;
            // 
            // DateTPicker
            // 
            this.DateTPicker.Location = new System.Drawing.Point(25, 218);
            this.DateTPicker.Margin = new System.Windows.Forms.Padding(2);
            this.DateTPicker.Name = "DateTPicker";
            this.DateTPicker.Size = new System.Drawing.Size(188, 20);
            this.DateTPicker.TabIndex = 5;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(25, 377);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(188, 74);
            this.txtDescription.TabIndex = 8;
            // 
            // btnCreateRes
            // 
            this.btnCreateRes.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateRes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCreateRes.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreateRes.Location = new System.Drawing.Point(340, 480);
            this.btnCreateRes.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateRes.Name = "btnCreateRes";
            this.btnCreateRes.Size = new System.Drawing.Size(109, 25);
            this.btnCreateRes.TabIndex = 9;
            this.btnCreateRes.Text = "Запиши \r\n";
            this.btnCreateRes.UseVisualStyleBackColor = false;
            this.btnCreateRes.Click += new System.EventHandler(this.btnCreateRes_Click);
            // 
            // lblFName
            // 
            this.lblFName.BackColor = System.Drawing.Color.Transparent;
            this.lblFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.ForeColor = System.Drawing.Color.Black;
            this.lblFName.Location = new System.Drawing.Point(62, 109);
            this.lblFName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(115, 19);
            this.lblFName.TabIndex = 10;
            this.lblFName.Text = "Потребител";
            this.lblFName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateTPicker
            // 
            this.lblDateTPicker.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDateTPicker.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTPicker.Location = new System.Drawing.Point(62, 186);
            this.lblDateTPicker.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateTPicker.Name = "lblDateTPicker";
            this.lblDateTPicker.Size = new System.Drawing.Size(115, 19);
            this.lblDateTPicker.TabIndex = 13;
            this.lblDateTPicker.Text = "Дата и час";
            this.lblDateTPicker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTableNum
            // 
            this.lblTableNum.BackColor = System.Drawing.Color.Transparent;
            this.lblTableNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTableNum.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableNum.Location = new System.Drawing.Point(62, 262);
            this.lblTableNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTableNum.Name = "lblTableNum";
            this.lblTableNum.Size = new System.Drawing.Size(115, 19);
            this.lblTableNum.TabIndex = 14;
            this.lblTableNum.Text = "Маса";
            this.lblTableNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescription.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(62, 337);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(115, 19);
            this.lblDescription.TabIndex = 16;
            this.lblDescription.Text = "Описание";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtResTable
            // 
            this.txtResTable.Location = new System.Drawing.Point(62, 293);
            this.txtResTable.Margin = new System.Windows.Forms.Padding(2);
            this.txtResTable.Multiline = true;
            this.txtResTable.Name = "txtResTable";
            this.txtResTable.Size = new System.Drawing.Size(115, 29);
            this.txtResTable.TabIndex = 17;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(746, 9);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 25);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Излез";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvReservationView
            // 
            this.dgvReservationView.AutoGenerateColumns = false;
            this.dgvReservationView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservationView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.tableNumDataGridViewTextBoxColumn});
            this.dgvReservationView.DataSource = this.reservationTableBindingSource;
            this.dgvReservationView.Location = new System.Drawing.Point(257, 66);
            this.dgvReservationView.Name = "dgvReservationView";
            this.dgvReservationView.Size = new System.Drawing.Size(543, 385);
            this.dgvReservationView.TabIndex = 20;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // tableNumDataGridViewTextBoxColumn
            // 
            this.tableNumDataGridViewTextBoxColumn.DataPropertyName = "TableNum";
            this.tableNumDataGridViewTextBoxColumn.HeaderText = "TableNum";
            this.tableNumDataGridViewTextBoxColumn.Name = "tableNumDataGridViewTextBoxColumn";
            // 
            // reservationTableBindingSource
            // 
            this.reservationTableBindingSource.DataMember = "ReservationTable";
            this.reservationTableBindingSource.DataSource = this.dgvReservation;
            // 
            // dgvReservation
            // 
            this.dgvReservation.DataSetName = "dgvReservation";
            this.dgvReservation.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Transparent;
            this.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDel.Location = new System.Drawing.Point(473, 480);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(109, 25);
            this.btnDel.TabIndex = 21;
            this.btnDel.Text = "Изтрий";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(613, 480);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 25);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Обнови";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // reservationTableTableAdapter
            // 
            this.reservationTableTableAdapter.ClearBeforeFill = true;
            // 
            // ReservationCreateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReservationManagment.Properties.Resources.ImageRes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 531);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.dgvReservationView);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtResTable);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTableNum);
            this.Controls.Add(this.lblDateTPicker);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.btnCreateRes);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.DateTPicker);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblResCreate);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReservationCreateView";
            this.Load += new System.EventHandler(this.ReservationCreateView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResCreate;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.DateTimePicker DateTPicker;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnCreateRes;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblDateTPicker;
        private System.Windows.Forms.Label lblTableNum;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtResTable;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvReservationView;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private dgvReservation dgvReservation;
        private System.Windows.Forms.BindingSource reservationTableBindingSource;
        private dgvReservationTableAdapters.ReservationTableTableAdapter reservationTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableNumDataGridViewTextBoxColumn;
    }
}

