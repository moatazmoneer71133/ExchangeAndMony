﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ExchangeAndMony.pages.accountsInterface.accountsInitializatuionInterface;
using ExchangeAndMony.pages.accountsInterface.accountsprocessInterface;
using ExchangeAndMony.pages.transfer.transferInitializatuionInterface;
using ExchangeAndMony.pages.transfer.transferprocessInterface;
using ExchangeAndMony.pages.sell_and_buy;
using ExchangeAndMony.pages.file;
namespace ExchangeAndMony
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        ReceiptDivertClients receiptDivertClients = new ReceiptDivertClients();
        ReceiptVoucherClients receiptVoucherClients = new ReceiptVoucherClients();
        DoubleEntry doubleEntry = new DoubleEntry();
        AccountReconcilement accountReconcilement = new AccountReconcilement();
        BoxInventory boxInventory = new BoxInventory();
        CurrencyGuide currencyGuide = new CurrencyGuide();
        CurrencyPricesGuide currencyPricesGuide = new CurrencyPricesGuide();
        BoxGuide boxGuide = new BoxGuide();
        GroupsGuide groupsGuide = new GroupsGuide();
        EmployeeGuide employeeGuide = new EmployeeGuide();
        RoofingAccounts roofingAccounts = new RoofingAccounts();
        GovernorateGuide governorateGuide = new GovernorateGuide();
        RecipientInfo recipientInfo = new RecipientInfo();
        PersonalInfo personalInfo = new PersonalInfo();
        AccountsGuide acounts_guide = new AccountsGuide();
        Exchange_confirmation exchange_confirmation = new Exchange_confirmation();
        Supplying_transfer Supplying_transfer = new Supplying_transfer();
        Export_transfer export_transfer = new Export_transfer();
        Receiving_transfer receiving_transfer = new Receiving_transfer();
        Stoping_transfer stoping_transfer = new Stoping_transfer();
        Transfer_money transfer_money = new Transfer_money();
        Sell_currency sell_currency = new Sell_currency();


        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void dropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ReceiptDivertClients_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             panel_mainhome.Controls.Clear();
            receiptDivertClients.panel_ReceiptDivertClients.Location = new Point(300, 0);
            panel_mainhome.Controls.Add(receiptDivertClients.panel_ReceiptDivertClients);
           // gridControl_Divert.
        }

        private void btn_ReceiptVoucherClients_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel_mainhome.Controls.Clear();
            receiptVoucherClients.panel_ReceiptVoucherClients.Location = new Point(300, 0);
            panel_mainhome.Controls.Add(receiptVoucherClients.panel_ReceiptVoucherClients);
        }

        private void panel_mainhome_Paint(object sender, PaintEventArgs e)
        {
            panel_mainhome.Width = ribbonControl1.Width;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Location.X.Equals(300);
        }

        private void panel_mainhome_Paint_1(object sender, PaintEventArgs e)
        {
       
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_SimpleRegistrationBond_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SimpleRegistrationBond simpleRegistrationBond = new SimpleRegistrationBond();
            panel_mainhome.Controls.Clear();
            simpleRegistrationBond.TopLevel = false;
            panel_mainhome.Controls.Add(simpleRegistrationBond);
            simpleRegistrationBond.Location = new Point(300, 0);
            simpleRegistrationBond.Show();
        }

        private void btn_DoubleEntry_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //  DoubleEntry
            panel_mainhome.Controls.Clear();
            doubleEntry.TopLevel = false;
            panel_mainhome.Controls.Add(doubleEntry);
            doubleEntry.Location = new Point(300, 0);
            doubleEntry.Show();
        }

        private void btn_accountRecon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel_mainhome.Controls.Clear();
            accountReconcilement.TopLevel = false;
            panel_mainhome.Controls.Add(accountReconcilement);
            accountReconcilement.Location = new Point(300, 0);
            accountReconcilement.Show();

        }

        // جرد الصناديق
        private void btn_BoxInventory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel_mainhome.Controls.Clear();
            boxInventory.TopLevel = false;
            panel_mainhome.Controls.Add(boxInventory);
            boxInventory.Location = new Point(300, 0);
            boxInventory.Show();
        }
        // دليل العملات
        private void btn_CurrencyGuide_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel_mainhome.Controls.Clear();
            currencyGuide.TopLevel = false;
            panel_mainhome.Controls.Add(currencyGuide);
            currencyGuide.Location = new Point(300, 0);
            currencyGuide.Show();

        }
        // دليل أسعار العملات
        private void btn_CurrencyPrices_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel_mainhome.Controls.Clear();
            currencyPricesGuide.TopLevel = false;
            panel_mainhome.Controls.Add(currencyPricesGuide);
            currencyPricesGuide.Location = new Point(300, 0);
            currencyPricesGuide.Show();

        }
        // دليل الصناديق
        private void btn_BoxGuide_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel_mainhome.Controls.Clear();
            boxGuide.TopLevel = false;
            panel_mainhome.Controls.Add(boxGuide);
            boxGuide.Location = new Point(300, 0);
            boxGuide.Show();

        }

        private void btn_GroupsGuide_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            panel_mainhome.Controls.Clear();
            groupsGuide.TopLevel = false;
            panel_mainhome.Controls.Add(groupsGuide);
            groupsGuide.Location = new Point(300, 0);
            groupsGuide.Show();
        }

        private void btn_EmpGuide_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            panel_mainhome.Controls.Clear();
            employeeGuide.TopLevel = false;
            panel_mainhome.Controls.Add(employeeGuide);
            employeeGuide.Location = new Point(300, 0);
            employeeGuide.Show();
        }

        private void btn_RoofingAccounts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            panel_mainhome.Controls.Clear();
            roofingAccounts.TopLevel = false;
            panel_mainhome.Controls.Add(roofingAccounts);
            roofingAccounts.Location = new Point(300, 0);
            roofingAccounts.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btn_GoverGuide_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            panel_mainhome.Controls.Clear();
            governorateGuide.TopLevel = false;
            panel_mainhome.Controls.Add(governorateGuide);
            governorateGuide.Location = new Point(300, 0);
            governorateGuide.Show();
        }

        private void btn_RecipientInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            panel_mainhome.Controls.Clear();
            recipientInfo.TopLevel = false;
            panel_mainhome.Controls.Add(recipientInfo);
            recipientInfo.Location = new Point(300, 0);
            recipientInfo.Show();
        }

        private void btn_PersonalInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {  
            panel_mainhome.Controls.Clear();
            personalInfo.TopLevel = false;
            panel_mainhome.Controls.Add(personalInfo);
            personalInfo.Location = new Point(300, 0);
            personalInfo.Show();
        }

        private void btn_conndb_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_conFormat frm = new frm_conFormat();
            frm.ShowDialog();
        }

        private void btn_Acc_Guide_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {        

            panel_mainhome.Controls.Clear();
            acounts_guide.TopLevel = false;
            panel_mainhome.Controls.Add(acounts_guide);
            acounts_guide.Location = new Point(300, 0);
            acounts_guide.Show();
        }
        // توريد حوالة
        private void BarButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel_mainhome.Controls.Clear();
            Supplying_transfer.TopLevel = false;
            panel_mainhome.Controls.Add(Supplying_transfer);
            Supplying_transfer.Location = new Point(300, 0);
            Supplying_transfer.Show();
        }
        //تاكيد صرف حوالة
        private void BarButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel_mainhome.Controls.Clear();
            exchange_confirmation.TopLevel = false;
            panel_mainhome.Controls.Add(exchange_confirmation);
            exchange_confirmation.Location = new Point(300, 0);
            exchange_confirmation.Show();
        }
        // قبض حوالة
        private void BarButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel_mainhome.Controls.Clear();
            receiving_transfer.TopLevel = false;
            panel_mainhome.Controls.Add(receiving_transfer);
            receiving_transfer.Location = new Point(300, 0);
            receiving_transfer.Show();
        }
        // صرف حوالة
        private void BarButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel_mainhome.Controls.Clear();
            transfer_money.TopLevel = false;
            panel_mainhome.Controls.Add(transfer_money);
            transfer_money.Location = new Point(300, 0);
            transfer_money.Show();
        }
        // تصدير حوالة
        private void BarButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel_mainhome.Controls.Clear();
            export_transfer.TopLevel = false;
            panel_mainhome.Controls.Add(export_transfer);
            export_transfer.Location = new Point(300, 0);
            export_transfer.Show();
        }
        // توقيف حوالة
        private void BarButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel_mainhome.Controls.Clear();
            stoping_transfer.TopLevel = false;
            panel_mainhome.Controls.Add(stoping_transfer);
            stoping_transfer.Location = new Point(300, 0);
            stoping_transfer.Show();
        }
        // العملات
        private void BarButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        { 
            panel_mainhome.Controls.Clear();
            sell_currency.TopLevel = false;
            panel_mainhome.Controls.Add(sell_currency);
            sell_currency.Location = new Point(300, 0);
            sell_currency.Show();
        }
    }
}
