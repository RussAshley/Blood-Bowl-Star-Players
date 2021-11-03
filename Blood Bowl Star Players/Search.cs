using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Blood_Bowl_Star_Players
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayerDataAccess playerDataAccess = new PlayerDataAccess("Data Source= StarData.db");

           StarPlayer searchResult = playerDataAccess.ReadStarByName(SearchtextBox.Text);

            if (searchResult.StarPlayerName == SearchtextBox.Text)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No result Found");
            }
        }
    }
}


