using ClassLibraryCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            RekenMachin rekenMachin = new RekenMachin();
           int result = rekenMachin.Add(int.Parse(txtFirstRn.Text),int.Parse( txtSecondRn.Text));
            lblResult.Text = result.ToString();
        }

        private void btnCalculatSub_Click(object sender, EventArgs e)
        {
            RekenMachin rekenMachin = new RekenMachin();
            int result = rekenMachin.Sub(int.Parse(txtFirstRn.Text), int.Parse(txtSecondRn.Text));
            lblResult.Text = result.ToString();
        }

        private void btnCalculateDiv_Click(object sender, EventArgs e)
        {
            RekenMachin rekenMachin = new RekenMachin();
            int result = rekenMachin.Div(int.Parse(txtFirstRn.Text), int.Parse(txtSecondRn.Text));
            lblResult.Text = result.ToString();
        }
    }
}
