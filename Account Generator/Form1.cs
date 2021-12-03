using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Account_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                var accounts = new WebClient().DownloadString("https://pastebin.com/raw/sfVwq4pZ").Split('\n');
                textBox1.Text = accounts[new Random().Next(0, accounts.Length)];
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            System.Diagnostics.Process.Start("https://namemc.com/profile/" + username);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            bunifuFlatButton2.Visible = true;
            bunifuFlatButton1.Size = new Size(119, 43);
            bunifuCustomLabel1.Visible = true;
        }


    }
}
