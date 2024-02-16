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
using ExchangeAndMony;
using System.Data.SqlClient;
using ExchangeAndMony.pages.accountsInterface.Classes;

namespace ExchangeAndMony.pages.accountsInterface.accountsInitializatuionInterface
{
    public partial class CurrencyGuide : DevExpress.XtraEditors.XtraForm
    {
        //data.conection con = new data.conection();
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataTable dt = new DataTable();

        currency_class curr_class = new currency_class();
        Language lang = new Language();
        


        // nameDocument.Text="سند قيد بسيط";
        public CurrencyGuide()
        {

           // nameDocument.Text = "سند قيد بسيط";
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void timer_message_seccess_Tick(object sender, EventArgs e)
        {
            this.lbl_Message.Text = null;
            // lbl_Message.Enabled = false;
            this.PictureBoxMessage.Image = null;
            timer_message_seccess.Stop();
        }

        private void txt_CurrencyName_Enter(object sender, EventArgs e)
        {
            lang.arabicLanguage();
        }

        private void txt_ArabicSymbol_Enter(object sender, EventArgs e)
        {
            lang.arabicLanguage();
        }

        private void txt_EnglishSymbol_Enter(object sender, EventArgs e)
        {
            lang.englishLanguage();
        }

        private void txt_Note_Enter(object sender, EventArgs e)
        {
            lang.arabicLanguage();
        }

        private void GetDataGridView()
        {

            data.conection.con.Open();
            //from Currencise1
            dataAdapter = new SqlDataAdapter("select CurrencyNumbers,CurrencyName,ArabicSymbol,EnglishSymbol,username,Date,Note from Currencise", data.conection.con);
            // dataAdapter.
            dt.Clear();
            dataAdapter.Fill(dt);
            DGV_currency.DataSource = dt;
            data.conection.con.Close();


            DGV_currency.Columns[0].HeaderText = "رقم العملة";
            DGV_currency.Columns[1].HeaderText = " اسم العملة";
            DGV_currency.Columns[2].HeaderText = "الرمز بالعربي";
            DGV_currency.Columns[3].HeaderText = "  الرمز بالانجليزي";
            DGV_currency.Columns[4].HeaderText = "اسم المستخدم";
            DGV_currency.Columns[5].HeaderText = "التاريخ ";
            DGV_currency.Columns[6].HeaderText = "  الملاحظة";
            dt.Dispose();
            dataAdapter.Dispose();
        }
        private void CurrencyGuide_Activated(object sender, EventArgs e)
        {
            data.conection.con.Open();
            //from Currencise1
            dataAdapter = new SqlDataAdapter("select CurrencyNumbers,CurrencyName,ArabicSymbol,EnglishSymbol,Date,Note from Currencise", data.conection.con);
            dataAdapter.Fill(dt);
            DGV_currency.DataSource = dt;
            data.conection.con.Close();

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            //GetDataGridView();
            curr_class.edit_currency(this);
            GetDataGridView();
            curr_class.Clear_Controls_currency(this);
        }

        private void CurrencyGuide_Load(object sender, EventArgs e)
        {
           
           GetDataGridView();
            txt_numCurrency.DataBindings.Add("text", dt, "CurrencyNumbers");
            txt_CurrencyName.DataBindings.Add("text", dt, "CurrencyName");
            txt_ArabicSymbol.DataBindings.Add("text", dt, "ArabicSymbol");
            txt_EnglishSymbol.DataBindings.Add("text", dt, "EnglishSymbol");
            txt_Note.DataBindings.Add("text", dt, "Note");

            DGV_currency.EndEdit();
            DGV_currency.BindingContext[dt].Position = DGV_currency.BindingContext[dt].Count +1;

               

        }

        private void DGV_currency_ColumnHeadersDefaultCellStyleChanged(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            curr_class.delete_currency(this);
            GetDataGridView();
            curr_class.Clear_Controls_currency(this);

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_numCurrency.Text = "";
            txt_CurrencyName.Text = "";
            txt_ArabicSymbol.Text = "";
            txt_EnglishSymbol.Text = "";
            txt_Note.Text = "";
           // BindingContext[dt].
           // BindingContext[dt].Position = BindingContext[dt].Count +1;
            //BindingContext[dt].AddNew();

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = "CurrencyName like'%" + txt_search.Text.Trim() + "%'"; 
        }

        private void txt_ArabicSymbol_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Note_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
           
            
            if (txt_CurrencyName.Text == "")
                MessageBox.Show("حقل الاسم فارغ");
            else if (txt_ArabicSymbol.Text == "")
                MessageBox.Show("حقل الرمز العربي فارغ");
            else if (txt_EnglishSymbol.Text == "")
                MessageBox.Show("حقل الرمز الانجليزي فارغ");
            else
            {
               
                curr_class.add_currency(this);
                GetDataGridView();
                curr_class.Clear_Controls_currency(this);
              

            }

            // GetDataGridView();


        }
    }
}