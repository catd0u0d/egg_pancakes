namespace WindowsFormsApp1
{
    partial class PrivacyPolicy
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxInfoIcon = new System.Windows.Forms.PictureBox();
            this.lblWord = new System.Windows.Forms.Label();
            this.txtPolicy = new System.Windows.Forms.TextBox();
            this.BtnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfoIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(1)))), ((int)(((byte)(21)))));
            this.label1.Location = new System.Drawing.Point(65, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "商家隱私權聲明";
            // 
            // pictureBoxInfoIcon
            // 
            this.pictureBoxInfoIcon.Image = global::WindowsFormsApp1.Properties.Resources.exclamation;
            this.pictureBoxInfoIcon.Location = new System.Drawing.Point(5, 5);
            this.pictureBoxInfoIcon.Name = "pictureBoxInfoIcon";
            this.pictureBoxInfoIcon.Size = new System.Drawing.Size(56, 48);
            this.pictureBoxInfoIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInfoIcon.TabIndex = 2;
            this.pictureBoxInfoIcon.TabStop = false;
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.lblWord.Location = new System.Drawing.Point(35, 70);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(73, 20);
            this.lblWord.TabIndex = 4;
            this.lblWord.Text = "說明文字";
            // 
            // txtPolicy
            // 
            this.txtPolicy.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPolicy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.txtPolicy.Location = new System.Drawing.Point(35, 100);
            this.txtPolicy.Multiline = true;
            this.txtPolicy.Name = "txtPolicy";
            this.txtPolicy.ReadOnly = true;
            this.txtPolicy.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPolicy.Size = new System.Drawing.Size(610, 512);
            this.txtPolicy.TabIndex = 5;
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(235)))));
            this.BtnBack.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnBack.Location = new System.Drawing.Point(545, 30);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(100, 50);
            this.BtnBack.TabIndex = 6;
            this.BtnBack.Text = "返回註冊";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // PrivacyPolicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(197)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.txtPolicy);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxInfoIcon);
            this.Name = "PrivacyPolicy";
            this.Text = "商家隱私權聲明";
            this.Load += new System.EventHandler(this.PrivacyPolicy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfoIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxInfoIcon;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.TextBox txtPolicy;
        private System.Windows.Forms.Button BtnBack;
    }
}