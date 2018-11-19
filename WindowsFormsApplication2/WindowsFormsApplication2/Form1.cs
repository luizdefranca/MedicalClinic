using ClinicaNutrical.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ClinicaNutrical.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Load(DB.ExecuteReader(DB.connectionStringSqlServer, CommandType.Text, "Select * from usuario"));
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

        }
    }
}
