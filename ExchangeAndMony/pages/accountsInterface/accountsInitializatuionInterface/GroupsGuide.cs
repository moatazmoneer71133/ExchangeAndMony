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
using ExchangeAndMony.pages.accountsInterface.accountsInitializatuionInterface;
using ExchangeAndMony.model;

namespace ExchangeAndMony.pages.accountsInterface.accountsInitializatuionInterface
{
    
    public partial class GroupsGuide : DevExpress.XtraEditors.XtraForm
    {
        DBTAEMEntities db;
        Tb_Groups add_Group;

        // nameDocument.Text="سند قيد بسيط";
        public GroupsGuide()
        {

           // nameDocument.Text = "سند قيد بسيط";
            InitializeComponent();
            loadData();
        }
        private void loadData()
        {
            try
            {
                db = new DBTAEMEntities();
                dataGridView_groups.DataSource = db.Tb_Groups.ToList();
                dataGridView_groups.Columns[0].HeaderText = "رقم المجموعة";
                dataGridView_groups.Columns[1].HeaderText = "اسم المجموعة";
                dataGridView_groups.Columns[2].HeaderText = "رقم المستخدم";
                dataGridView_groups.Columns[3].HeaderText = "اسم المستخدم";
                dataGridView_groups.Columns[4].HeaderText = "التاريخ ";
                dataGridView_groups.Columns[5].HeaderText = "الوصف";

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
            try { 
            db = new DBTAEMEntities();
            add_Group = new Tb_Groups();
            add_Group.GroupName = txt_groupName.Text;
            add_Group.Note = txt_groupDescription.Text;
                //add_Group.UserName = "معتز منير";
                //add_Group.UserNumbers = 1;
            add_Group.TheDate = DateTime.Now.Date;
                db.Entry(add_Group).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
                txt_groupName.Text = txt_groupDescription.Text = "";
                loadData();
               
                MessageBox.Show("تم الاضافة بنجاح");
            }
            catch
            {
                MessageBox.Show("لم يتم الاضافة ");
            }

        }
    }
}