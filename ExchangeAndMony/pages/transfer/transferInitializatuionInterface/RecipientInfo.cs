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



namespace ExchangeAndMony.pages.transfer.transferInitializatuionInterface
{
    public partial class RecipientInfo : DevExpress.XtraEditors.XtraForm
    {

        // nameDocument.Text="سند قيد بسيط";
        public RecipientInfo()
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

        private void btn_ImageCard_Click(object sender, EventArgs e)
        {
            ImageCard imageCard = new ImageCard();
            imageCard.Text = "بطاقة مستلم";
            imageCard.Show();
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {

        }
    }
}