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
using ExchangeAndMony.BL.accountsClasses.accountsInitializatuionClasses;
using ExchangeAndMony.model;
using ExchangeAndMony.BL;
using ExchangeAndMony.pages.accountsInterface.Classes;

namespace ExchangeAndMony.pages.accountsInterface.accountsInitializatuionInterface
{
    
    public partial class GroupsGuide : DevExpress.XtraEditors.XtraForm
    {
        int id_group;
        DBTAEMEntities db;
        Tb_Groups add_Group;
        Class_GroupsGuide class_GroupsGuide = new Class_GroupsGuide();
        Languages lang = new Languages();
       
        
        public GroupsGuide()
        {

           // nameDocument.Text = "سند قيد بسيط";
            InitializeComponent();
            class_GroupsGuide.loadData(this);
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
           // accountsInitializatuionCode groups = new accountsInitializatuionCode();
            class_GroupsGuide.addGroup(this);
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void Timer_message_seccess_Tick(object sender, EventArgs e)
        {
            this.lbl_Message.Text = null;
            this.PictureBoxMessage.Image = null;
            timer_message_seccess.Stop();
        }

        private void DataGridView_groups_DoubleClick(object sender, EventArgs e)
        {

        }

        private void DataGridView_groups_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id_group = Convert.ToInt32(dataGridView_groups.CurrentRow.Cells[0].Value);
            txt_groupName.Text = Convert.ToString(dataGridView_groups.CurrentRow.Cells[1].Value);
            txt_groupDescription.Text = Convert.ToString(dataGridView_groups.CurrentRow.Cells[4].Value);
        }

        private void Txt_groupName_Enter(object sender, EventArgs e)
        {
            lang.arabicLanguage();
        }

        private void Txt_groupDescription_Enter(object sender, EventArgs e)
        {
            lang.arabicLanguage();
        }
    }
}