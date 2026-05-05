namespace WindowsFormsApp1
{
    partial class OrderManagementForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnClearData = new System.Windows.Forms.Button();
            this.BtnDataAdded = new System.Windows.Forms.Button();
            this.BtnDataMod = new System.Windows.Forms.Button();
            this.BtnPrintAll = new System.Windows.Forms.Button();
            this.BtnConTest = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnRightArrow = new System.Windows.Forms.Button();
            this.BtnLeftArrow = new System.Windows.Forms.Button();
            this.pictureBoxFP = new System.Windows.Forms.PictureBox();
            this.pictureBoxLP = new System.Windows.Forms.PictureBox();
            this.lblRecord = new System.Windows.Forms.Label();
            this.txtOrderInfo = new System.Windows.Forms.TextBox();
            this.radioCancel = new System.Windows.Forms.RadioButton();
            this.radioCheck = new System.Windows.Forms.RadioButton();
            this.radioWait = new System.Windows.Forms.RadioButton();
            this.radioDone = new System.Windows.Forms.RadioButton();
            this.DTPOrder = new System.Windows.Forms.DateTimePicker();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DTPEnd = new System.Windows.Forms.DateTimePicker();
            this.DTPStart = new System.Windows.Forms.DateTimePicker();
            this.radioCancel2 = new System.Windows.Forms.RadioButton();
            this.radioCheck2 = new System.Windows.Forms.RadioButton();
            this.radioWait2 = new System.Windows.Forms.RadioButton();
            this.radioAllStatus = new System.Windows.Forms.RadioButton();
            this.radioDone2 = new System.Windows.Forms.RadioButton();
            this.BtnSalesReport = new System.Windows.Forms.Button();
            this.BtnAdvancedSearch = new System.Windows.Forms.Button();
            this.txtSearchbyKeyword = new System.Windows.Forms.TextBox();
            this.comboSearchbyKeyword = new System.Windows.Forms.ComboBox();
            this.DGVOrder1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLP)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrder1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBoxHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 63);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "雞蛋糕訂單管理系統";
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(114)))), ((int)(((byte)(172)))));
            this.pictureBoxHome.Image = global::WindowsFormsApp1.Properties.Resources.egg;
            this.pictureBoxHome.Location = new System.Drawing.Point(5, 5);
            this.pictureBoxHome.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(51, 54);
            this.pictureBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHome.TabIndex = 0;
            this.pictureBoxHome.TabStop = false;
            this.pictureBoxHome.Click += new System.EventHandler(this.pictureBoxHome_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(172)))), ((int)(((byte)(213)))));
            this.groupBox1.Controls.Add(this.BtnClearData);
            this.groupBox1.Controls.Add(this.BtnDataAdded);
            this.groupBox1.Controls.Add(this.BtnDataMod);
            this.groupBox1.Controls.Add(this.BtnPrintAll);
            this.groupBox1.Controls.Add(this.BtnConTest);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(15, 70);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1250, 135);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能按鈕";
            // 
            // BtnClearData
            // 
            this.BtnClearData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            this.BtnClearData.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnClearData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(232)))));
            this.BtnClearData.Location = new System.Drawing.Point(1015, 30);
            this.BtnClearData.Margin = new System.Windows.Forms.Padding(2);
            this.BtnClearData.Name = "BtnClearData";
            this.BtnClearData.Size = new System.Drawing.Size(189, 90);
            this.BtnClearData.TabIndex = 0;
            this.BtnClearData.Text = "清空資料";
            this.BtnClearData.UseVisualStyleBackColor = false;
            this.BtnClearData.Click += new System.EventHandler(this.BtnClearData_Click);
            // 
            // BtnDataAdded
            // 
            this.BtnDataAdded.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(232)))));
            this.BtnDataAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnDataAdded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.BtnDataAdded.Location = new System.Drawing.Point(775, 30);
            this.BtnDataAdded.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDataAdded.Name = "BtnDataAdded";
            this.BtnDataAdded.Size = new System.Drawing.Size(189, 90);
            this.BtnDataAdded.TabIndex = 0;
            this.BtnDataAdded.Text = "訂單新增";
            this.BtnDataAdded.UseVisualStyleBackColor = false;
            this.BtnDataAdded.Click += new System.EventHandler(this.BtnDataAdded_Click);
            // 
            // BtnDataMod
            // 
            this.BtnDataMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(232)))));
            this.BtnDataMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnDataMod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.BtnDataMod.Location = new System.Drawing.Point(535, 30);
            this.BtnDataMod.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDataMod.Name = "BtnDataMod";
            this.BtnDataMod.Size = new System.Drawing.Size(189, 90);
            this.BtnDataMod.TabIndex = 0;
            this.BtnDataMod.Text = "訂單修改";
            this.BtnDataMod.UseVisualStyleBackColor = false;
            this.BtnDataMod.Click += new System.EventHandler(this.BtnDataMod_Click);
            // 
            // BtnPrintAll
            // 
            this.BtnPrintAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(232)))));
            this.BtnPrintAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnPrintAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.BtnPrintAll.Location = new System.Drawing.Point(295, 30);
            this.BtnPrintAll.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPrintAll.Name = "BtnPrintAll";
            this.BtnPrintAll.Size = new System.Drawing.Size(189, 90);
            this.BtnPrintAll.TabIndex = 0;
            this.BtnPrintAll.Text = "訂單顯示";
            this.BtnPrintAll.UseVisualStyleBackColor = false;
            this.BtnPrintAll.Click += new System.EventHandler(this.BtnPrintAll_Click);
            // 
            // BtnConTest
            // 
            this.BtnConTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(232)))));
            this.BtnConTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnConTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.BtnConTest.Location = new System.Drawing.Point(55, 30);
            this.BtnConTest.Margin = new System.Windows.Forms.Padding(2);
            this.BtnConTest.Name = "BtnConTest";
            this.BtnConTest.Size = new System.Drawing.Size(189, 90);
            this.BtnConTest.TabIndex = 0;
            this.BtnConTest.Text = "連線測試";
            this.BtnConTest.UseVisualStyleBackColor = false;
            this.BtnConTest.Click += new System.EventHandler(this.BtnConTest_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(223)))));
            this.groupBox2.Controls.Add(this.BtnRightArrow);
            this.groupBox2.Controls.Add(this.BtnLeftArrow);
            this.groupBox2.Controls.Add(this.pictureBoxFP);
            this.groupBox2.Controls.Add(this.pictureBoxLP);
            this.groupBox2.Controls.Add(this.lblRecord);
            this.groupBox2.Controls.Add(this.txtOrderInfo);
            this.groupBox2.Controls.Add(this.radioCancel);
            this.groupBox2.Controls.Add(this.radioCheck);
            this.groupBox2.Controls.Add(this.radioWait);
            this.groupBox2.Controls.Add(this.radioDone);
            this.groupBox2.Controls.Add(this.DTPOrder);
            this.groupBox2.Controls.Add(this.txtNote);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(15, 209);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(675, 741);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "資料欄位";
            // 
            // BtnRightArrow
            // 
            this.BtnRightArrow.Location = new System.Drawing.Point(420, 690);
            this.BtnRightArrow.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRightArrow.Name = "BtnRightArrow";
            this.BtnRightArrow.Size = new System.Drawing.Size(60, 45);
            this.BtnRightArrow.TabIndex = 7;
            this.BtnRightArrow.Text = "下";
            this.BtnRightArrow.UseVisualStyleBackColor = true;
            this.BtnRightArrow.Click += new System.EventHandler(this.BtnRightArrow_Click);
            // 
            // BtnLeftArrow
            // 
            this.BtnLeftArrow.Location = new System.Drawing.Point(141, 690);
            this.BtnLeftArrow.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLeftArrow.Name = "BtnLeftArrow";
            this.BtnLeftArrow.Size = new System.Drawing.Size(60, 45);
            this.BtnLeftArrow.TabIndex = 7;
            this.BtnLeftArrow.Text = "上";
            this.BtnLeftArrow.UseVisualStyleBackColor = true;
            this.BtnLeftArrow.Click += new System.EventHandler(this.BtnLeftArrow_Click);
            // 
            // pictureBoxFP
            // 
            this.pictureBoxFP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(232)))));
            this.pictureBoxFP.Image = global::WindowsFormsApp1.Properties.Resources.first_page;
            this.pictureBoxFP.Location = new System.Drawing.Point(40, 690);
            this.pictureBoxFP.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxFP.Name = "pictureBoxFP";
            this.pictureBoxFP.Size = new System.Drawing.Size(43, 45);
            this.pictureBoxFP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFP.TabIndex = 6;
            this.pictureBoxFP.TabStop = false;
            this.pictureBoxFP.Click += new System.EventHandler(this.pictureBoxFP_Click);
            // 
            // pictureBoxLP
            // 
            this.pictureBoxLP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(232)))));
            this.pictureBoxLP.Image = global::WindowsFormsApp1.Properties.Resources.last_page;
            this.pictureBoxLP.Location = new System.Drawing.Point(553, 690);
            this.pictureBoxLP.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLP.Name = "pictureBoxLP";
            this.pictureBoxLP.Size = new System.Drawing.Size(43, 45);
            this.pictureBoxLP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLP.TabIndex = 6;
            this.pictureBoxLP.TabStop = false;
            this.pictureBoxLP.Click += new System.EventHandler(this.pictureBoxLP_Click);
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            this.lblRecord.Location = new System.Drawing.Point(205, 700);
            this.lblRecord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(211, 35);
            this.lblRecord.TabIndex = 5;
            this.lblRecord.Text = "第 0 筆/共 00 筆";
            // 
            // txtOrderInfo
            // 
            this.txtOrderInfo.Location = new System.Drawing.Point(39, 500);
            this.txtOrderInfo.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderInfo.Multiline = true;
            this.txtOrderInfo.Name = "txtOrderInfo";
            this.txtOrderInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOrderInfo.Size = new System.Drawing.Size(552, 154);
            this.txtOrderInfo.TabIndex = 4;
            // 
            // radioCancel
            // 
            this.radioCancel.AutoSize = true;
            this.radioCancel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.radioCancel.Location = new System.Drawing.Point(493, 333);
            this.radioCancel.Margin = new System.Windows.Forms.Padding(2);
            this.radioCancel.Name = "radioCancel";
            this.radioCancel.Size = new System.Drawing.Size(103, 34);
            this.radioCancel.TabIndex = 3;
            this.radioCancel.TabStop = true;
            this.radioCancel.Text = "已取消";
            this.radioCancel.UseVisualStyleBackColor = true;
            // 
            // radioCheck
            // 
            this.radioCheck.AutoSize = true;
            this.radioCheck.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.radioCheck.Location = new System.Drawing.Point(386, 333);
            this.radioCheck.Margin = new System.Windows.Forms.Padding(2);
            this.radioCheck.Name = "radioCheck";
            this.radioCheck.Size = new System.Drawing.Size(103, 34);
            this.radioCheck.TabIndex = 3;
            this.radioCheck.TabStop = true;
            this.radioCheck.Text = "審核中";
            this.radioCheck.UseVisualStyleBackColor = true;
            // 
            // radioWait
            // 
            this.radioWait.AutoSize = true;
            this.radioWait.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioWait.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.radioWait.Location = new System.Drawing.Point(278, 333);
            this.radioWait.Margin = new System.Windows.Forms.Padding(2);
            this.radioWait.Name = "radioWait";
            this.radioWait.Size = new System.Drawing.Size(103, 34);
            this.radioWait.TabIndex = 3;
            this.radioWait.TabStop = true;
            this.radioWait.Text = "待出貨";
            this.radioWait.UseVisualStyleBackColor = true;
            // 
            // radioDone
            // 
            this.radioDone.AutoSize = true;
            this.radioDone.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioDone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.radioDone.Location = new System.Drawing.Point(171, 333);
            this.radioDone.Margin = new System.Windows.Forms.Padding(2);
            this.radioDone.Name = "radioDone";
            this.radioDone.Size = new System.Drawing.Size(103, 34);
            this.radioDone.TabIndex = 3;
            this.radioDone.TabStop = true;
            this.radioDone.Text = "已出貨";
            this.radioDone.UseVisualStyleBackColor = true;
            // 
            // DTPOrder
            // 
            this.DTPOrder.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DTPOrder.Location = new System.Drawing.Point(171, 255);
            this.DTPOrder.Margin = new System.Windows.Forms.Padding(2);
            this.DTPOrder.Name = "DTPOrder";
            this.DTPOrder.Size = new System.Drawing.Size(263, 39);
            this.DTPOrder.TabIndex = 2;
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNote.Location = new System.Drawing.Point(171, 403);
            this.txtNote.Margin = new System.Windows.Forms.Padding(2);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(410, 39);
            this.txtNote.TabIndex = 1;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotal.Location = new System.Drawing.Point(171, 187);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(263, 39);
            this.txtTotal.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPhone.Location = new System.Drawing.Point(171, 115);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(263, 39);
            this.txtPhone.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(485, 43);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(166, 39);
            this.txtName.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtID.Location = new System.Drawing.Point(171, 43);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(133, 39);
            this.txtID.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(223)))));
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.label9.Location = new System.Drawing.Point(34, 455);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 30);
            this.label9.TabIndex = 0;
            this.label9.Text = "訂單資訊:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(223)))));
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            this.label8.Location = new System.Drawing.Point(34, 405);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 30);
            this.label8.TabIndex = 0;
            this.label8.Text = "備註:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(223)))));
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            this.label7.Location = new System.Drawing.Point(34, 333);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "訂單狀態:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(223)))));
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            this.label6.Location = new System.Drawing.Point(34, 261);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "訂購時間:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(223)))));
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            this.label5.Location = new System.Drawing.Point(35, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "訂單總價:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(223)))));
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            this.label4.Location = new System.Drawing.Point(34, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "訂單電話:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(223)))));
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            this.label3.Location = new System.Drawing.Point(351, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "訂購姓名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(223)))));
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            this.label2.Location = new System.Drawing.Point(34, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "訂單編號:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.DTPEnd);
            this.groupBox3.Controls.Add(this.DTPStart);
            this.groupBox3.Controls.Add(this.radioCancel2);
            this.groupBox3.Controls.Add(this.radioCheck2);
            this.groupBox3.Controls.Add(this.radioWait2);
            this.groupBox3.Controls.Add(this.radioAllStatus);
            this.groupBox3.Controls.Add(this.radioDone2);
            this.groupBox3.Controls.Add(this.BtnSalesReport);
            this.groupBox3.Controls.Add(this.BtnAdvancedSearch);
            this.groupBox3.Controls.Add(this.txtSearchbyKeyword);
            this.groupBox3.Controls.Add(this.comboSearchbyKeyword);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(696, 209);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(569, 450);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "進階搜尋";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(169, 166);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 27);
            this.label10.TabIndex = 10;
            this.label10.Text = "搜尋關鍵字...";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(335, 103);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 31);
            this.label12.TabIndex = 9;
            this.label12.Text = "到";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(335, 35);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 31);
            this.label11.TabIndex = 9;
            this.label11.Text = "從";
            // 
            // DTPEnd
            // 
            this.DTPEnd.Location = new System.Drawing.Point(338, 133);
            this.DTPEnd.Margin = new System.Windows.Forms.Padding(2);
            this.DTPEnd.Name = "DTPEnd";
            this.DTPEnd.Size = new System.Drawing.Size(194, 33);
            this.DTPEnd.TabIndex = 8;
            // 
            // DTPStart
            // 
            this.DTPStart.Location = new System.Drawing.Point(338, 67);
            this.DTPStart.Margin = new System.Windows.Forms.Padding(2);
            this.DTPStart.Name = "DTPStart";
            this.DTPStart.Size = new System.Drawing.Size(194, 33);
            this.DTPStart.TabIndex = 8;
            this.DTPStart.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // radioCancel2
            // 
            this.radioCancel2.AutoSize = true;
            this.radioCancel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.radioCancel2.Location = new System.Drawing.Point(271, 263);
            this.radioCancel2.Margin = new System.Windows.Forms.Padding(2);
            this.radioCancel2.Name = "radioCancel2";
            this.radioCancel2.Size = new System.Drawing.Size(85, 28);
            this.radioCancel2.TabIndex = 4;
            this.radioCancel2.TabStop = true;
            this.radioCancel2.Text = "已取消";
            this.radioCancel2.UseVisualStyleBackColor = true;
            this.radioCancel2.CheckedChanged += new System.EventHandler(this.radioCancel2_CheckedChanged);
            // 
            // radioCheck2
            // 
            this.radioCheck2.AutoSize = true;
            this.radioCheck2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.radioCheck2.Location = new System.Drawing.Point(163, 263);
            this.radioCheck2.Margin = new System.Windows.Forms.Padding(2);
            this.radioCheck2.Name = "radioCheck2";
            this.radioCheck2.Size = new System.Drawing.Size(85, 28);
            this.radioCheck2.TabIndex = 5;
            this.radioCheck2.TabStop = true;
            this.radioCheck2.Text = "審核中";
            this.radioCheck2.UseVisualStyleBackColor = true;
            this.radioCheck2.CheckedChanged += new System.EventHandler(this.radioCheck2_CheckedChanged);
            // 
            // radioWait2
            // 
            this.radioWait2.AutoSize = true;
            this.radioWait2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.radioWait2.Location = new System.Drawing.Point(56, 263);
            this.radioWait2.Margin = new System.Windows.Forms.Padding(2);
            this.radioWait2.Name = "radioWait2";
            this.radioWait2.Size = new System.Drawing.Size(85, 28);
            this.radioWait2.TabIndex = 6;
            this.radioWait2.TabStop = true;
            this.radioWait2.Text = "待出貨";
            this.radioWait2.UseVisualStyleBackColor = true;
            this.radioWait2.CheckedChanged += new System.EventHandler(this.radioWait2_CheckedChanged);
            // 
            // radioAllStatus
            // 
            this.radioAllStatus.AutoSize = true;
            this.radioAllStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.radioAllStatus.Location = new System.Drawing.Point(56, 204);
            this.radioAllStatus.Margin = new System.Windows.Forms.Padding(2);
            this.radioAllStatus.Name = "radioAllStatus";
            this.radioAllStatus.Size = new System.Drawing.Size(66, 28);
            this.radioAllStatus.TabIndex = 7;
            this.radioAllStatus.TabStop = true;
            this.radioAllStatus.Text = "全部";
            this.radioAllStatus.UseVisualStyleBackColor = true;
            this.radioAllStatus.CheckedChanged += new System.EventHandler(this.radioAllStatus_CheckedChanged);
            // 
            // radioDone2
            // 
            this.radioDone2.AutoSize = true;
            this.radioDone2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.radioDone2.Location = new System.Drawing.Point(163, 204);
            this.radioDone2.Margin = new System.Windows.Forms.Padding(2);
            this.radioDone2.Name = "radioDone2";
            this.radioDone2.Size = new System.Drawing.Size(85, 28);
            this.radioDone2.TabIndex = 7;
            this.radioDone2.TabStop = true;
            this.radioDone2.Text = "已出貨";
            this.radioDone2.UseVisualStyleBackColor = true;
            this.radioDone2.CheckedChanged += new System.EventHandler(this.radioDone2_CheckedChanged);
            // 
            // BtnSalesReport
            // 
            this.BtnSalesReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(172)))), ((int)(((byte)(213)))));
            this.BtnSalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnSalesReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.BtnSalesReport.Location = new System.Drawing.Point(319, 324);
            this.BtnSalesReport.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSalesReport.Name = "BtnSalesReport";
            this.BtnSalesReport.Size = new System.Drawing.Size(214, 90);
            this.BtnSalesReport.TabIndex = 2;
            this.BtnSalesReport.Text = "計算營業額報告";
            this.BtnSalesReport.UseVisualStyleBackColor = false;
            // 
            // BtnAdvancedSearch
            // 
            this.BtnAdvancedSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(172)))), ((int)(((byte)(213)))));
            this.BtnAdvancedSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnAdvancedSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.BtnAdvancedSearch.Location = new System.Drawing.Point(56, 324);
            this.BtnAdvancedSearch.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAdvancedSearch.Name = "BtnAdvancedSearch";
            this.BtnAdvancedSearch.Size = new System.Drawing.Size(214, 90);
            this.BtnAdvancedSearch.TabIndex = 2;
            this.BtnAdvancedSearch.Text = "進階搜尋";
            this.BtnAdvancedSearch.UseVisualStyleBackColor = false;
            this.BtnAdvancedSearch.Click += new System.EventHandler(this.BtnAdvancedSearch_Click);
            // 
            // txtSearchbyKeyword
            // 
            this.txtSearchbyKeyword.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSearchbyKeyword.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSearchbyKeyword.Location = new System.Drawing.Point(52, 122);
            this.txtSearchbyKeyword.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchbyKeyword.Name = "txtSearchbyKeyword";
            this.txtSearchbyKeyword.Size = new System.Drawing.Size(241, 43);
            this.txtSearchbyKeyword.TabIndex = 1;
            // 
            // comboSearchbyKeyword
            // 
            this.comboSearchbyKeyword.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboSearchbyKeyword.FormattingEnabled = true;
            this.comboSearchbyKeyword.Location = new System.Drawing.Point(52, 56);
            this.comboSearchbyKeyword.Margin = new System.Windows.Forms.Padding(2);
            this.comboSearchbyKeyword.Name = "comboSearchbyKeyword";
            this.comboSearchbyKeyword.Size = new System.Drawing.Size(241, 42);
            this.comboSearchbyKeyword.TabIndex = 0;
            // 
            // DGVOrder1
            // 
            this.DGVOrder1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVOrder1.Location = new System.Drawing.Point(697, 666);
            this.DGVOrder1.Margin = new System.Windows.Forms.Padding(2);
            this.DGVOrder1.Name = "DGVOrder1";
            this.DGVOrder1.RowTemplate.Height = 24;
            this.DGVOrder1.Size = new System.Drawing.Size(569, 284);
            this.DGVOrder1.TabIndex = 4;
            this.DGVOrder1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVOrder1_CellClick_1);
            // 
            // OrderManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1284, 961);
            this.Controls.Add(this.DGVOrder1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "OrderManagementForm";
            this.Text = "雞蛋糕訂單管理Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderManagementForm_FormClosing);
            this.Load += new System.EventHandler(this.OrderManagementForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLP)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrder1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxHome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnConTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnDataAdded;
        private System.Windows.Forms.Button BtnDataMod;
        private System.Windows.Forms.Button BtnPrintAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnClearData;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtOrderInfo;
        private System.Windows.Forms.RadioButton radioCancel;
        private System.Windows.Forms.RadioButton radioCheck;
        private System.Windows.Forms.RadioButton radioWait;
        private System.Windows.Forms.RadioButton radioDone;
        private System.Windows.Forms.DateTimePicker DTPOrder;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.PictureBox pictureBoxFP;
        private System.Windows.Forms.PictureBox pictureBoxLP;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Button BtnSalesReport;
        private System.Windows.Forms.Button BtnAdvancedSearch;
        private System.Windows.Forms.TextBox txtSearchbyKeyword;
        private System.Windows.Forms.ComboBox comboSearchbyKeyword;
        private System.Windows.Forms.RadioButton radioCancel2;
        private System.Windows.Forms.RadioButton radioCheck2;
        private System.Windows.Forms.RadioButton radioWait2;
        private System.Windows.Forms.RadioButton radioAllStatus;
        private System.Windows.Forms.RadioButton radioDone2;
        private System.Windows.Forms.DateTimePicker DTPEnd;
        private System.Windows.Forms.DateTimePicker DTPStart;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnRightArrow;
        private System.Windows.Forms.Button BtnLeftArrow;
        private System.Windows.Forms.DataGridView DGVOrder1;
        private System.Windows.Forms.Label label10;
    }
}