namespace WindowsFormsApp1
{
    partial class HomePageForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMenu = new System.Windows.Forms.ComboBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.pictureBoxShop = new System.Windows.Forms.PictureBox();
            this.fadetimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(233)))));
            this.label1.Location = new System.Drawing.Point(76, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome, where warmth begins.";
            // 
            // comboBoxMenu
            // 
            this.comboBoxMenu.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxMenu.FormattingEnabled = true;
            this.comboBoxMenu.Location = new System.Drawing.Point(160, 450);
            this.comboBoxMenu.Name = "comboBoxMenu";
            this.comboBoxMenu.Size = new System.Drawing.Size(350, 44);
            this.comboBoxMenu.TabIndex = 2;
            this.comboBoxMenu.SelectedIndexChanged += new System.EventHandler(this.comboBoxMenu_SelectedIndexChanged);
            // 
            // BtnConnect
            // 
            this.BtnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.BtnConnect.Cursor = System.Windows.Forms.Cursors.Cross;
            this.BtnConnect.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.BtnConnect.Location = new System.Drawing.Point(160, 520);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(350, 50);
            this.BtnConnect.TabIndex = 3;
            this.BtnConnect.Text = "連    線";
            this.BtnConnect.UseVisualStyleBackColor = false;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.lblLogin.Location = new System.Drawing.Point(531, 63);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(54, 26);
            this.lblLogin.TabIndex = 5;
            this.lblLogin.Text = "登出";
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.Image = global::WindowsFormsApp1.Properties.Resources.login;
            this.pictureBoxLogin.Location = new System.Drawing.Point(622, 12);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogin.TabIndex = 4;
            this.pictureBoxLogin.TabStop = false;
            this.pictureBoxLogin.Click += new System.EventHandler(this.pictureBoxLogin_Click);
            // 
            // pictureBoxShop
            // 
            this.pictureBoxShop.Location = new System.Drawing.Point(125, 15);
            this.pictureBoxShop.Name = "pictureBoxShop";
            this.pictureBoxShop.Size = new System.Drawing.Size(400, 350);
            this.pictureBoxShop.TabIndex = 0;
            this.pictureBoxShop.TabStop = false;
            // 
            // fadetimer
            // 
            this.fadetimer.Interval = 30;
            this.fadetimer.Tick += new System.EventHandler(this.fadetimer_Tick);
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pictureBoxLogin);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.comboBoxMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxShop);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HomePageForm";
            this.Text = "首頁Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomePageForm_FormClosed);
            this.Load += new System.EventHandler(this.HomePageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxShop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMenu;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Timer fadetimer;
    }
}