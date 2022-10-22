namespace ReservationManagment.View
{
    partial class RegisterView
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
            this.lblReg = new System.Windows.Forms.Label();
            this.btnRegCreate = new System.Windows.Forms.Button();
            this.lblRegPass = new System.Windows.Forms.Label();
            this.lblRegUsername = new System.Windows.Forms.Label();
            this.txtRegPass = new System.Windows.Forms.TextBox();
            this.txtRegUName = new System.Windows.Forms.TextBox();
            this.lblRegPN = new System.Windows.Forms.Label();
            this.txtRegPN = new System.Windows.Forms.TextBox();
            this.btnGoToLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReg
            // 
            this.lblReg.BackColor = System.Drawing.Color.Transparent;
            this.lblReg.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReg.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblReg.Location = new System.Drawing.Point(9, 7);
            this.lblReg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(191, 425);
            this.lblReg.TabIndex = 2;
            this.lblReg.Text = "Регистрация";
            this.lblReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegCreate
            // 
            this.btnRegCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnRegCreate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRegCreate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegCreate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegCreate.Location = new System.Drawing.Point(234, 378);
            this.btnRegCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegCreate.Name = "btnRegCreate";
            this.btnRegCreate.Size = new System.Drawing.Size(187, 25);
            this.btnRegCreate.TabIndex = 18;
            this.btnRegCreate.Text = "Създай профил";
            this.btnRegCreate.UseVisualStyleBackColor = false;
            this.btnRegCreate.Click += new System.EventHandler(this.btnRegCreate_Click);
            // 
            // lblRegPass
            // 
            this.lblRegPass.BackColor = System.Drawing.Color.Transparent;
            this.lblRegPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegPass.ForeColor = System.Drawing.Color.Black;
            this.lblRegPass.Location = new System.Drawing.Point(234, 136);
            this.lblRegPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegPass.Name = "lblRegPass";
            this.lblRegPass.Size = new System.Drawing.Size(187, 31);
            this.lblRegPass.TabIndex = 17;
            this.lblRegPass.Text = "Парола";
            this.lblRegPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRegUsername
            // 
            this.lblRegUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblRegUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegUsername.ForeColor = System.Drawing.Color.Black;
            this.lblRegUsername.Location = new System.Drawing.Point(234, 32);
            this.lblRegUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegUsername.Name = "lblRegUsername";
            this.lblRegUsername.Size = new System.Drawing.Size(187, 31);
            this.lblRegUsername.TabIndex = 16;
            this.lblRegUsername.Text = "Потребителско име";
            this.lblRegUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRegPass
            // 
            this.txtRegPass.Location = new System.Drawing.Point(234, 180);
            this.txtRegPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRegPass.Multiline = true;
            this.txtRegPass.Name = "txtRegPass";
            this.txtRegPass.Size = new System.Drawing.Size(188, 29);
            this.txtRegPass.TabIndex = 15;
            // 
            // txtRegUName
            // 
            this.txtRegUName.Location = new System.Drawing.Point(234, 76);
            this.txtRegUName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRegUName.Multiline = true;
            this.txtRegUName.Name = "txtRegUName";
            this.txtRegUName.Size = new System.Drawing.Size(188, 29);
            this.txtRegUName.TabIndex = 14;
            // 
            // lblRegPN
            // 
            this.lblRegPN.BackColor = System.Drawing.Color.Transparent;
            this.lblRegPN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegPN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegPN.ForeColor = System.Drawing.Color.Black;
            this.lblRegPN.Location = new System.Drawing.Point(234, 250);
            this.lblRegPN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegPN.Name = "lblRegPN";
            this.lblRegPN.Size = new System.Drawing.Size(187, 31);
            this.lblRegPN.TabIndex = 20;
            this.lblRegPN.Text = "Телефонен номер";
            this.lblRegPN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRegPN
            // 
            this.txtRegPN.Location = new System.Drawing.Point(234, 294);
            this.txtRegPN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRegPN.Multiline = true;
            this.txtRegPN.Name = "txtRegPN";
            this.txtRegPN.Size = new System.Drawing.Size(188, 29);
            this.txtRegPN.TabIndex = 19;
            this.txtRegPN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnGoToLogin
            // 
            this.btnGoToLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnGoToLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGoToLogin.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGoToLogin.Location = new System.Drawing.Point(526, 407);
            this.btnGoToLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoToLogin.Name = "btnGoToLogin";
            this.btnGoToLogin.Size = new System.Drawing.Size(113, 25);
            this.btnGoToLogin.TabIndex = 21;
            this.btnGoToLogin.Text = "Логин";
            this.btnGoToLogin.UseVisualStyleBackColor = false;
            this.btnGoToLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(11, 404);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 25);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Излез";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // RegisterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReservationManagment.Properties.Resources.ImageRes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 440);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGoToLogin);
            this.Controls.Add(this.lblRegPN);
            this.Controls.Add(this.txtRegPN);
            this.Controls.Add(this.btnRegCreate);
            this.Controls.Add(this.lblRegPass);
            this.Controls.Add(this.lblRegUsername);
            this.Controls.Add(this.txtRegPass);
            this.Controls.Add(this.txtRegUName);
            this.Controls.Add(this.lblReg);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegisterView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Button btnRegCreate;
        private System.Windows.Forms.Label lblRegPass;
        private System.Windows.Forms.Label lblRegUsername;
        private System.Windows.Forms.TextBox txtRegPass;
        private System.Windows.Forms.TextBox txtRegUName;
        private System.Windows.Forms.Label lblRegPN;
        private System.Windows.Forms.TextBox txtRegPN;
        private System.Windows.Forms.Button btnGoToLogin;
        private System.Windows.Forms.Button btnExit;
    }
}