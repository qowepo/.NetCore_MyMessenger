
namespace MessengerClientWinForms
{
    public partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.lblName = new System.Windows.Forms.Label();
            this.lbxChat = new System.Windows.Forms.ListBox();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.tbxUserMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.gbxSend = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxAuthorization = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSendUser = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbxFun = new System.Windows.Forms.PictureBox();
            this.pbxCorrect = new System.Windows.Forms.PictureBox();
            this.pbxUser = new System.Windows.Forms.PictureBox();
            this.gbxSend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAuthorization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblName.Location = new System.Drawing.Point(6, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(274, 81);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "lblName";
            // 
            // lbxChat
            // 
            this.lbxChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxChat.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbxChat.FormattingEnabled = true;
            this.lbxChat.ItemHeight = 18;
            this.lbxChat.Location = new System.Drawing.Point(0, 177);
            this.lbxChat.Name = "lbxChat";
            this.lbxChat.Size = new System.Drawing.Size(712, 328);
            this.lbxChat.TabIndex = 3;
            // 
            // tbxUserName
            // 
            this.tbxUserName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbxUserName.Enabled = false;
            this.tbxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxUserName.Location = new System.Drawing.Point(20, 560);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(260, 29);
            this.tbxUserName.TabIndex = 4;
            this.tbxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxUserMessage
            // 
            this.tbxUserMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxUserMessage.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbxUserMessage.Location = new System.Drawing.Point(20, 638);
            this.tbxUserMessage.Name = "tbxUserMessage";
            this.tbxUserMessage.Size = new System.Drawing.Size(672, 26);
            this.tbxUserMessage.TabIndex = 5;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSend.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSend.Location = new System.Drawing.Point(557, 560);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(135, 52);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click_1);
            // 
            // gbxSend
            // 
            this.gbxSend.Controls.Add(this.label1);
            this.gbxSend.Controls.Add(this.pbxAuthorization);
            this.gbxSend.Controls.Add(this.lbxChat);
            this.gbxSend.Controls.Add(this.label2);
            this.gbxSend.Controls.Add(this.lblName);
            this.gbxSend.Controls.Add(this.lblSendUser);
            this.gbxSend.Controls.Add(this.tbxUserMessage);
            this.gbxSend.Controls.Add(this.btnSend);
            this.gbxSend.Controls.Add(this.tbxUserName);
            this.gbxSend.Location = new System.Drawing.Point(49, 12);
            this.gbxSend.Name = "gbxSend";
            this.gbxSend.Size = new System.Drawing.Size(713, 697);
            this.gbxSend.TabIndex = 7;
            this.gbxSend.TabStop = false;
            this.gbxSend.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(16, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "This is a standard status, you can change it in the settings...";
            // 
            // pbxAuthorization
            // 
            this.pbxAuthorization.BackgroundImage = global::MessengerClientWinForms.Properties.Resources.login;
            this.pbxAuthorization.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxAuthorization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxAuthorization.Location = new System.Drawing.Point(630, 19);
            this.pbxAuthorization.Name = "pbxAuthorization";
            this.pbxAuthorization.Size = new System.Drawing.Size(77, 73);
            this.pbxAuthorization.TabIndex = 2;
            this.pbxAuthorization.TabStop = false;
            this.pbxAuthorization.Click += new System.EventHandler(this.pbxAuthorization_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(17, 613);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Your Message";
            // 
            // lblSendUser
            // 
            this.lblSendUser.AutoSize = true;
            this.lblSendUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSendUser.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblSendUser.Location = new System.Drawing.Point(17, 533);
            this.lblSendUser.Name = "lblSendUser";
            this.lblSendUser.Size = new System.Drawing.Size(76, 16);
            this.lblSendUser.TabIndex = 7;
            this.lblSendUser.Text = "Your Name";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbxFun
            // 
            this.pbxFun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pbxFun.Image = global::MessengerClientWinForms.Properties.Resources.aut;
            this.pbxFun.Location = new System.Drawing.Point(782, 389);
            this.pbxFun.Name = "pbxFun";
            this.pbxFun.Size = new System.Drawing.Size(496, 287);
            this.pbxFun.TabIndex = 10;
            this.pbxFun.TabStop = false;
            this.pbxFun.Visible = false;
            // 
            // pbxCorrect
            // 
            this.pbxCorrect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxCorrect.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbxCorrect.BackgroundImage = global::MessengerClientWinForms.Properties.Resources.correct;
            this.pbxCorrect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCorrect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxCorrect.Location = new System.Drawing.Point(1180, 31);
            this.pbxCorrect.Name = "pbxCorrect";
            this.pbxCorrect.Size = new System.Drawing.Size(87, 87);
            this.pbxCorrect.TabIndex = 8;
            this.pbxCorrect.TabStop = false;
            this.pbxCorrect.Visible = false;
            // 
            // pbxUser
            // 
            this.pbxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxUser.Image = global::MessengerClientWinForms.Properties.Resources.user;
            this.pbxUser.Location = new System.Drawing.Point(793, 31);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(381, 332);
            this.pbxUser.TabIndex = 0;
            this.pbxUser.TabStop = false;
            this.pbxUser.Visible = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1302, 749);
            this.Controls.Add(this.pbxFun);
            this.Controls.Add(this.pbxCorrect);
            this.Controls.Add(this.gbxSend);
            this.Controls.Add(this.pbxUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1270, 726);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainPage_FormClosed);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.gbxSend.ResumeLayout(false);
            this.gbxSend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAuthorization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            this.ResumeLayout(false);

        } 

        #endregion

        public System.Windows.Forms.PictureBox pbxUser;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.PictureBox pbxAuthorization;
        public System.Windows.Forms.ListBox lbxChat;
        public System.Windows.Forms.TextBox tbxUserName;
        public System.Windows.Forms.TextBox tbxUserMessage;
        public System.Windows.Forms.Button btnSend;
        public System.Windows.Forms.GroupBox gbxSend;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblSendUser;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.PictureBox pbxCorrect;
        public System.Windows.Forms.PictureBox pbxFun;
    }
}