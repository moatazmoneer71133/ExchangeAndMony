namespace ExchangeAndMony.pages.accountsInterface.accountsInitializatuionInterface
{
    partial class CurrencyPricesGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrencyPricesGuide));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tbCurrenciesPricesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTAEMDataSet = new ExchangeAndMony.DBTAEMDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTtranferFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTtranferTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTtranferPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellingPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLowPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHeghtPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLowPricePay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLowPriceSelling = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHeghtPricePay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHeghtPriceSelling = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_print = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_exit = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_CurrenciesPricesTableAdapter = new ExchangeAndMony.DBTAEMDataSetTableAdapters.Tb_CurrenciesPricesTableAdapter();
            this.picture_Search = new System.Windows.Forms.PictureBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCurrenciesPricesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTAEMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(6, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1308, 771);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tbCurrenciesPricesBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 437);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(1308, 334);
            this.gridControl1.TabIndex = 12;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tbCurrenciesPricesBindingSource
            // 
            this.tbCurrenciesPricesBindingSource.DataMember = "Tb_CurrenciesPrices";
            this.tbCurrenciesPricesBindingSource.DataSource = this.dBTAEMDataSet;
            // 
            // dBTAEMDataSet
            // 
            this.dBTAEMDataSet.DataSetName = "DBTAEMDataSet";
            this.dBTAEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.FixedLine.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FixedLine.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTtranferFrom,
            this.colTtranferTo,
            this.colTtranferPrice,
            this.colPurchPrice,
            this.colSellingPrice,
            this.colLowPrice,
            this.colHeghtPrice,
            this.colLowPricePay,
            this.colLowPriceSelling,
            this.colHeghtPricePay,
            this.colHeghtPriceSelling,
            this.colNote});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colTtranferFrom
            // 
            this.colTtranferFrom.Caption = "التحويل من";
            this.colTtranferFrom.FieldName = "TtranferFrom";
            this.colTtranferFrom.MinWidth = 25;
            this.colTtranferFrom.Name = "colTtranferFrom";
            this.colTtranferFrom.Visible = true;
            this.colTtranferFrom.VisibleIndex = 0;
            this.colTtranferFrom.Width = 89;
            // 
            // colTtranferTo
            // 
            this.colTtranferTo.Caption = "التحويل الي";
            this.colTtranferTo.FieldName = "TtranferTo";
            this.colTtranferTo.MinWidth = 25;
            this.colTtranferTo.Name = "colTtranferTo";
            this.colTtranferTo.Visible = true;
            this.colTtranferTo.VisibleIndex = 1;
            this.colTtranferTo.Width = 89;
            // 
            // colTtranferPrice
            // 
            this.colTtranferPrice.Caption = "سعر التحويل";
            this.colTtranferPrice.FieldName = "TtranferPrice";
            this.colTtranferPrice.MinWidth = 25;
            this.colTtranferPrice.Name = "colTtranferPrice";
            this.colTtranferPrice.Visible = true;
            this.colTtranferPrice.VisibleIndex = 2;
            this.colTtranferPrice.Width = 89;
            // 
            // colPurchPrice
            // 
            this.colPurchPrice.Caption = "سعر الشراء";
            this.colPurchPrice.FieldName = "PurchPrice";
            this.colPurchPrice.MinWidth = 25;
            this.colPurchPrice.Name = "colPurchPrice";
            this.colPurchPrice.Visible = true;
            this.colPurchPrice.VisibleIndex = 3;
            this.colPurchPrice.Width = 89;
            // 
            // colSellingPrice
            // 
            this.colSellingPrice.Caption = "سعر البيع";
            this.colSellingPrice.FieldName = "SellingPrice";
            this.colSellingPrice.MinWidth = 25;
            this.colSellingPrice.Name = "colSellingPrice";
            this.colSellingPrice.Visible = true;
            this.colSellingPrice.VisibleIndex = 4;
            this.colSellingPrice.Width = 89;
            // 
            // colLowPrice
            // 
            this.colLowPrice.Caption = "السعر الادنى";
            this.colLowPrice.FieldName = "LowPrice";
            this.colLowPrice.MinWidth = 25;
            this.colLowPrice.Name = "colLowPrice";
            this.colLowPrice.Visible = true;
            this.colLowPrice.VisibleIndex = 5;
            this.colLowPrice.Width = 89;
            // 
            // colHeghtPrice
            // 
            this.colHeghtPrice.Caption = "السعر الاعلى";
            this.colHeghtPrice.FieldName = "HeghtPrice";
            this.colHeghtPrice.MinWidth = 25;
            this.colHeghtPrice.Name = "colHeghtPrice";
            this.colHeghtPrice.Visible = true;
            this.colHeghtPrice.VisibleIndex = 6;
            this.colHeghtPrice.Width = 89;
            // 
            // colLowPricePay
            // 
            this.colLowPricePay.Caption = "سعر الادنى للشراء";
            this.colLowPricePay.FieldName = "LowPricePay";
            this.colLowPricePay.MinWidth = 25;
            this.colLowPricePay.Name = "colLowPricePay";
            this.colLowPricePay.Visible = true;
            this.colLowPricePay.VisibleIndex = 7;
            this.colLowPricePay.Width = 89;
            // 
            // colLowPriceSelling
            // 
            this.colLowPriceSelling.Caption = "السعر الادنى للبيع";
            this.colLowPriceSelling.FieldName = "LowPriceSelling";
            this.colLowPriceSelling.MinWidth = 25;
            this.colLowPriceSelling.Name = "colLowPriceSelling";
            this.colLowPriceSelling.Visible = true;
            this.colLowPriceSelling.VisibleIndex = 8;
            this.colLowPriceSelling.Width = 89;
            // 
            // colHeghtPricePay
            // 
            this.colHeghtPricePay.Caption = "السعر الاعلى للشراء";
            this.colHeghtPricePay.FieldName = "HeghtPricePay";
            this.colHeghtPricePay.MinWidth = 25;
            this.colHeghtPricePay.Name = "colHeghtPricePay";
            this.colHeghtPricePay.Visible = true;
            this.colHeghtPricePay.VisibleIndex = 9;
            this.colHeghtPricePay.Width = 89;
            // 
            // colHeghtPriceSelling
            // 
            this.colHeghtPriceSelling.Caption = "السعر الاعلى للبيع";
            this.colHeghtPriceSelling.FieldName = "HeghtPriceSelling";
            this.colHeghtPriceSelling.MinWidth = 25;
            this.colHeghtPriceSelling.Name = "colHeghtPriceSelling";
            this.colHeghtPriceSelling.Visible = true;
            this.colHeghtPriceSelling.VisibleIndex = 10;
            this.colHeghtPriceSelling.Width = 89;
            // 
            // colNote
            // 
            this.colNote.Caption = "ملاحظات";
            this.colNote.FieldName = "Note";
            this.colNote.MinWidth = 25;
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 11;
            this.colNote.Width = 102;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Location = new System.Drawing.Point(28, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1265, 260);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(550, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 23);
            this.label14.TabIndex = 53;
            this.label14.Text = "أعلى سعر بيع";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(552, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 23);
            this.label5.TabIndex = 52;
            this.label5.Text = "أعلى سعر شراء";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(387, 156);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(159, 26);
            this.textBox10.TabIndex = 51;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(387, 116);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 26);
            this.textBox2.TabIndex = 50;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(860, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 23);
            this.label13.TabIndex = 49;
            this.label13.Text = "أدنى سعر بيع";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(861, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 23);
            this.label7.TabIndex = 48;
            this.label7.Text = "أدنى سعر شراء";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(696, 156);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(159, 26);
            this.textBox9.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1159, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 23);
            this.label12.TabIndex = 44;
            this.label12.Text = "سعر البيع";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(696, 118);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(159, 26);
            this.textBox5.TabIndex = 46;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(996, 156);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(159, 26);
            this.textBox8.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1161, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 23);
            this.label11.TabIndex = 45;
            this.label11.Text = "سعر الشراء";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(996, 116);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(159, 26);
            this.textBox7.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(552, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 23);
            this.label9.TabIndex = 41;
            this.label9.Text = "السعر الأعلى";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(387, 73);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(159, 26);
            this.textBox3.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(861, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 23);
            this.label8.TabIndex = 39;
            this.label8.Text = "السعر الأدنى";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(696, 75);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 26);
            this.textBox1.TabIndex = 38;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Items.AddRange(new object[] {
            "حساب",
            "نقد"});
            this.comboBox1.Location = new System.Drawing.Point(692, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(163, 24);
            this.comboBox1.TabIndex = 37;
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.comboBox2.IntegralHeight = false;
            this.comboBox2.Items.AddRange(new object[] {
            "حساب",
            "نقد"});
            this.comboBox2.Location = new System.Drawing.Point(992, 32);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox2.Size = new System.Drawing.Size(163, 24);
            this.comboBox2.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(861, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "التحويل الى ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1161, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 23);
            this.label10.TabIndex = 34;
            this.label10.Text = "ملاحظات";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1161, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 23);
            this.label6.TabIndex = 33;
            this.label6.Text = "سعر التحويل";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1161, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "التحويل من ";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(996, 73);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(159, 26);
            this.textBox6.TabIndex = 31;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(387, 210);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(768, 25);
            this.textBox4.TabIndex = 30;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_edit);
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.btn_print);
            this.groupBox3.Controls.Add(this.btn_update);
            this.groupBox3.Controls.Add(this.btn_search);
            this.groupBox3.Controls.Add(this.btn_add);
            this.groupBox3.Controls.Add(this.btn_exit);
            this.groupBox3.Location = new System.Drawing.Point(28, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1265, 93);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_edit.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Appearance.Options.UseFont = true;
            this.btn_edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.ImageOptions.Image")));
            this.btn_edit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_edit.Location = new System.Drawing.Point(996, 23);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(125, 47);
            this.btn_edit.TabIndex = 24;
            this.btn_edit.Text = "تعديل";
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_delete.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.Image")));
            this.btn_delete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_delete.Location = new System.Drawing.Point(865, 23);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(125, 47);
            this.btn_delete.TabIndex = 23;
            this.btn_delete.Text = "حذف";
            // 
            // btn_print
            // 
            this.btn_print.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_print.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Appearance.Options.UseFont = true;
            this.btn_print.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_print.ImageOptions.Image")));
            this.btn_print.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_print.Location = new System.Drawing.Point(472, 23);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(125, 47);
            this.btn_print.TabIndex = 22;
            this.btn_print.Text = "طباعة";
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_update.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Appearance.Options.UseFont = true;
            this.btn_update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.ImageOptions.Image")));
            this.btn_update.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_update.Location = new System.Drawing.Point(734, 23);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(125, 47);
            this.btn_update.TabIndex = 21;
            this.btn_update.Text = "تحديث";
            // 
            // btn_search
            // 
            this.btn_search.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_search.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Appearance.Options.UseFont = true;
            this.btn_search.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_search.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_search.ImageOptions.SvgImage")));
            this.btn_search.Location = new System.Drawing.Point(603, 23);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(125, 47);
            this.btn_search.TabIndex = 20;
            this.btn_search.Text = "بحث";
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_add.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_add.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_add.ImageOptions.SvgImage")));
            this.btn_add.Location = new System.Drawing.Point(1127, 23);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(128, 47);
            this.btn_add.TabIndex = 19;
            this.btn_add.Text = "اضافة";
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_exit.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Appearance.Options.UseFont = true;
            this.btn_exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.ImageOptions.Image")));
            this.btn_exit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_exit.Location = new System.Drawing.Point(17, 23);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(125, 47);
            this.btn_exit.TabIndex = 18;
            this.btn_exit.Text = "خروج";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.picture_Search);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_Search);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Tempus Sans ITC", 8F);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1325, 63);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1226, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "التاريخ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1031, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 25);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(544, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "دليل أسعار العملات";
            // 
            // tb_CurrenciesPricesTableAdapter
            // 
            this.tb_CurrenciesPricesTableAdapter.ClearBeforeFill = true;
            // 
            // picture_Search
            // 
            this.picture_Search.Location = new System.Drawing.Point(8, 14);
            this.picture_Search.Name = "picture_Search";
            this.picture_Search.Size = new System.Drawing.Size(30, 28);
            this.picture_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_Search.TabIndex = 70;
            this.picture_Search.TabStop = false;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(44, 11);
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Search.Size = new System.Drawing.Size(171, 34);
            this.txt_Search.TabIndex = 69;
            this.txt_Search.Tag = "";
            this.txt_Search.TextChanged += new System.EventHandler(this.Txt_Search_TextChanged);
            // 
            // CurrencyPricesGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 777);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CurrencyPricesGuide";
            this.Text = "/*";
            this.Load += new System.EventHandler(this.CurrencyPricesGuide_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCurrenciesPricesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTAEMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        public DevExpress.XtraEditors.SimpleButton btn_edit;
        public DevExpress.XtraEditors.SimpleButton btn_delete;
        public DevExpress.XtraEditors.SimpleButton btn_print;
        public DevExpress.XtraEditors.SimpleButton btn_update;
        public DevExpress.XtraEditors.SimpleButton btn_search;
        public DevExpress.XtraEditors.SimpleButton btn_add;
        public DevExpress.XtraEditors.SimpleButton btn_exit;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DBTAEMDataSet dBTAEMDataSet;
        private System.Windows.Forms.BindingSource tbCurrenciesPricesBindingSource;
        private DBTAEMDataSetTableAdapters.Tb_CurrenciesPricesTableAdapter tb_CurrenciesPricesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colTtranferFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colTtranferTo;
        private DevExpress.XtraGrid.Columns.GridColumn colTtranferPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colSellingPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colLowPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colHeghtPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colLowPricePay;
        private DevExpress.XtraGrid.Columns.GridColumn colLowPriceSelling;
        private DevExpress.XtraGrid.Columns.GridColumn colHeghtPricePay;
        private DevExpress.XtraGrid.Columns.GridColumn colHeghtPriceSelling;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        internal System.Windows.Forms.PictureBox picture_Search;
        private System.Windows.Forms.TextBox txt_Search;
    }
}