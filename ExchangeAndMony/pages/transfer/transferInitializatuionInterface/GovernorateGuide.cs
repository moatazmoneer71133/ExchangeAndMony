using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ExchangeAndMony.pages;
using ExchangeAndMony.model;


namespace ExchangeAndMony.pages.transfer.transferInitializatuionInterface
{
    public partial class GovernorateGuide : DevExpress.XtraEditors.XtraForm
    {
        DBTAEMEntities db;
        Tb_Entities add_governorata;
        int id;

        // nameDocument.Text="سند قيد بسيط";
        public GovernorateGuide()
        {

           // nameDocument.Text = "سند قيد بسيط";
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                db = new DBTAEMEntities();
                dataGridView_governorate.DataSource = db.Tb_Entities.ToList();
                dataGridView_governorate.Columns[0].HeaderText = "رقم المحافظة";
                dataGridView_governorate.Columns[2].HeaderText = "اسم المحافظة";
                dataGridView_governorate.Columns[9].HeaderText = "ملاحظة";
                dataGridView_governorate.Columns[6].HeaderText = "التاريخ";
            }
            catch
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            try
            {


                db = new DBTAEMEntities();

                add_governorata = new Tb_Entities();

                add_governorata.EntitiesNumber = Convert.ToInt32( text_number.Text);
                add_governorata.Side = text_governorata_name.Text;
                add_governorata.Note = text_note.Text; 
                
                add_governorata.InsertDate = DateTime.Now.Date;
                db.Entry(add_governorata).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();

                LoadData();

                MessageBox.Show("تم الاضافة بنجاح");

                text_number.Text = "";
                text_governorata_name.Text = "";
                text_note.Text = "";
            }
            catch
            {
                MessageBox.Show("لم يتم الاضافة ");
            }
        }

        private void DataGridView_governorate_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dataGridView_governorate.CurrentRow.Cells[0].Value);

            }
            catch
            {

            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                db = new DBTAEMEntities();
                add_governorata = new Tb_Entities();

                add_governorata.EntitiesNumber = id;
                db.Entry(add_governorata).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();

                LoadData();

                MessageBox.Show("تمة  الحذف");

            }
            catch
            {
                MessageBox.Show("لايمكن الحذف ");
            }
        }

        private void DataGridView_governorate_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                text_number.Text = Convert.ToString(dataGridView_governorate.CurrentRow.Cells[0].Value);
                text_governorata_name.Text = Convert.ToString(dataGridView_governorate.CurrentRow.Cells[2].Value);
                text_note.Text = Convert.ToString(dataGridView_governorate.CurrentRow.Cells[9].Value);


            }
            catch
            {

            }
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            try
            {


                db = new DBTAEMEntities();

                add_governorata = new Tb_Entities();

                add_governorata.EntitiesNumber = id;
                add_governorata.EntitiesNumber = Convert.ToInt32(text_number.Text);
                add_governorata.Side = text_governorata_name.Text;
                add_governorata.Note = text_note.Text;

                add_governorata.InsertDate = DateTime.Now.Date;
                db.Entry(add_governorata).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                LoadData();

                MessageBox.Show("تم التعديل بنجاح");

                text_number.Text = "";
                text_governorata_name.Text = "";

                text_note.Text = "";
            }
            catch
            {
                MessageBox.Show("لايمكن التعديل");
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {

        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_search_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView_governorate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Text_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void Text_governorata_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Text_note_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}