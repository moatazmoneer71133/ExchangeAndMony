namespace ExchangeAndMony.pages.transferInterface.transferInitializatuionInterface
{
    partial class GovernorateGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GovernorateGuide));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_print = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_exit = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_number = new System.Windows.Forms.TextBox();
            this.text_governorata_name = new System.Windows.Forms.TextBox();
            this.text_note = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_governorate = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_governorate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_governorate);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(6, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1308, 771);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.groupBox3.Location = new System.Drawing.Point(19, 274);
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
            this.btn_edit.Location = new System.Drawing.Point(733, 23);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(125, 47);
            this.btn_edit.TabIndex = 24;
            this.btn_edit.Text = "تحديث";
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
            this.btn_update.Location = new System.Drawing.Point(996, 23);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(125, 47);
            this.btn_update.TabIndex = 21;
            this.btn_update.Text = "تعديل";
            this.btn_update.Click += new System.EventHandler(this.Btn_update_Click);
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
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_exit.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Appearance.Options.UseFont = true;
            this.btn_exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.ImageOptions.Image")));
            this.btn_exit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_exit.Location = new System.Drawing.Point(69, 23);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(125, 47);
            this.btn_exit.TabIndex = 18;
            this.btn_exit.Text = "خروج";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.text_number);
            this.groupBox1.Controls.Add(this.text_governorata_name);
            this.groupBox1.Controls.Add(this.text_note);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(19, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1266, 196);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1120, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "الرقم";
            // 
            // text_number
            // 
            this.text_number.Location = new System.Drawing.Point(862, 27);
            this.text_number.Multiline = true;
            this.text_number.Name = "text_number";
            this.text_number.Size = new System.Drawing.Size(238, 30);
            this.text_number.TabIndex = 25;
            // 
            // text_governorata_name
            // 
            this.text_governorata_name.Location = new System.Drawing.Point(674, 65);
            this.text_governorata_name.Multiline = true;
            this.text_governorata_name.Name = "text_governorata_name";
            this.text_governorata_name.Size = new System.Drawing.Size(426, 30);
            this.text_governorata_name.TabIndex = 25;
            // 
            // text_note
            // 
            this.text_note.Location = new System.Drawing.Point(674, 113);
            this.text_note.Multiline = true;
            this.text_note.Name = "text_note";
            this.text_note.Size = new System.Drawing.Size(426, 30);
            this.text_note.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1122, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "ملاحظات";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1120, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 25);
            this.label11.TabIndex = 24;
            this.label11.Text = "اسم المحافظة";
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
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1226, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(544, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "دليل المحافظات";
            // 
            // dataGridView_governorate
            // 
            this.dataGridView_governorate.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_governorate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_governorate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_governorate.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_governorate.Location = new System.Drawing.Point(0, 368);
            this.dataGridView_governorate.Name = "dataGridView_governorate";
            this.dataGridView_governorate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_governorate.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_governorate.RowTemplate.Height = 26;
            this.dataGridView_governorate.Size = new System.Drawing.Size(1305, 400);
            this.dataGridView_governorate.TabIndex = 11;
            this.dataGridView_governorate.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_governorate_CellDoubleClick);
            this.dataGridView_governorate.Click += new System.EventHandler(this.DataGridView_governorate_Click);
            // 
            // GovernorateGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 777);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GovernorateGuide";
            this.Text = "/*";
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_governorate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_note;
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
        private System.Windows.Forms.TextBox text_number;
        private System.Windows.Forms.TextBox text_governorata_name;
        private System.Windows.Forms.DataGridView dataGridView_governorate;
    }
}