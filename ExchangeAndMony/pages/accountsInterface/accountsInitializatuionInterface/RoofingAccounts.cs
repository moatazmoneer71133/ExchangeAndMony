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
using ExchangeAndMony.pages.accountsInterface.accountsInitializatuionInterface;
using System.Data.Entity;


namespace ExchangeAndMony.pages.accountsInterface.accountsInitializatuionInterface
{
    public partial class RoofingAccounts : DevExpress.XtraEditors.XtraForm
    {

        // nameDocument.Text="سند قيد بسيط";
        public RoofingAccounts()
        {

            // nameDocument.Text = "سند قيد بسيط";
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            //  currenciesTableAdapter1.Fill(dbtaemDataSet11.Currencies);
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            ExchangeAndMony.model.DBTAEMEntities dbContext = new ExchangeAndMony.model.DBTAEMEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.Tb_RoofingAccounts.LoadAsync().ContinueWith(loadTask =>
            {
                    // Bind data to control when loading complete
               gridControl1.DataSource = dbContext.Tb_RoofingAccounts.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_add_Click(object sender, EventArgs e)
        {

        }

        private void RoofingAccounts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBTAEMDataSet2.Tb_Groups' table. You can move, or remove it, as needed.
            this.tb_GroupsTableAdapter.Fill(this.dBTAEMDataSet2.Tb_Groups);
            // TODO: This line of code loads data into the 'dBTAEMDataSet2.Tb_RoofingAccounts' table. You can move, or remove it, as needed.
            this.tb_RoofingAccountsTableAdapter.Fill(this.dBTAEMDataSet2.Tb_RoofingAccounts);

        }

        private void Btn_add_Click_1(object sender, EventArgs e)
        {

        }
    }
}