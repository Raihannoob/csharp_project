﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schoool_management_system
{
    public partial class fees_form : Form

    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-195LKBK;Initial Catalog=Students;Integrated Security=True");
        SqlDataAdapter adpt;
        DataTable dt;
        public fees_form()
        {
            InitializeComponent();
        }
        public void showdata()
        {
            adpt = new SqlDataAdapter("SELECT fees FROM  Table_1 WHERE Student_Id = '" + textBox1.Text + "'  ", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void fees_form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showdata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
