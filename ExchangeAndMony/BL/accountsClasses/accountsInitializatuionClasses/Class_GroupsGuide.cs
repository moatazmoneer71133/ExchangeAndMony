using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExchangeAndMony.model;
using ExchangeAndMony.pages.accountsInterface.accountsInitializatuionInterface;
namespace ExchangeAndMony.BL.accountsClasses.accountsInitializatuionClasses
{
    class Class_GroupsGuide
    {
        DBTAEMEntities db;
       



        public void loadData(GroupsGuide groups)
        {
      


                using (var db = new DBTAEMEntities())
                {
                    //  الكيانات التي نريد عرضها
                    var entities = db.Tb_Groups.ToList();

                    //  الحقول التي نريد عرضها
                    var selectedFields = new List<string> { "GroupNumber", "GroupName", "TheDate" , "UserName","Note" };

                    //   قائمة من الكائنات المجهولة تحتوي على الحقول المحددة
                    var anonymousObjects = entities.Select(x => new {
                        Field1 = x.GetType().GetProperty(selectedFields[0]).GetValue(x),
                        Field2 = x.GetType().GetProperty(selectedFields[1]).GetValue(x),
                        Field3 = x.GetType().GetProperty(selectedFields[2]).GetValue(x),
                        Field4 = x.GetType().GetProperty(selectedFields[3]).GetValue(x),
                        Field5 = x.GetType().GetProperty(selectedFields[4]).GetValue(x),
                     
                    });

                // ربط DataGridView بالقائمة

                groups.dataGridView_groups.DataSource = anonymousObjects.ToList();
                groups.dataGridView_groups.Columns[0].HeaderText = "رقم المجموعة";
                groups.dataGridView_groups.Columns[1].HeaderText = " اسم المجموعة";
                groups.dataGridView_groups.Columns[2].HeaderText = "اسم المستخدم";
                groups.dataGridView_groups.Columns[3].HeaderText = "التاريخ ";
                groups.dataGridView_groups.Columns[4].HeaderText = "  الملاحظة";

            }
            

}
       
        public void addGroup(GroupsGuide groups)
        {
            Tb_Groups add_Group;
            try
            {
                db = new DBTAEMEntities();
                add_Group = new Tb_Groups();
                add_Group.GroupName = groups.txt_groupName.Text;
                add_Group.Note = groups.txt_groupDescription.Text;
                //add_Group.UserName = "معتز منير";
                //add_Group.UserNumbers = 1;
                add_Group.TheDate = DateTime.Now.Date;
                db.Entry(add_Group).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                groups.txt_groupName.Text = groups.txt_groupDescription.Text = "";
                loadData(groups);
             
                groups.lbl_Message.Text = "تم الحفظ بنجاح";
                groups.PictureBoxMessage.Image = Properties.Resources.OK;
                groups.timer_message_seccess.Start();

            }
            catch
            {
                //MessageBox.Show("لم يتم الاضافة ");
            }
        }


        public void edit_groups(GroupsGuide groups)
        {
            Tb_Groups edit_Group;
            try
            {
                db = new DBTAEMEntities();
                edit_Group = new Tb_Groups();
                //int id = 
                edit_Group.GroupNumber =Convert.ToInt32( groups.txt_groupNumber.Text);
                edit_Group.GroupName = groups.txt_groupName.Text;
                edit_Group.Note = groups.txt_groupDescription.Text;
                //edit_Group.UserName = "معتز منير";
                //edit_Group.UserNumbers = 1;
                edit_Group.TheDate = DateTime.Now.Date;
                db.Entry(edit_Group).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                groups.txt_groupName.Text = groups.txt_groupDescription.Text = "";
                loadData(groups);
                groups.lbl_Message.Text = "تم التعديل بنجاح";
                groups.PictureBoxMessage.Image = Properties.Resources.OK;
                groups.timer_message_seccess.Start();

            }
            catch
            {
                //MessageBox.Show("لم يتم الاضافة ");
            }


        }

        public void delete_groups(GroupsGuide groups)
        {
            Tb_Groups delete_Group;
            try
            {
                db = new DBTAEMEntities();
                delete_Group = new Tb_Groups();
                //int id = 
                delete_Group.GroupNumber = Convert.ToInt32(groups.txt_groupNumber.Text);
                //edit_Group.GroupName = groups.txt_groupName.Text;
                //edit_Group.Note = groups.txt_groupDescription.Text;
                //edit_Group.UserName = "معتز منير";
                //edit_Group.UserNumbers = 1;
                //edit_Group.TheDate = DateTime.Now.Date;
                db.Entry(delete_Group).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                groups.txt_groupName.Text = groups.txt_groupDescription.Text = "";
                loadData(groups);
                groups.lbl_Message.Text = "تم الحذف بنجاح";
                groups.PictureBoxMessage.Image = Properties.Resources.OK;
                groups.timer_message_seccess.Start();

            }
            catch
            {
                //MessageBox.Show("لم يتم الاضافة ");
            }
        }
    }
}
