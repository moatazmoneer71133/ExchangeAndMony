﻿namespace ExchangeAndMony.pages.accountsInterface.accountsInitializatuionInterface
{
    partial class RoofingAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoofingAccounts));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tbRoofingAccountsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBTAEMDataSet2 = new ExchangeAndMony.DBTAEMDataSet2();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAccountNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserNumbers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInsertDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
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
            this.tbRoofingAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_RoofingAccountsTableAdapter = new ExchangeAndMony.DBTAEMDataSet2TableAdapters.Tb_RoofingAccountsTableAdapter();
            this.tbGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_GroupsTableAdapter = new ExchangeAndMony.DBTAEMDataSet2TableAdapters.Tb_GroupsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRoofingAccountsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTAEMDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRoofingAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGroupsBindingSource)).BeginInit();
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
            this.gridControl1.DataSource = this.tbGroupsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 376);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1308, 395);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tbRoofingAccountsBindingSource1
            // 
            this.tbRoofingAccountsBindingSource1.DataMember = "Tb_RoofingAccounts";
            this.tbRoofingAccountsBindingSource1.DataSource = this.dBTAEMDataSet2;
            // 
            // dBTAEMDataSet2
            // 
            this.dBTAEMDataSet2.DataSetName = "DBTAEMDataSet2";
            this.dBTAEMDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAccountNumber,
            this.colAccountName,
            this.colUserNumbers,
            this.colUserName,
            this.colAmount,
            this.colInsertDate,
            this.colLastEdit,
            this.colNote});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colAccountNumber
            // 
            this.colAccountNumber.FieldName = "AccountNumber";
            this.colAccountNumber.MinWidth = 25;
            this.colAccountNumber.Name = "colAccountNumber";
            this.colAccountNumber.Visible = true;
            this.colAccountNumber.VisibleIndex = 0;
            this.colAccountNumber.Width = 94;
            // 
            // colAccountName
            // 
            this.colAccountName.FieldName = "AccountName";
            this.colAccountName.MinWidth = 25;
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.Visible = true;
            this.colAccountName.VisibleIndex = 1;
            this.colAccountName.Width = 94;
            // 
            // colUserNumbers
            // 
            this.colUserNumbers.FieldName = "UserNumbers";
            this.colUserNumbers.MinWidth = 25;
            this.colUserNumbers.Name = "colUserNumbers";
            this.colUserNumbers.Visible = true;
            this.colUserNumbers.VisibleIndex = 2;
            this.colUserNumbers.Width = 94;
            // 
            // colUserName
            // 
            this.colUserName.FieldName = "UserName";
            this.colUserName.MinWidth = 25;
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 3;
            this.colUserName.Width = 94;
            // 
            // colAmount
            // 
            this.colAmount.FieldName = "Amount";
            this.colAmount.MinWidth = 25;
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 4;
            this.colAmount.Width = 94;
            // 
            // colInsertDate
            // 
            this.colInsertDate.FieldName = "InsertDate";
            this.colInsertDate.MinWidth = 25;
            this.colInsertDate.Name = "colInsertDate";
            this.colInsertDate.Visible = true;
            this.colInsertDate.VisibleIndex = 5;
            this.colInsertDate.Width = 94;
            // 
            // colLastEdit
            // 
            this.colLastEdit.FieldName = "LastEdit";
            this.colLastEdit.MinWidth = 25;
            this.colLastEdit.Name = "colLastEdit";
            this.colLastEdit.Visible = true;
            this.colLastEdit.VisibleIndex = 6;
            this.colLastEdit.Width = 94;
            // 
            // colNote
            // 
            this.colNote.FieldName = "Note";
            this.colNote.MinWidth = 25;
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 7;
            this.colNote.Width = 94;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(14, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1265, 179);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(839, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(256, 24);
            this.comboBox1.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(669, 119);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(426, 30);
            this.textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(909, 77);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 30);
            this.textBox2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1113, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "ملاحظات";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1113, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "المبلغ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1111, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 26);
            this.label11.TabIndex = 16;
            this.label11.Text = "اسم الحساب";
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
            this.groupBox3.Location = new System.Drawing.Point(14, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1265, 93);
            this.groupBox3.TabIndex = 8;
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
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Tempus Sans ITC", 8F);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1300, 63);
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
            this.label2.Size = new System.Drawing.Size(217, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "تسقيف الحسابات";
            // 
            // tbRoofingAccountsBindingSource
            // 
            this.tbRoofingAccountsBindingSource.DataMember = "Tb_RoofingAccounts";
            this.tbRoofingAccountsBindingSource.DataSource = this.dBTAEMDataSet2;
            // 
            // tb_RoofingAccountsTableAdapter
            // 
            this.tb_RoofingAccountsTableAdapter.ClearBeforeFill = true;
            // 
            // tbGroupsBindingSource
            // 
            this.tbGroupsBindingSource.DataMember = "Tb_Groups";
            this.tbGroupsBindingSource.DataSource = this.dBTAEMDataSet2;
            // 
            // tb_GroupsTableAdapter
            // 
            this.tb_GroupsTableAdapter.ClearBeforeFill = true;
            // 
            // RoofingAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 777);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoofingAccounts";
            this.Text = "/*";
            this.Load += new System.EventHandler(this.RoofingAccounts_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRoofingAccountsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTAEMDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRoofingAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGroupsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        public DevExpress.XtraEditors.SimpleButton btn_edit;
        public DevExpress.XtraEditors.SimpleButton btn_delete;
        public DevExpress.XtraEditors.SimpleButton btn_print;
        public DevExpress.XtraEditors.SimpleButton btn_update;
        public DevExpress.XtraEditors.SimpleButton btn_search;
        public DevExpress.XtraEditors.SimpleButton btn_add;
        public DevExpress.XtraEditors.SimpleButton btn_exit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private DBTAEMDataSet2 dBTAEMDataSet2;
        private System.Windows.Forms.BindingSource tbRoofingAccountsBindingSource;
        private DBTAEMDataSet2TableAdapters.Tb_RoofingAccountsTableAdapter tb_RoofingAccountsTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource tbRoofingAccountsBindingSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountName;
        private DevExpress.XtraGrid.Columns.GridColumn colUserNumbers;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colInsertDate;
        private DevExpress.XtraGrid.Columns.GridColumn colLastEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private System.Windows.Forms.BindingSource tbGroupsBindingSource;
        private DBTAEMDataSet2TableAdapters.Tb_GroupsTableAdapter tb_GroupsTableAdapter;
    }
}