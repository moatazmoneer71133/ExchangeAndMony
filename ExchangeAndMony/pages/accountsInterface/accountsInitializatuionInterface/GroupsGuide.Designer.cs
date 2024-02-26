namespace ExchangeAndMony.pages.accountsInterface.accountsInitializatuionInterface
{
    partial class GroupsGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupsGuide));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_groups = new DevExpress.XtraGrid.GridControl();
            this.tbGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGroupNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTheDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_groupNumber = new System.Windows.Forms.TextBox();
            this.txt_groupName = new System.Windows.Forms.TextBox();
            this.txt_groupDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_print = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_exit = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picture_Search = new System.Windows.Forms.PictureBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.PictureBoxMessage = new System.Windows.Forms.PictureBox();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGroupsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBTAEMDataSet2 = new ExchangeAndMony.DBTAEMDataSet2();
            this.timer_message_seccess = new System.Windows.Forms.Timer(this.components);
            this.tb_GroupsTableAdapter1 = new ExchangeAndMony.DBTAEMDataSet2TableAdapters.Tb_GroupsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_groups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGroupsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTAEMDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_groups);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(6, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1308, 771);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView_groups
            // 
            this.dataGridView_groups.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dataGridView_groups.DataSource = this.tbGroupsBindingSource1;
            this.dataGridView_groups.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_groups.Location = new System.Drawing.Point(0, 357);
            this.dataGridView_groups.MainView = this.gridView1;
            this.dataGridView_groups.Name = "dataGridView_groups";
            this.dataGridView_groups.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView_groups.Size = new System.Drawing.Size(1308, 414);
            this.dataGridView_groups.TabIndex = 10;
            this.dataGridView_groups.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tbGroupsBindingSource
            // 
            this.tbGroupsBindingSource.DataMember = "Tb_Groups";
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGroupNumber,
            this.colGroupName,
            this.colUserName,
            this.colTheDate,
            this.colNote});
            this.gridView1.GridControl = this.dataGridView_groups;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colGroupNumber
            // 
            this.colGroupNumber.Caption = "رقم المجموعة";
            this.colGroupNumber.FieldName = "GroupNumber";
            this.colGroupNumber.MinWidth = 25;
            this.colGroupNumber.Name = "colGroupNumber";
            this.colGroupNumber.OptionsColumn.ReadOnly = true;
            this.colGroupNumber.Visible = true;
            this.colGroupNumber.VisibleIndex = 0;
            this.colGroupNumber.Width = 94;
            // 
            // colGroupName
            // 
            this.colGroupName.Caption = "اسم المجموعة";
            this.colGroupName.FieldName = "GroupName";
            this.colGroupName.MinWidth = 25;
            this.colGroupName.Name = "colGroupName";
            this.colGroupName.OptionsColumn.ReadOnly = true;
            this.colGroupName.Visible = true;
            this.colGroupName.VisibleIndex = 1;
            this.colGroupName.Width = 94;
            // 
            // colUserName
            // 
            this.colUserName.Caption = "اسم المستخدم";
            this.colUserName.FieldName = "UserName";
            this.colUserName.MinWidth = 25;
            this.colUserName.Name = "colUserName";
            this.colUserName.OptionsColumn.ReadOnly = true;
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 2;
            this.colUserName.Width = 94;
            // 
            // colTheDate
            // 
            this.colTheDate.Caption = "التاريخ";
            this.colTheDate.FieldName = "TheDate";
            this.colTheDate.MinWidth = 25;
            this.colTheDate.Name = "colTheDate";
            this.colTheDate.OptionsColumn.ReadOnly = true;
            this.colTheDate.Visible = true;
            this.colTheDate.VisibleIndex = 3;
            this.colTheDate.Width = 94;
            // 
            // colNote
            // 
            this.colNote.Caption = "الملاحظة";
            this.colNote.FieldName = "Note";
            this.colNote.MinWidth = 25;
            this.colNote.Name = "colNote";
            this.colNote.OptionsColumn.ReadOnly = true;
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 4;
            this.colNote.Width = 94;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_groupNumber);
            this.groupBox1.Controls.Add(this.txt_groupName);
            this.groupBox1.Controls.Add(this.txt_groupDescription);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(14, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1265, 152);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // txt_groupNumber
            // 
            this.txt_groupNumber.Location = new System.Drawing.Point(6, 23);
            this.txt_groupNumber.Name = "txt_groupNumber";
            this.txt_groupNumber.Size = new System.Drawing.Size(100, 24);
            this.txt_groupNumber.TabIndex = 19;
            this.txt_groupNumber.Visible = false;
            // 
            // txt_groupName
            // 
            this.txt_groupName.Location = new System.Drawing.Point(805, 34);
            this.txt_groupName.Multiline = true;
            this.txt_groupName.Name = "txt_groupName";
            this.txt_groupName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_groupName.Size = new System.Drawing.Size(288, 30);
            this.txt_groupName.TabIndex = 17;
            this.txt_groupName.TextChanged += new System.EventHandler(this.Txt_groupName_TextChanged);
            this.txt_groupName.Enter += new System.EventHandler(this.Txt_groupName_Enter);
            // 
            // txt_groupDescription
            // 
            this.txt_groupDescription.Location = new System.Drawing.Point(669, 86);
            this.txt_groupDescription.Multiline = true;
            this.txt_groupDescription.Name = "txt_groupDescription";
            this.txt_groupDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_groupDescription.Size = new System.Drawing.Size(426, 30);
            this.txt_groupDescription.TabIndex = 18;
            this.txt_groupDescription.Enter += new System.EventHandler(this.Txt_groupDescription_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1113, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "الوصف";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1113, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 26);
            this.label11.TabIndex = 16;
            this.label11.Text = "اسم المجموعة";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_edit);
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.btn_print);
            this.groupBox3.Controls.Add(this.btn_update);
            this.groupBox3.Controls.Add(this.btn_add);
            this.groupBox3.Controls.Add(this.btn_exit);
            this.groupBox3.Location = new System.Drawing.Point(14, 258);
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
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
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
            this.panel2.Controls.Add(this.picture_Search);
            this.panel2.Controls.Add(this.txt_Search);
            this.panel2.Controls.Add(this.PictureBoxMessage);
            this.panel2.Controls.Add(this.lbl_Message);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Tempus Sans ITC", 8F);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1300, 63);
            this.panel2.TabIndex = 1;
            // 
            // picture_Search
            // 
            this.picture_Search.Location = new System.Drawing.Point(11, 18);
            this.picture_Search.Name = "picture_Search";
            this.picture_Search.Size = new System.Drawing.Size(30, 28);
            this.picture_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_Search.TabIndex = 68;
            this.picture_Search.TabStop = false;
            this.picture_Search.Click += new System.EventHandler(this.Picture_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Tempus Sans ITC", 10F);
            this.txt_Search.Location = new System.Drawing.Point(47, 15);
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Search.Size = new System.Drawing.Size(171, 34);
            this.txt_Search.TabIndex = 67;
            this.txt_Search.Tag = "";
            this.txt_Search.TextChanged += new System.EventHandler(this.Txt_Search_TextChanged);
            // 
            // PictureBoxMessage
            // 
            this.PictureBoxMessage.Location = new System.Drawing.Point(419, 17);
            this.PictureBoxMessage.Name = "PictureBoxMessage";
            this.PictureBoxMessage.Size = new System.Drawing.Size(30, 28);
            this.PictureBoxMessage.TabIndex = 66;
            this.PictureBoxMessage.TabStop = false;
            // 
            // lbl_Message
            // 
            this.lbl_Message.Font = new System.Drawing.Font("Tempus Sans ITC", 14F);
            this.lbl_Message.Location = new System.Drawing.Point(275, 13);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(158, 39);
            this.lbl_Message.TabIndex = 65;
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
            this.label2.Size = new System.Drawing.Size(210, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "دليل المجموعات";
            // 
            // tbGroupsBindingSource1
            // 
            this.tbGroupsBindingSource1.DataMember = "Tb_Groups";
            this.tbGroupsBindingSource1.DataSource = this.dBTAEMDataSet2;
            // 
            // dBTAEMDataSet2
            // 
            this.dBTAEMDataSet2.DataSetName = "DBTAEMDataSet2";
            this.dBTAEMDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timer_message_seccess
            // 
            this.timer_message_seccess.Interval = 1000;
            this.timer_message_seccess.Tick += new System.EventHandler(this.Timer_message_seccess_Tick);
            // 
            // tb_GroupsTableAdapter1
            // 
            this.tb_GroupsTableAdapter1.ClearBeforeFill = true;
            // 
            // GroupsGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 777);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GroupsGuide";
            this.Text = "/*";
            this.Load += new System.EventHandler(this.GroupsGuide_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_groups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGroupsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTAEMDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DBTAEMDataSet1 dBTAEMDataSet1;
        private DBTAEMDataSet1TableAdapters.Tb_GroupsTableAdapter tb_GroupsTableAdapter;
        internal System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.DateTimePicker dateTimePicker1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.TextBox txt_Search;
        internal DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        internal System.Windows.Forms.BindingSource tbGroupsBindingSource;
        internal DevExpress.XtraGrid.Columns.GridColumn colGroupNumber;
        internal DevExpress.XtraGrid.Columns.GridColumn colGroupName;
        internal DevExpress.XtraGrid.Columns.GridColumn colUserName;
        internal DevExpress.XtraGrid.Columns.GridColumn colTheDate;
        internal DevExpress.XtraGrid.Columns.GridColumn colNote;
        internal DBTAEMDataSet2 dBTAEMDataSet2;
        internal System.Windows.Forms.BindingSource tbGroupsBindingSource1;
        internal DBTAEMDataSet2TableAdapters.Tb_GroupsTableAdapter tb_GroupsTableAdapter1;
        internal DevExpress.XtraEditors.SimpleButton btn_edit;
        internal DevExpress.XtraEditors.SimpleButton btn_delete;
        internal DevExpress.XtraEditors.SimpleButton btn_print;
        internal DevExpress.XtraEditors.SimpleButton btn_update;
        internal DevExpress.XtraEditors.SimpleButton btn_add;
        internal DevExpress.XtraEditors.SimpleButton btn_exit;
        internal System.Windows.Forms.PictureBox PictureBoxMessage;
        internal System.Windows.Forms.Label lbl_Message;
        internal System.Windows.Forms.Timer timer_message_seccess;
        internal System.Windows.Forms.TextBox txt_groupName;
        internal System.Windows.Forms.TextBox txt_groupDescription;
        internal System.Windows.Forms.TextBox txt_groupNumber;
        internal System.Windows.Forms.PictureBox picture_Search;
        internal DevExpress.XtraGrid.GridControl dataGridView_groups;
    }
}