using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExchangeAndMony.model;
namespace ExchangeAndMony.pages
{
    public partial class currencie_com : UserControl
    {
        DBTAEMEntities db = new DBTAEMEntities();
        public currencie_com()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            if (!this.DesignMode) {
                com_currencie.DataSource = db.Tb_Currencise.Select(x => x.CurrencyName).ToList();
            }
        }

        private void Com_currencie_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void Com_currencie_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void Currencie_com_Load(object sender, EventArgs e)
        {
            loadData();



        }

        public string selecteditem()
        {
            return com_currencie.SelectedValue.ToString();
        }
    }
}
