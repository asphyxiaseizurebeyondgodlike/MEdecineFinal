using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEdecineFinal
{
    public partial class InfoPacients : Form
    {
        database db = new database();
        public InfoPacients()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select * from Patients";
            SqlDataAdapter adapter = new SqlDataAdapter(query, db.GetConnection());

            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];




        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "select DOCTORS.id,name,surname, otchestvo, DOCTORS.uvolen from name_doctor INNER JOIN DOCTORS on name_doctor.id = DOCTORS.id WHERE DOCTORS.uvolen = 'нет'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, db.GetConnection());

            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idDoc = int.Parse(textBox1.Text);
            string query = $"select first_name, last_name from Patients WHERE attending_doctor_id = {idDoc}";
            SqlDataAdapter adapter = new SqlDataAdapter(query, db.GetConnection());

            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InfoPacients_Load(object sender, EventArgs e)
        {

        }
    }
}
