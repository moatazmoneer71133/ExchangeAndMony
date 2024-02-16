using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ExchangeAndMony.data;
using ExchangeAndMony.pages.accountsInterface.accountsInitializatuionInterface;
using System.Windows.Forms;

namespace ExchangeAndMony.pages.accountsInterface.Classes
{
    class currency_class
    {

        DataTable dt = new DataTable();

        SqlDataAdapter da = new SqlDataAdapter();

        public void myselect()
        {

            da.SelectCommand = new SqlCommand("select CurrencyName,ArabicSymbol,EnglishSymbol,Date,Note from Currencise", data.conection.con);
            dt.Clear();
            da.Fill(dt);
        }
        public void delete_currency(CurrencyGuide form)
        {
            try
            {

                data.conection.con.Open();
                //string CurrencyNumber;
                //a = Interaction.InputBox("ادخل الرقم");
                //CurrencyNumber = DGV_currency.CurrentRow.Cells[1].Value.ToString();
                da.DeleteCommand = new SqlCommand("delete from Currencise where CurrencyNumber=" + form.txt_numCurrency.Text, data.conection.con);
                da.DeleteCommand.ExecuteNonQuery();
                // myselect();
                data.conection.con.Close();
                //int d;
                //DataView dv = new DataView(dt);
                //dv.RowFilter = "اسم العملة like'" + form.txt_CurrencyName.Text.Trim() + "'";
                //if (dv.Count == 0)
                //{
                //conection.con.Open();
                //da.InsertCommand = new SqlCommand("insert into Currencise1(CurrencyName,ArabicSymbol,EnglishSymbol,Date,Note) values('" + form.txt_CurrencyName.Text + "','" + form.txt_ArabicSymbol.Text + "','" + form.txt_EnglishSymbol.Text + "','2024/12/5','" + form.txt_Note.Text + "')", conection.con);
                //da.InsertCommand.ExecuteNonQuery();
                //myselect();
                //conection.con.Close();
                dt.Dispose();

                //    if (d > 0)
                //        form.DGV_currency.BindingContext[dt].EndCurrentEdit();
                //    else
                //        form.DGV_currency.BindingContext[dt].CancelCurrentEdit();
                //    form.txt_CurrencyName.BackColor = Color.White;

                //}



                form.lbl_Message.Text = "تم الحذف بنجاح";
                form.PictureBoxMessage.Image = Properties.Resources.OK;
                form.timer_message_seccess.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        public void Clear_Controls_currency(CurrencyGuide form)
        {
            form.txt_CurrencyName.Text = null;
            form.txt_ArabicSymbol.Text = null;
            form.txt_EnglishSymbol.Text = null;
            form.txt_Note.Text = null;

        }
        public void add_currency(CurrencyGuide form)
        {
            try
            {

                //int d;
                //DataView dv = new DataView(dt);
                //dv.RowFilter = "اسم العملة like'" + form.txt_CurrencyName.Text.Trim() + "'";
                //if (dv.Count == 0)
                //{
                conection.con.Open();
                da.InsertCommand = new SqlCommand("insert into Currencise(CurrencyName,ArabicSymbol,EnglishSymbol,Date,Note) values('" + form.txt_CurrencyName.Text + "','" + form.txt_ArabicSymbol.Text + "','" + form.txt_EnglishSymbol.Text + "','2024/12/5','" + form.txt_Note.Text + "')", conection.con);
                da.InsertCommand.ExecuteNonQuery();
                myselect();
                conection.con.Close();
                dt.Dispose();

                //    if (d > 0)
                //        form.DGV_currency.BindingContext[dt].EndCurrentEdit();
                //    else
                //        form.DGV_currency.BindingContext[dt].CancelCurrentEdit();
                //    form.txt_CurrencyName.BackColor = Color.White;

                //}



                form.lbl_Message.Text = "تم الحفظ بنجاح";
                form.PictureBoxMessage.Image = Properties.Resources.OK;
                form.timer_message_seccess.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        public void edit_currency(CurrencyGuide form)
        {
            try
            {

                //int d;
                //DataView dv = new DataView(dt);
                //dv.RowFilter = "اسم العملة like'" + form.txt_CurrencyName.Text.Trim() + "'";
                //if (dv.Count == 0)
                //{
                //into Currencise1(
                conection.con.Open();
                da.UpdateCommand = new SqlCommand("update Currencise set CurrencyName='" + form.txt_CurrencyName.Text  +"',ArabicSymbol='" + form.txt_ArabicSymbol.Text + "',EnglishSymbol='" + form.txt_EnglishSymbol.Text + "',Date='"+ DateTime.Now.Date.ToString("yyyy-MM-dd")+"',Note='" + form.txt_Note.Text + "' where CurrencyNumbers='" + form.txt_numCurrency.Text+"'", conection.con);
                da.UpdateCommand.ExecuteNonQuery();
                myselect();
                conection.con.Close();
                dt.Dispose();

                //    if (d > 0)
                //        form.DGV_currency.BindingContext[dt].EndCurrentEdit();
                //    else
                //        form.DGV_currency.BindingContext[dt].CancelCurrentEdit();
                //    form.txt_CurrencyName.BackColor = Color.White;

                //}



                form.lbl_Message.Text = "تم التعديل بنجاح";
                form.PictureBoxMessage.Image = Properties.Resources.OK;
                form.timer_message_seccess.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
