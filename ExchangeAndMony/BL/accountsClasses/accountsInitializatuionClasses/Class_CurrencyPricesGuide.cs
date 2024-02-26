using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExchangeAndMony.model;
using ExchangeAndMony.pages.accountsInterface.accountsInitializatuionInterface;
namespace ExchangeAndMony.BL.accountsClasses.accountsInitializatuionClasses
{
    class Class_CurrencyPricesGuide
    {
        DBTAEMEntities db;
       
        Tb_CurrenciesPrices Tb_price;


        public void loadData(CurrencyPricesGuide price)
        {
            
            db = new DBTAEMEntities();
            price.gridControl1.DataSource = db.Tb_CurrenciesPrices.OrderByDescending(x => x.CurrencyPriceNumber).ToList();

        }
        public void add_price(CurrencyPricesGuide price)
        {
            
            Tb_CurrenciesPrices add_price;

            //if (Convert.ToDecimal(txt_PurchasePrice.Text) < Convert.ToDecimal(txt_SellingPrice.Text))
            //{
            //    var Responsetext = MessageBox.Show("message", "title", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //    MessageBox.Show(Responsetext.ToString());
            //}
            try
            {
                db = new DBTAEMEntities();
                Tb_price = new Tb_CurrenciesPrices();
                Tb_price.TtranferFrom = price.currencie_com1.selecteditem();
                Tb_price.TtranferTo = price.currencie_com2.selecteditem();
                Tb_price.TtranferPrice = Convert.ToDecimal(price.txt_TtranferPrice.Text);
                Tb_price.PurchasePrice = Convert.ToDecimal(price.txt_PurchasePrice.Text);
                Tb_price.SellingPrice = Convert.ToDecimal(price.txt_SellingPrice.Text);
                Tb_price.LowPrice = Convert.ToDecimal(price.txt_LowPrice.Text);
                Tb_price.HighestPrice = Convert.ToDecimal(price.txt_HighestPrice.Text);
                Tb_price.LowPricePurchasing = Convert.ToDecimal(price.txt_LowPricePurchasing.Text);
                Tb_price.LowPriceSelling = Convert.ToDecimal(price.txt_LowPriceSelling.Text);
                Tb_price.HighestPricePurchasing = Convert.ToDecimal(price.txt_HighestPricePurchasing.Text);
                Tb_price.HighestPriceSelling = Convert.ToDecimal(price.txt_HighestPriceSelling.Text);
                Tb_price.Note = price.txt_Note.Text;
                db.Entry(Tb_price).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                // txt_groupName.Text = groups.txt_groupDescription.Text = "";
                loadData(price);

                price.lbl_Message.Text = "تم الحفظ بنجاح";
                price.PictureBoxMessage.Image = Properties.Resources.OK;
                price.timer_message_seccess.Start();

            }
            catch
            {
                //MessageBox.Show("لم يتم الاضافة ");
            }
        }

        public void edit_price(CurrencyPricesGuide price,int id)
        {

            //Tb_CurrenciesPrices add_price;

            //if (Convert.ToDecimal(txt_PurchasePrice.Text) < Convert.ToDecimal(txt_SellingPrice.Text))
            //{
            //    var Responsetext = MessageBox.Show("message", "title", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //    MessageBox.Show(Responsetext.ToString());
            //}
            try
            {
                db = new DBTAEMEntities();
                
                Tb_price = new Tb_CurrenciesPrices();

                Tb_price.CurrencyPriceNumber = id;
                Tb_price.TtranferFrom = price.currencie_com1.selecteditem();
                Tb_price.TtranferTo = price.currencie_com2.selecteditem();
                Tb_price.TtranferPrice = Convert.ToDecimal(price.txt_TtranferPrice.Text);
                Tb_price.PurchasePrice = Convert.ToDecimal(price.txt_PurchasePrice.Text);
                Tb_price.SellingPrice = Convert.ToDecimal(price.txt_SellingPrice.Text);
                Tb_price.LowPrice = Convert.ToDecimal(price.txt_LowPrice.Text);
                Tb_price.HighestPrice = Convert.ToDecimal(price.txt_HighestPrice.Text);
                Tb_price.LowPricePurchasing = Convert.ToDecimal(price.txt_LowPricePurchasing.Text);
                Tb_price.LowPriceSelling = Convert.ToDecimal(price.txt_LowPriceSelling.Text);
                Tb_price.HighestPricePurchasing = Convert.ToDecimal(price.txt_HighestPricePurchasing.Text);
                Tb_price.HighestPriceSelling = Convert.ToDecimal(price.txt_HighestPriceSelling.Text);
                Tb_price.Note = price.txt_Note.Text;
                db.Entry(Tb_price).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                loadData(price);

                price.lbl_Message.Text = "تم التعديل بنجاح";
                price.PictureBoxMessage.Image = Properties.Resources.OK;
                price.timer_message_seccess.Start();

            }
            catch
            {
                //MessageBox.Show("لم يتم الاضافة ");
            }
        }

        public void delete_price(CurrencyPricesGuide price, int id)
        {

            //Tb_CurrenciesPrices add_price;

            //if (Convert.ToDecimal(txt_PurchasePrice.Text) < Convert.ToDecimal(txt_SellingPrice.Text))
            //{
            //    var Responsetext = MessageBox.Show("message", "title", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //    MessageBox.Show(Responsetext.ToString());
            //}
            try
            {
                db = new DBTAEMEntities();

                Tb_price = new Tb_CurrenciesPrices();
                Tb_price.CurrencyPriceNumber = id;
                db.Entry(Tb_price).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                
                // txt_groupName.Text = groups.txt_groupDescription.Text = "";
                loadData(price);

                price.lbl_Message.Text = "تم الحذف بنجاح";
                price.PictureBoxMessage.Image = Properties.Resources.OK;
                price.timer_message_seccess.Start();
                
            }
            catch
            {
                //MessageBox.Show("لم يتم الاضافة ");
                
            }
        }



    }
}
