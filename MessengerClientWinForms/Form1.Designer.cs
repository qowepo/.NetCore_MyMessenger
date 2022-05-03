
namespace MessengerClientWinForms
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.pbxFun = new System.Windows.Forms.PictureBox();
            this.pbxEye = new System.Windows.Forms.PictureBox();
            this.pbxSend = new System.Windows.Forms.PictureBox();
            this.lblQowepo = new System.Windows.Forms.Label();
            this.lblGram = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSend)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxLogin
            // 
            this.tbxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxLogin.Location = new System.Drawing.Point(441, 158);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(162, 26);
            this.tbxLogin.TabIndex = 0;
            this.tbxLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxPassword.Location = new System.Drawing.Point(441, 204);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(162, 26);
            this.tbxPassword.TabIndex = 1;
            this.tbxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogin.Location = new System.Drawing.Point(49, 154);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(73, 29);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.Location = new System.Drawing.Point(26, 200);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(120, 29);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // lblRegistration
            // 
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRegistration.Location = new System.Drawing.Point(274, 391);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(115, 15);
            this.lblRegistration.TabIndex = 4;
            this.lblRegistration.Text = "Create new account";
            this.lblRegistration.Click += new System.EventHandler(this.lblRegistration_Click);
            // 
            // pbxFun
            // 
            this.pbxFun.Image = global::MessengerClientWinForms.Properties.Resources.reg;
            this.pbxFun.Location = new System.Drawing.Point(-57, -55);
            this.pbxFun.Name = "pbxFun";
            this.pbxFun.Size = new System.Drawing.Size(743, 521);
            this.pbxFun.TabIndex = 7;
            this.pbxFun.TabStop = false;
            // 
            // pbxEye
            // 
            this.pbxEye.BackgroundImage = global::MessengerClientWinForms.Properties.Resources.eye;
            this.pbxEye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxEye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxEye.Location = new System.Drawing.Point(578, 204);
            this.pbxEye.Name = "pbxEye";
            this.pbxEye.Size = new System.Drawing.Size(25, 26);
            this.pbxEye.TabIndex = 6;
            this.pbxEye.TabStop = false;
            this.pbxEye.Click += new System.EventHandler(this.pbxEye_Click);
            // 
            // pbxSend
            // 
            this.pbxSend.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbxSend.BackgroundImage = global::MessengerClientWinForms.Properties.Resources.send;
            this.pbxSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSend.Location = new System.Drawing.Point(526, 296);
            this.pbxSend.Name = "pbxSend";
            this.pbxSend.Size = new System.Drawing.Size(77, 73);
            this.pbxSend.TabIndex = 5;
            this.pbxSend.TabStop = false;
            this.pbxSend.Click += new System.EventHandler(this.pbxSend_Click);
            // 
            // lblQowepo
            // 
            this.lblQowepo.AutoSize = true;
            this.lblQowepo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblQowepo.Cursor = System.Windows.Forms.Cursors.No;
            this.lblQowepo.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQowepo.Location = new System.Drawing.Point(16, 20);
            this.lblQowepo.Name = "lblQowepo";
            this.lblQowepo.Size = new System.Drawing.Size(139, 44);
            this.lblQowepo.TabIndex = 8;
            this.lblQowepo.Text = "QOWEPO";
            this.lblQowepo.Click += new System.EventHandler(this.lblQowepo_Click);
            // 
            // lblGram
            // 
            this.lblGram.AutoSize = true;
            this.lblGram.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGram.Cursor = System.Windows.Forms.Cursors.No;
            this.lblGram.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGram.Location = new System.Drawing.Point(518, 20);
            this.lblGram.Name = "lblGram";
            this.lblGram.Size = new System.Drawing.Size(97, 44);
            this.lblGram.TabIndex = 9;
            this.lblGram.Text = "GRAM";
            this.lblGram.Click += new System.EventHandler(this.lblGram_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 431);
            this.Controls.Add(this.lblGram);
            this.Controls.Add(this.lblQowepo);
            this.Controls.Add(this.pbxEye);
            this.Controls.Add(this.pbxSend);
            this.Controls.Add(this.lblRegistration);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxLogin);
            this.Controls.Add(this.pbxFun);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(651, 470);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(651, 470);
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Authorization_FormClosed);
            this.Load += new System.EventHandler(this.Authorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxLogin;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.PictureBox pbxSend;
        private System.Windows.Forms.PictureBox pbxEye;
        private System.Windows.Forms.PictureBox pbxFun;
        private System.Windows.Forms.Label lblQowepo;
        private System.Windows.Forms.Label lblGram;
    }
}

