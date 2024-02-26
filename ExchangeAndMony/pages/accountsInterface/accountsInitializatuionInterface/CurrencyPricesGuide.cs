﻿using System;
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
using ExchangeAndMony.pages.accountsInterface.accountsInitializatuionInterface;
using ExchangeAndMony.model;
using System.Data.Entity;

namespace ExchangeAndMony.pages.accountsInterface.accountsInitializatuionInterface
{
    public partial class CurrencyPricesGuide : DevExpress.XtraEditors.XtraForm
    {

        DBTAEMEntities db;
        public CurrencyPricesGuide()
        {


            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
           // tb_CurrenciesPricesTableAdapter4.Fill(dbtaemDataSet13.Tb_CurrenciesPrices);
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
    //        ExchangeAndMony.model.DBTAEMEntities dbContext = new ExchangeAndMony.model.DBTAEMEntities();
    //        // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
    //        dbContext.Tb_CurrenciesPrices.LoadAsync().ContinueWith(loadTask =>
    //         {
    //// Bind data to control when loading complete
    //       gridControl_CurrencyPrice.DataSource = dbContext.Tb_CurrenciesPrices.Local.ToBindingList();
    //        }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CurrencyPricesGuide_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBTAEMDataSet2.Tb_CurrenciesPrices' table. You can move, or remove it, as needed.
            this.tb_CurrenciesPricesTableAdapter.Fill(this.dBTAEMDataSet2.Tb_CurrenciesPrices);

            picture_Search.Image = Properties.Resources.Search_16x16;
            

        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            db = new DBTAEMEntities();
            //gridControl_CurrencyPrice.DataSource = db.Tb_CurrenciesPrices.Where(x => x.TtranferFrom.Contains(txt_Search.Text)).ToList();
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {

        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            if (
                txt_PurchasePrice.Text != "" && txt_SellingPrice.Text !="" && txt_LowPricePurchasing.Text != "" &&
                txt_HighestPricePurchasing.Text !="" && txt_LowPrice.Text !="" && txt_HighestPrice.Text !="" && txt_LowPriceSelling.Text !="" &&
                txt_HighestPriceSelling.Text !="" && txt_HighestPricePurchasing.Text !="" && txt_TtranferPrice.Text != ""
                )
            {
                if (Convert.ToDecimal(txt_PurchasePrice.Text) > Convert.ToDecimal(txt_SellingPrice.Text))
                {
                    var Responsetext = MessageBox.Show("سعر البيع أقل من سعر الشراء هل تريد المتابعة", "title", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    MessageBox.Show(Responsetext.ToString());
                }
                if (Convert.ToDecimal(txt_LowPricePurchasing.Text) > Convert.ToDecimal(txt_HighestPricePurchasing.Text))
                {
                    var Responsetext = MessageBox.Show("أعلى سعر للشراء أقل من أدنى سعر للشراء هل تريد المتابعة", "title", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    MessageBox.Show(Responsetext.ToString());
                }
                if (Convert.ToDecimal(txt_LowPrice.Text) > Convert.ToDecimal(txt_HighestPrice.Text))
                {
                    var Responsetext = MessageBox.Show("أعلى سعر أقل من أدنى سعر هل تريد المتابعة", "title", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    MessageBox.Show(Responsetext.ToString());
                }
                if (Convert.ToDecimal(txt_LowPriceSelling.Text) > Convert.ToDecimal(txt_HighestPriceSelling.Text))
                {
                    var Responsetext = MessageBox.Show("أعلى سعر بيع أقل من أدنى سعر بيع هل تريد المتابعة", "title", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    MessageBox.Show(Responsetext.ToString());
                }
                if (Convert.ToDecimal(txt_LowPriceSelling.Text) > Convert.ToDecimal(txt_HighestPricePurchasing.Text))
                {
                    var Responsetext = MessageBox.Show("أعلى سعر للشراء أقل من أدنى سعر بيع هل تريد المتابعة", "title", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    MessageBox.Show(Responsetext.ToString());
                }
            }
            else
            {
                MessageBox.Show("إحدى الحقول فارغة تأكد من إدخال البيانات ");
            }
           
          


        }

        private void Currencie_com1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_add_Click(object sender, EventArgs e)
        {

        }

        private void Btn_add_Click_1(object sender, EventArgs e)
        {
            db = new DBTAEMEntities();
            Tb_CurrenciesPrices add_price;

            if(Convert.ToDecimal(txt_PurchasePrice.Text) < Convert.ToDecimal(txt_SellingPrice.Text))
            {
                var Responsetext = MessageBox.Show("message", "title", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                MessageBox.Show(Responsetext.ToString());
            }
            try
            {
                db = new DBTAEMEntities();
                add_price = new Tb_CurrenciesPrices();
                add_price.TtranferFrom = currencie_com1.selecteditem();
                add_price.TtranferTo = currencie_com2.selecteditem();
                add_price.TtranferPrice = Convert.ToDecimal(txt_TtranferPrice.Text);
                add_price.PurchasePrice = Convert.ToDecimal(txt_PurchasePrice.Text);
                add_price.SellingPrice = Convert.ToDecimal(txt_SellingPrice.Text);
                add_price.LowPrice = Convert.ToDecimal(txt_LowPrice.Text);
                add_price.HighestPrice = Convert.ToDecimal(txt_HighestPrice.Text);
                add_price.LowPricePurchasing = Convert.ToDecimal(txt_LowPricePurchasing.Text);
                add_price.LowPriceSelling = Convert.ToDecimal(txt_LowPriceSelling.Text);
                add_price.HighestPricePurchasing = Convert.ToDecimal(txt_HighestPricePurchasing.Text);
                add_price.HighestPriceSelling = Convert.ToDecimal(txt_HighestPriceSelling.Text);
                add_price.Note = txt_Note.Text;
                db.Entry(add_price).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                // txt_groupName.Text = groups.txt_groupDescription.Text = "";
                // loadData(groups);

                lbl_Message.Text = "تم الحفظ بنجاح";
                PictureBoxMessage.Image = Properties.Resources.OK;
                timer_message_seccess.Start();

            }
            catch
            {
                //MessageBox.Show("لم يتم الاضافة ");
            }

        }

        private void GridControl_CurrencyPrice_Click(object sender, EventArgs e)
        {

        }

        private void Timer_message_seccess_Tick(object sender, EventArgs e)
        {
            this.lbl_Message.Text = null;
            this.PictureBoxMessage.Image = null;
            timer_message_seccess.Stop();
        }

        private void Txt_TtranferPrice_KeyPress(object sender, KeyPressEventArgs e)
        {

            //MessageBox.Show(e.KeyChar.ToString());
            // التحقق من رمز الحرف
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSymbol(e.KeyChar))
            {
                // إلغاء الحدث
                e.Handled = true;
            }
        }

        private void Txt_PurchasePrice_TextChanged(object sender, EventArgs e)
        {
           // sender.
        }
    }
}