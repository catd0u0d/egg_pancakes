namespace WindowsFormsApp1
{
    partial class FromShoppingCart
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
            this.lblOrdererInfo = new System.Windows.Forms.Label();
            this.lblShoppingBag = new System.Windows.Forms.Label();
            this.lblToothpick = new System.Windows.Forms.Label();
            this.BtnRemoveSelected = new System.Windows.Forms.Button();
            this.BtnDeleteAll = new System.Windows.Forms.Button();
            this.BtnPrintOrder = new System.Windows.Forms.Button();
            this.BtnClose1 = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.listViewOrderedItems = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnFinish = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(144)))));
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "購物車 品項列表 🛒";
            // 
            // lblOrdererInfo
            // 
            this.lblOrdererInfo.AutoSize = true;
            this.lblOrdererInfo.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOrdererInfo.Location = new System.Drawing.Point(40, 225);
            this.lblOrdererInfo.Name = "lblOrdererInfo";
            this.lblOrdererInfo.Size = new System.Drawing.Size(162, 37);
            this.lblOrdererInfo.TabIndex = 1;
            this.lblOrdererInfo.Text = "訂購人資訊";
            // 
            // lblShoppingBag
            // 
            this.lblShoppingBag.AutoSize = true;
            this.lblShoppingBag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(231)))), ((int)(((byte)(76)))));
            this.lblShoppingBag.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShoppingBag.Location = new System.Drawing.Point(1022, 148);
            this.lblShoppingBag.Name = "lblShoppingBag";
            this.lblShoppingBag.Size = new System.Drawing.Size(131, 36);
            this.lblShoppingBag.TabIndex = 3;
            this.lblShoppingBag.Text = "加購物袋";
            // 
            // lblToothpick
            // 
            this.lblToothpick.AutoSize = true;
            this.lblToothpick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(231)))), ((int)(((byte)(76)))));
            this.lblToothpick.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToothpick.Location = new System.Drawing.Point(1052, 198);
            this.lblToothpick.Name = "lblToothpick";
            this.lblToothpick.Size = new System.Drawing.Size(102, 36);
            this.lblToothpick.TabIndex = 3;
            this.lblToothpick.Text = "要餐具";
            // 
            // BtnRemoveSelected
            // 
            this.BtnRemoveSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnRemoveSelected.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnRemoveSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(144)))));
            this.BtnRemoveSelected.Location = new System.Drawing.Point(967, 469);
            this.BtnRemoveSelected.Name = "BtnRemoveSelected";
            this.BtnRemoveSelected.Size = new System.Drawing.Size(185, 110);
            this.BtnRemoveSelected.TabIndex = 4;
            this.BtnRemoveSelected.Text = "移除所選品項";
            this.BtnRemoveSelected.UseVisualStyleBackColor = false;
            this.BtnRemoveSelected.Click += new System.EventHandler(this.BtnRemoveSelected_Click);
            // 
            // BtnDeleteAll
            // 
            this.BtnDeleteAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnDeleteAll.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnDeleteAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(144)))));
            this.BtnDeleteAll.Location = new System.Drawing.Point(967, 604);
            this.BtnDeleteAll.Name = "BtnDeleteAll";
            this.BtnDeleteAll.Size = new System.Drawing.Size(185, 110);
            this.BtnDeleteAll.TabIndex = 4;
            this.BtnDeleteAll.Text = "刪除所有品項";
            this.BtnDeleteAll.UseVisualStyleBackColor = false;
            this.BtnDeleteAll.Click += new System.EventHandler(this.BtnDeleteAll_Click);
            // 
            // BtnPrintOrder
            // 
            this.BtnPrintOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnPrintOrder.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnPrintOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(144)))));
            this.BtnPrintOrder.Location = new System.Drawing.Point(968, 739);
            this.BtnPrintOrder.Name = "BtnPrintOrder";
            this.BtnPrintOrder.Size = new System.Drawing.Size(185, 110);
            this.BtnPrintOrder.TabIndex = 4;
            this.BtnPrintOrder.Text = "純文字收據";
            this.BtnPrintOrder.UseVisualStyleBackColor = false;
            this.BtnPrintOrder.Click += new System.EventHandler(this.BtnPrintOrder_Click);
            // 
            // BtnClose1
            // 
            this.BtnClose1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnClose1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(144)))));
            this.BtnClose1.Location = new System.Drawing.Point(969, 875);
            this.BtnClose1.Name = "BtnClose1";
            this.BtnClose1.Size = new System.Drawing.Size(185, 110);
            this.BtnClose1.TabIndex = 4;
            this.BtnClose1.Text = "繼續購物(關閉)";
            this.BtnClose1.UseVisualStyleBackColor = false;
            this.BtnClose1.Click += new System.EventHandler(this.BtnClose1_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(231)))), ((int)(((byte)(76)))));
            this.lblTotal.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(938, 264);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(216, 34);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "訂單總價 xxxx 元";
            // 
            // listViewOrderedItems
            // 
            this.listViewOrderedItems.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listViewOrderedItems.HideSelection = false;
            this.listViewOrderedItems.Location = new System.Drawing.Point(45, 330);
            this.listViewOrderedItems.Name = "listViewOrderedItems";
            this.listViewOrderedItems.Size = new System.Drawing.Size(800, 655);
            this.listViewOrderedItems.TabIndex = 5;
            this.listViewOrderedItems.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(144)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 60);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.egg;
            this.pictureBox2.Location = new System.Drawing.Point(5, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // BtnFinish
            // 
            this.BtnFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnFinish.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnFinish.ForeColor = System.Drawing.Color.Red;
            this.BtnFinish.Location = new System.Drawing.Point(967, 330);
            this.BtnFinish.Name = "BtnFinish";
            this.BtnFinish.Size = new System.Drawing.Size(185, 110);
            this.BtnFinish.TabIndex = 4;
            this.BtnFinish.Text = "結帳";
            this.BtnFinish.UseVisualStyleBackColor = false;
            this.BtnFinish.Click += new System.EventHandler(this.BtnFinish_Click);
            // 
            // FromShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(114)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(1184, 1011);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewOrderedItems);
            this.Controls.Add(this.BtnClose1);
            this.Controls.Add(this.BtnPrintOrder);
            this.Controls.Add(this.BtnDeleteAll);
            this.Controls.Add(this.BtnFinish);
            this.Controls.Add(this.BtnRemoveSelected);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblToothpick);
            this.Controls.Add(this.lblShoppingBag);
            this.Controls.Add(this.lblOrdererInfo);
            this.Name = "FromShoppingCart";
            this.Text = "購物車Form";
            this.Load += new System.EventHandler(this.FromShoppingCart_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrdererInfo;
        private System.Windows.Forms.Label lblShoppingBag;
        private System.Windows.Forms.Label lblToothpick;
        private System.Windows.Forms.Button BtnRemoveSelected;
        private System.Windows.Forms.Button BtnDeleteAll;
        private System.Windows.Forms.Button BtnPrintOrder;
        private System.Windows.Forms.Button BtnClose1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ListView listViewOrderedItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnFinish;
    }
}