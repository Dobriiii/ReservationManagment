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
            this.lblResCreate = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtPNumber = new System.Windows.Forms.TextBox();
            this.DateTPicker = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnCreateRes = new System.Windows.Forms.Button();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblPNumber = new System.Windows.Forms.Label();
            this.lblDateTPicker = new System.Windows.Forms.Label();
            this.lblTableNum = new System.Windows.Forms.Label();
            this.lblSmokersNum = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtResTable = new System.Windows.Forms.TextBox();
            this.txtSmokersNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblResCreate
            // 
            this.lblResCreate.BackColor = System.Drawing.Color.Transparent;
            this.lblResCreate.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResCreate.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblResCreate.Location = new System.Drawing.Point(306, 9);
            this.lblResCreate.Name = "lblResCreate";
            this.lblResCreate.Size = new System.Drawing.Size(255, 80);
            this.lblResCreate.TabIndex = 0;
            this.lblResCreate.Text = "Създаване на резервация";
            this.lblResCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(278, 126);
            this.txtFName.Multiline = true;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(153, 35);
            this.txtFName.TabIndex = 1;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(437, 126);
            this.txtLName.Multiline = true;
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(153, 35);
            this.txtLName.TabIndex = 2;
            // 
            // txtPNumber
            // 
            this.txtPNumber.Location = new System.Drawing.Point(312, 194);
            this.txtPNumber.Multiline = true;
            this.txtPNumber.Name = "txtPNumber";
            this.txtPNumber.Size = new System.Drawing.Size(249, 35);
            this.txtPNumber.TabIndex = 4;
            // 
            // DateTPicker
            // 
            this.DateTPicker.Location = new System.Drawing.Point(312, 258);
            this.DateTPicker.Name = "DateTPicker";
            this.DateTPicker.Size = new System.Drawing.Size(249, 22);
            this.DateTPicker.TabIndex = 5;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(312, 382);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(249, 35);
            this.txtDescription.TabIndex = 8;
            // 
            // btnCreateRes
            // 
            this.btnCreateRes.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateRes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCreateRes.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreateRes.Location = new System.Drawing.Point(312, 457);
            this.btnCreateRes.Name = "btnCreateRes";
            this.btnCreateRes.Size = new System.Drawing.Size(249, 31);
            this.btnCreateRes.TabIndex = 9;
            this.btnCreateRes.Text = "Запиши резервация";
            this.btnCreateRes.UseVisualStyleBackColor = false;
            // 
            // lblFName
            // 
            this.lblFName.BackColor = System.Drawing.Color.Transparent;
            this.lblFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.ForeColor = System.Drawing.Color.Black;
            this.lblFName.Location = new System.Drawing.Point(278, 100);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(153, 23);
            this.lblFName.TabIndex = 10;
            this.lblFName.Text = "Име";
            this.lblFName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLName
            // 
            this.lblLName.BackColor = System.Drawing.Color.Transparent;
            this.lblLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.Location = new System.Drawing.Point(437, 100);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(153, 23);
            this.lblLName.TabIndex = 11;
            this.lblLName.Text = "Фамилия";
            this.lblLName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPNumber
            // 
            this.lblPNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPNumber.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPNumber.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblPNumber.Location = new System.Drawing.Point(361, 168);
            this.lblPNumber.Name = "lblPNumber";
            this.lblPNumber.Size = new System.Drawing.Size(153, 23);
            this.lblPNumber.TabIndex = 12;
            this.lblPNumber.Text = "Телефонен номер";
            this.lblPNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateTPicker
            // 
            this.lblDateTPicker.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDateTPicker.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTPicker.Location = new System.Drawing.Point(361, 232);
            this.lblDateTPicker.Name = "lblDateTPicker";
            this.lblDateTPicker.Size = new System.Drawing.Size(153, 23);
            this.lblDateTPicker.TabIndex = 13;
            this.lblDateTPicker.Text = "Дата и час";
            this.lblDateTPicker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTableNum
            // 
            this.lblTableNum.BackColor = System.Drawing.Color.Transparent;
            this.lblTableNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTableNum.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableNum.Location = new System.Drawing.Point(312, 294);
            this.lblTableNum.Name = "lblTableNum";
            this.lblTableNum.Size = new System.Drawing.Size(119, 23);
            this.lblTableNum.TabIndex = 14;
            this.lblTableNum.Text = "Маса";
            this.lblTableNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSmokersNum
            // 
            this.lblSmokersNum.BackColor = System.Drawing.Color.Transparent;
            this.lblSmokersNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSmokersNum.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmokersNum.Location = new System.Drawing.Point(441, 294);
            this.lblSmokersNum.Name = "lblSmokersNum";
            this.lblSmokersNum.Size = new System.Drawing.Size(120, 23);
            this.lblSmokersNum.TabIndex = 15;
            this.lblSmokersNum.Text = "Пушачи";
            this.lblSmokersNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescription.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(361, 356);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(153, 23);
            this.lblDescription.TabIndex = 16;
            this.lblDescription.Text = "Описание";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtResTable
            // 
            this.txtResTable.Location = new System.Drawing.Point(312, 320);
            this.txtResTable.Multiline = true;
            this.txtResTable.Name = "txtResTable";
            this.txtResTable.Size = new System.Drawing.Size(119, 35);
            this.txtResTable.TabIndex = 17;
            // 
            // txtSmokersNum
            // 
            this.txtSmokersNum.Location = new System.Drawing.Point(437, 318);
            this.txtSmokersNum.Multiline = true;
            this.txtSmokersNum.Name = "txtSmokersNum";
            this.txtSmokersNum.Size = new System.Drawing.Size(124, 35);
            this.txtSmokersNum.TabIndex = 18;
            // 
            // ReservationCreateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReservationManagment.Properties.Resources.ImageRes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(890, 569);
            this.Controls.Add(this.txtSmokersNum);
            this.Controls.Add(this.txtResTable);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblSmokersNum);
            this.Controls.Add(this.lblTableNum);
            this.Controls.Add(this.lblDateTPicker);
            this.Controls.Add(this.lblPNumber);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.btnCreateRes);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.DateTPicker);
            this.Controls.Add(this.txtPNumber);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblResCreate);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReservationCreateView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResCreate;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtPNumber;
        private System.Windows.Forms.DateTimePicker DateTPicker;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnCreateRes;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblPNumber;
        private System.Windows.Forms.Label lblDateTPicker;
        private System.Windows.Forms.Label lblTableNum;
        private System.Windows.Forms.Label lblSmokersNum;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtResTable;
        private System.Windows.Forms.TextBox txtSmokersNum;
    }
}

