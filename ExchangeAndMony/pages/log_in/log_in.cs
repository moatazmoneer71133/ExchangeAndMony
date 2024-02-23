using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchangeAndMony.pages.log_in
{
    public partial class log_in : Form
    {
        Form1 home1 = new Form1();
        public log_in()
        {
            InitializeComponent();
        }

        private void Btn_log_Click(object sender, EventArgs e)
        {

            home1.Show();
        }
    }
}
