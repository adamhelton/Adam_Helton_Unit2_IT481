using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adam_Helton_Unit2_IT481
{
    public partial class Form1 : Form
    {
        DB database;
        public Form1()
        {
            InitializeComponent();
            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);
            button3.Click += new EventHandler(button3_Click);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            database = new DB("Server = DESKTOP-DOUST62\\SQLEXPRESS; " +
                "Trusted_Connection=true;" +
                "Database=northwind;" +
                "User Instance=false;");
                

            MessageBox.Show("Connection information sent");

        }
        private void button2_Click(object sender, EventArgs e)
        {
            string count = database.getCustomerCount();
            MessageBox.Show(count, "Customer count");

        }
        private void button3_Click(object sender, EventArgs e)
        {
            string names = database.getCompanyNames();
            MessageBox.Show(names, "Company Names");

        }

    }
}
