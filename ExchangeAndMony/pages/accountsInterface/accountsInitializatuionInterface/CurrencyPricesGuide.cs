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
    public partial class CurrencyPricesGuide : DevExpress.XtraEditors.XtraForm
    {

        DBTAEMEntities db = new DBTAEMEntities();
        public CurrencyPricesGuide()
        {

          
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CurrencyPricesGuide_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBTAEMDataSet.Tb_CurrenciesPrices' table. You can move, or remove it, as needed.
            this.tb_CurrenciesPricesTableAdapter.Fill(this.dBTAEMDataSet.Tb_CurrenciesPrices);
            picture_Search.Image = Properties.Resources.Search_16x16;

        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {

            gridControl1.DataSource = db.Tb_CurrenciesPrices.Where(x => x.TtranferFrom.Contains(txt_Search.Text)).ToList();
        }
    }
}