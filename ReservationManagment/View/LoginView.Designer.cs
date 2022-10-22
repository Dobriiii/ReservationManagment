namespace ReservationManagment.View
{
    partial class LoginView
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
            this.lblLoginWelcome = new System.Windows.Forms.Label();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.txtLoginPass = new System.Windows.Forms.TextBox();
            this.lblLoginUsername = new System.Windows.Forms.Label();
            this.lblLoginPass = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnGoToReg = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoginWelcome
            // 
            this.lblLoginWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginWelcome.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginWelcome.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblLoginWelcome.Location = new System.Drawing.Point(230, 31);
            this.lblLoginWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoginWelcome.Name = "lblLoginWelcome";
            this.lblLoginWelcome.Size = new System.Drawing.Size(191, 65);
            this.lblLoginWelcome.TabIndex = 1;
            this.lblLoginWelcome.Text = "Добре Дошли\r\n\r\n\r\n";
            this.lblLoginWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(235, 165);
            this.txtLoginName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLoginName.Multiline = true;
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(188, 29);
            this.txtLoginName.TabIndex = 2;
            // 
            // txtLoginPass
            // 
            this.txtLoginPass.Location = new System.Drawing.Point(235, 276);
            this.txtLoginPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLoginPass.Multiline = true;
            this.txtLoginPass.Name = "txtLoginPass";
            this.txtLoginPass.Size = new System.Drawing.Size(188, 29);
            this.txtLoginPass.TabIndex = 3;
            // 
            // lblLoginUsername
            // 
            this.lblLoginUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLoginUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginUsername.ForeColor = System.Drawing.Color.Black;
            this.lblLoginUsername.Location = new System.Drawing.Point(235, 132);
            this.lblLoginUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoginUsername.Name = "lblLoginUsername";
            this.lblLoginUsername.Size = new System.Drawing.Size(187, 31);
            this.lblLoginUsername.TabIndex = 11;
            this.lblLoginUsername.Text = "Потребителско име";
            this.lblLoginUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLoginPass
            // 
            this.lblLoginPass.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLoginPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginPass.ForeColor = System.Drawing.Color.Black;
            this.lblLoginPass.Location = new System.Drawing.Point(235, 243);
            this.lblLoginPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoginPass.Name = "lblLoginPass";
            this.lblLoginPass.Size = new System.Drawing.Size(187, 31);
            this.lblLoginPass.TabIndex = 12;
            this.lblLoginPass.Text = "Парола";
            this.lblLoginPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogin.Location = new System.Drawing.Point(235, 337);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(187, 25);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Влез";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnGoToReg
            // 
            this.btnGoToReg.BackColor = System.Drawing.Color.Transparent;
            this.btnGoToReg.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGoToReg.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToReg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGoToReg.Location = new System.Drawing.Point(526, 404);
            this.btnGoToReg.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoToReg.Name = "btnGoToReg";
            this.btnGoToReg.Size = new System.Drawing.Size(113, 25);
            this.btnGoToReg.TabIndex = 14;
            this.btnGoToReg.Text = "Регистрация";
            this.btnGoToReg.UseVisualStyleBackColor = false;
            this.btnGoToReg.Click += new System.EventHandler(this.btnGoToReg_Click);
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
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Излез";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReservationManagment.Properties.Resources.ImageRes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 440);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGoToReg);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblLoginPass);
            this.Controls.Add(this.lblLoginUsername);
            this.Controls.Add(this.txtLoginPass);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.lblLoginWelcome);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginWelcome;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.TextBox txtLoginPass;
        private System.Windows.Forms.Label lblLoginUsername;
        private System.Windows.Forms.Label lblLoginPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnGoToReg;
        private System.Windows.Forms.Button btnExit;
    }
}