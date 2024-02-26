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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBTAEMDataSet2 = new ExchangeAndMony.DBTAEMDataSet2();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTtranferFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTtranferTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTtranferPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchasePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellingPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLowPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHighestPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLowPricePurchasing = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLowPriceSelling = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHighestPricePurchasing = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHighestPriceSelling = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.currencie_com2 = new ExchangeAndMony.pages.currencie_com();
            this.currencie_com1 = new ExchangeAndMony.pages.currencie_com();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_HighestPriceSelling = new System.Windows.Forms.TextBox();
            this.txt_HighestPricePurchasing = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_LowPriceSelling = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_LowPricePurchasing = new System.Windows.Forms.TextBox();
            this.txt_SellingPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_PurchasePrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_HighestPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_LowPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TtranferPrice = new System.Windows.Forms.TextBox();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_print = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_exit = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PictureBoxMessage = new System.Windows.Forms.PictureBox();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.picture_Search = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.timer_message_seccess = new System.Windows.Forms.Timer(this.components);
            this.tb_CurrenciesPricesTableAdapter = new ExchangeAndMony.DBTAEMDataSet2TableAdapters.Tb_CurrenciesPricesTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTAEMDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMessage)).BeginInit();
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
            this.gridControl1.DataSource = this.bindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 437);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(1308, 334);
            this.gridControl1.TabIndex = 12;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Tb_CurrenciesPrices";
            this.bindingSource1.DataSource = this.dBTAEMDataSet2;
            // 
            // dBTAEMDataSet2
            // 
            this.dBTAEMDataSet2.DataSetName = "DBTAEMDataSet2";
            this.dBTAEMDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor2 = System.Drawing.SystemColors.ScrollBar;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTtranferFrom,
            this.colTtranferTo,
            this.colTtranferPrice,
            this.colPurchasePrice,
            this.colSellingPrice,
            this.colLowPrice,
            this.colHighestPrice,
            this.colLowPricePurchasing,
            this.colLowPriceSelling,
            this.colHighestPricePurchasing,
            this.colHighestPriceSelling,
            this.colNote});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupRowHeight = 40;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.LevelIndent = 0;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "0";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsPrint.AutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.PreviewIndent = 0;
            this.gridView1.PreviewLineCount = 10;
            this.gridView1.RowHeight = 30;
            this.gridView1.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None;
            this.gridView1.SynchronizeClones = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridView1_RowClick);
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.GridView1_RowCellClick);
            this.gridView1.Click += new System.EventHandler(this.GridView1_Click);
            // 
            // colTtranferFrom
            // 
            this.colTtranferFrom.Caption = "التحويل من";
            this.colTtranferFrom.FieldName = "TtranferFrom";
            this.colTtranferFrom.MinWidth = 25;
            this.colTtranferFrom.Name = "colTtranferFrom";
            this.colTtranferFrom.OptionsColumn.ReadOnly = true;
            this.colTtranferFrom.Visible = true;
            this.colTtranferFrom.VisibleIndex = 0;
            this.colTtranferFrom.Width = 94;
            // 
            // colTtranferTo
            // 
            this.colTtranferTo.Caption = "التحويل الي";
            this.colTtranferTo.FieldName = "TtranferTo";
            this.colTtranferTo.MinWidth = 25;
            this.colTtranferTo.Name = "colTtranferTo";
            this.colTtranferTo.OptionsColumn.ReadOnly = true;
            this.colTtranferTo.Visible = true;
            this.colTtranferTo.VisibleIndex = 1;
            this.colTtranferTo.Width = 94;
            // 
            // colTtranferPrice
            // 
            this.colTtranferPrice.Caption = "سعر التحويل";
            this.colTtranferPrice.FieldName = "TtranferPrice";
            this.colTtranferPrice.MinWidth = 25;
            this.colTtranferPrice.Name = "colTtranferPrice";
            this.colTtranferPrice.OptionsColumn.ReadOnly = true;
            this.colTtranferPrice.Visible = true;
            this.colTtranferPrice.VisibleIndex = 2;
            this.colTtranferPrice.Width = 94;
            // 
            // colPurchasePrice
            // 
            this.colPurchasePrice.Caption = "سعر الشراء";
            this.colPurchasePrice.FieldName = "PurchasePrice";
            this.colPurchasePrice.MinWidth = 25;
            this.colPurchasePrice.Name = "colPurchasePrice";
            this.colPurchasePrice.OptionsColumn.ReadOnly = true;
            this.colPurchasePrice.Visible = true;
            this.colPurchasePrice.VisibleIndex = 3;
            this.colPurchasePrice.Width = 94;
            // 
            // colSellingPrice
            // 
            this.colSellingPrice.Caption = " سعر البيع";
            this.colSellingPrice.FieldName = "SellingPrice";
            this.colSellingPrice.MinWidth = 25;
            this.colSellingPrice.Name = "colSellingPrice";
            this.colSellingPrice.OptionsColumn.ReadOnly = true;
            this.colSellingPrice.Visible = true;
            this.colSellingPrice.VisibleIndex = 4;
            this.colSellingPrice.Width = 94;
            // 
            // colLowPrice
            // 
            this.colLowPrice.Caption = "أدنى سعر";
            this.colLowPrice.FieldName = "LowPrice";
            this.colLowPrice.MinWidth = 25;
            this.colLowPrice.Name = "colLowPrice";
            this.colLowPrice.OptionsColumn.ReadOnly = true;
            this.colLowPrice.Visible = true;
            this.colLowPrice.VisibleIndex = 5;
            this.colLowPrice.Width = 94;
            // 
            // colHighestPrice
            // 
            this.colHighestPrice.Caption = "أعلى سعر";
            this.colHighestPrice.FieldName = "HighestPrice";
            this.colHighestPrice.MinWidth = 25;
            this.colHighestPrice.Name = "colHighestPrice";
            this.colHighestPrice.OptionsColumn.ReadOnly = true;
            this.colHighestPrice.Visible = true;
            this.colHighestPrice.VisibleIndex = 6;
            this.colHighestPrice.Width = 94;
            // 
            // colLowPricePurchasing
            // 
            this.colLowPricePurchasing.Caption = "أدنى سعر للشراء";
            this.colLowPricePurchasing.FieldName = "LowPricePurchasing";
            this.colLowPricePurchasing.MinWidth = 25;
            this.colLowPricePurchasing.Name = "colLowPricePurchasing";
            this.colLowPricePurchasing.OptionsColumn.ReadOnly = true;
            this.colLowPricePurchasing.Visible = true;
            this.colLowPricePurchasing.VisibleIndex = 7;
            this.colLowPricePurchasing.Width = 94;
            // 
            // colLowPriceSelling
            // 
            this.colLowPriceSelling.Caption = "أدنى سعر للبيع";
            this.colLowPriceSelling.FieldName = "LowPriceSelling";
            this.colLowPriceSelling.MinWidth = 25;
            this.colLowPriceSelling.Name = "colLowPriceSelling";
            this.colLowPriceSelling.OptionsColumn.ReadOnly = true;
            this.colLowPriceSelling.Visible = true;
            this.colLowPriceSelling.VisibleIndex = 8;
            this.colLowPriceSelling.Width = 94;
            // 
            // colHighestPricePurchasing
            // 
            this.colHighestPricePurchasing.Caption = "أعلى سعر للشراء";
            this.colHighestPricePurchasing.FieldName = "HighestPricePurchasing";
            this.colHighestPricePurchasing.MinWidth = 25;
            this.colHighestPricePurchasing.Name = "colHighestPricePurchasing";
            this.colHighestPricePurchasing.OptionsColumn.ReadOnly = true;
            this.colHighestPricePurchasing.Visible = true;
            this.colHighestPricePurchasing.VisibleIndex = 9;
            this.colHighestPricePurchasing.Width = 94;
            // 
            // colHighestPriceSelling
            // 
            this.colHighestPriceSelling.Caption = "أعلى سعر للبيع";
            this.colHighestPriceSelling.FieldName = "HighestPriceSelling";
            this.colHighestPriceSelling.MinWidth = 25;
            this.colHighestPriceSelling.Name = "colHighestPriceSelling";
            this.colHighestPriceSelling.OptionsColumn.ReadOnly = true;
            this.colHighestPriceSelling.Visible = true;
            this.colHighestPriceSelling.VisibleIndex = 10;
            this.colHighestPriceSelling.Width = 94;
            // 
            // colNote
            // 
            this.colNote.Caption = "ملاحظة";
            this.colNote.FieldName = "Note";
            this.colNote.MinWidth = 25;
            this.colNote.Name = "colNote";
            this.colNote.OptionsColumn.ReadOnly = true;
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 11;
            this.colNote.Width = 94;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.currencie_com2);
            this.groupBox1.Controls.Add(this.currencie_com1);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_HighestPriceSelling);
            this.groupBox1.Controls.Add(this.txt_HighestPricePurchasing);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_LowPriceSelling);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_LowPricePurchasing);
            this.groupBox1.Controls.Add(this.txt_SellingPrice);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_PurchasePrice);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_HighestPrice);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_LowPrice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_TtranferPrice);
            this.groupBox1.Controls.Add(this.txt_Note);
            this.groupBox1.Location = new System.Drawing.Point(28, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1265, 260);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // currencie_com2
            // 
            this.currencie_com2.Location = new System.Drawing.Point(696, 33);
            this.currencie_com2.Name = "currencie_com2";
            this.currencie_com2.Size = new System.Drawing.Size(159, 25);
            this.currencie_com2.TabIndex = 2;
            // 
            // currencie_com1
            // 
            this.currencie_com1.Location = new System.Drawing.Point(996, 33);
            this.currencie_com1.Name = "currencie_com1";
            this.currencie_com1.Size = new System.Drawing.Size(159, 25);
            this.currencie_com1.TabIndex = 1;
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
            // txt_HighestPriceSelling
            // 
            this.txt_HighestPriceSelling.Location = new System.Drawing.Point(387, 156);
            this.txt_HighestPriceSelling.Multiline = true;
            this.txt_HighestPriceSelling.Name = "txt_HighestPriceSelling";
            this.txt_HighestPriceSelling.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_HighestPriceSelling.Size = new System.Drawing.Size(159, 26);
            this.txt_HighestPriceSelling.TabIndex = 11;
            this.txt_HighestPriceSelling.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_HighestPriceSelling_KeyPress);
            // 
            // txt_HighestPricePurchasing
            // 
            this.txt_HighestPricePurchasing.Location = new System.Drawing.Point(387, 116);
            this.txt_HighestPricePurchasing.Multiline = true;
            this.txt_HighestPricePurchasing.Name = "txt_HighestPricePurchasing";
            this.txt_HighestPricePurchasing.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_HighestPricePurchasing.Size = new System.Drawing.Size(159, 26);
            this.txt_HighestPricePurchasing.TabIndex = 8;
            this.txt_HighestPricePurchasing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_HighestPricePurchasing_KeyPress);
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
            // txt_LowPriceSelling
            // 
            this.txt_LowPriceSelling.Location = new System.Drawing.Point(696, 156);
            this.txt_LowPriceSelling.Multiline = true;
            this.txt_LowPriceSelling.Name = "txt_LowPriceSelling";
            this.txt_LowPriceSelling.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_LowPriceSelling.Size = new System.Drawing.Size(159, 26);
            this.txt_LowPriceSelling.TabIndex = 10;
            this.txt_LowPriceSelling.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_LowPriceSelling_KeyPress);
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
            // txt_LowPricePurchasing
            // 
            this.txt_LowPricePurchasing.Location = new System.Drawing.Point(696, 118);
            this.txt_LowPricePurchasing.Multiline = true;
            this.txt_LowPricePurchasing.Name = "txt_LowPricePurchasing";
            this.txt_LowPricePurchasing.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_LowPricePurchasing.Size = new System.Drawing.Size(159, 26);
            this.txt_LowPricePurchasing.TabIndex = 7;
            this.txt_LowPricePurchasing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_LowPricePurchasing_KeyPress);
            // 
            // txt_SellingPrice
            // 
            this.txt_SellingPrice.Location = new System.Drawing.Point(996, 156);
            this.txt_SellingPrice.Multiline = true;
            this.txt_SellingPrice.Name = "txt_SellingPrice";
            this.txt_SellingPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_SellingPrice.Size = new System.Drawing.Size(159, 26);
            this.txt_SellingPrice.TabIndex = 9;
            this.txt_SellingPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_SellingPrice_KeyPress);
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
            // txt_PurchasePrice
            // 
            this.txt_PurchasePrice.Location = new System.Drawing.Point(996, 116);
            this.txt_PurchasePrice.Multiline = true;
            this.txt_PurchasePrice.Name = "txt_PurchasePrice";
            this.txt_PurchasePrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_PurchasePrice.Size = new System.Drawing.Size(159, 26);
            this.txt_PurchasePrice.TabIndex = 6;
            this.txt_PurchasePrice.TextChanged += new System.EventHandler(this.Txt_PurchasePrice_TextChanged);
            this.txt_PurchasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_PurchasePrice_KeyPress);
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
            // txt_HighestPrice
            // 
            this.txt_HighestPrice.Location = new System.Drawing.Point(387, 73);
            this.txt_HighestPrice.Multiline = true;
            this.txt_HighestPrice.Name = "txt_HighestPrice";
            this.txt_HighestPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_HighestPrice.Size = new System.Drawing.Size(159, 26);
            this.txt_HighestPrice.TabIndex = 5;
            this.txt_HighestPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_HighestPrice_KeyPress);
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
            // txt_LowPrice
            // 
            this.txt_LowPrice.Location = new System.Drawing.Point(696, 75);
            this.txt_LowPrice.Multiline = true;
            this.txt_LowPrice.Name = "txt_LowPrice";
            this.txt_LowPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_LowPrice.Size = new System.Drawing.Size(159, 26);
            this.txt_LowPrice.TabIndex = 4;
            this.txt_LowPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_LowPrice_KeyPress);
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
            // txt_TtranferPrice
            // 
            this.txt_TtranferPrice.Location = new System.Drawing.Point(996, 73);
            this.txt_TtranferPrice.Multiline = true;
            this.txt_TtranferPrice.Name = "txt_TtranferPrice";
            this.txt_TtranferPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_TtranferPrice.Size = new System.Drawing.Size(159, 26);
            this.txt_TtranferPrice.TabIndex = 3;
            this.txt_TtranferPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_TtranferPrice_KeyPress);
            // 
            // txt_Note
            // 
            this.txt_Note.Location = new System.Drawing.Point(387, 210);
            this.txt_Note.Multiline = true;
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Note.Size = new System.Drawing.Size(768, 25);
            this.txt_Note.TabIndex = 12;
            this.txt_Note.Enter += new System.EventHandler(this.Txt_Note_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_edit);
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.btn_print);
            this.groupBox3.Controls.Add(this.btn_update);
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
            this.btn_edit.Click += new System.EventHandler(this.Btn_edit_Click);
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
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // btn_print
            // 
            this.btn_print.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_print.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Appearance.Options.UseFont = true;
            this.btn_print.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_print.ImageOptions.Image")));
            this.btn_print.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_print.Location = new System.Drawing.Point(601, 23);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(125, 47);
            this.btn_print.TabIndex = 22;
            this.btn_print.Text = "طباعة";
            this.btn_print.Click += new System.EventHandler(this.Btn_print_Click);
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
            this.btn_update.Click += new System.EventHandler(this.Btn_update_Click);
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
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click_1);
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
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.PictureBoxMessage);
            this.panel2.Controls.Add(this.lbl_Message);
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
            // PictureBoxMessage
            // 
            this.PictureBoxMessage.Location = new System.Drawing.Point(460, 10);
            this.PictureBoxMessage.Name = "PictureBoxMessage";
            this.PictureBoxMessage.Size = new System.Drawing.Size(30, 28);
            this.PictureBoxMessage.TabIndex = 72;
            this.PictureBoxMessage.TabStop = false;
            // 
            // lbl_Message
            // 
            this.lbl_Message.Font = new System.Drawing.Font("Tempus Sans ITC", 14F);
            this.lbl_Message.Location = new System.Drawing.Point(316, 6);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(158, 39);
            this.lbl_Message.TabIndex = 71;
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
            this.txt_Search.Enter += new System.EventHandler(this.Txt_Search_Enter);
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
            // timer_message_seccess
            // 
            this.timer_message_seccess.Interval = 1000;
            this.timer_message_seccess.Tick += new System.EventHandler(this.Timer_message_seccess_Tick);
            // 
            // tb_CurrenciesPricesTableAdapter
            // 
            this.tb_CurrenciesPricesTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTAEMDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMessage)).EndInit();
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        public DevExpress.XtraEditors.SimpleButton btn_edit;
        public DevExpress.XtraEditors.SimpleButton btn_delete;
        public DevExpress.XtraEditors.SimpleButton btn_print;
        public DevExpress.XtraEditors.SimpleButton btn_update;
        public DevExpress.XtraEditors.SimpleButton btn_add;
        public DevExpress.XtraEditors.SimpleButton btn_exit;
        private System.Windows.Forms.BindingSource tbCurrenciesPricesBindingSource;
        internal System.Windows.Forms.PictureBox picture_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DBTAEMDataSet2 dBTAEMDataSet2;
        private DevExpress.XtraGrid.Columns.GridColumn colTtranferFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colTtranferTo;
        private DevExpress.XtraGrid.Columns.GridColumn colTtranferPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchasePrice;
        private DevExpress.XtraGrid.Columns.GridColumn colSellingPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colLowPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colHighestPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colLowPricePurchasing;
        private DevExpress.XtraGrid.Columns.GridColumn colLowPriceSelling;
        private DevExpress.XtraGrid.Columns.GridColumn colHighestPricePurchasing;
        private DevExpress.XtraGrid.Columns.GridColumn colHighestPriceSelling;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DBTAEMDataSet1 dBTAEMDataSet1;
        private DBTAEMDataSet1TableAdapters.Tb_CurrenciesPricesTableAdapter tb_CurrenciesPricesTableAdapter2;
        internal System.Windows.Forms.Timer timer_message_seccess;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DBTAEMDataSet2TableAdapters.Tb_CurrenciesPricesTableAdapter tb_CurrenciesPricesTableAdapter;
        internal System.Windows.Forms.TextBox txt_HighestPriceSelling;
        internal System.Windows.Forms.TextBox txt_HighestPricePurchasing;
        internal System.Windows.Forms.TextBox txt_LowPriceSelling;
        internal System.Windows.Forms.TextBox txt_LowPricePurchasing;
        internal System.Windows.Forms.TextBox txt_SellingPrice;
        internal System.Windows.Forms.TextBox txt_PurchasePrice;
        internal System.Windows.Forms.TextBox txt_HighestPrice;
        internal System.Windows.Forms.TextBox txt_LowPrice;
        internal System.Windows.Forms.TextBox txt_TtranferPrice;
        internal System.Windows.Forms.TextBox txt_Note;
        internal currencie_com currencie_com1;
        internal currencie_com currencie_com2;
        internal System.Windows.Forms.PictureBox PictureBoxMessage;
        internal System.Windows.Forms.Label lbl_Message;
        internal DevExpress.XtraGrid.GridControl gridControl1;
    }
}