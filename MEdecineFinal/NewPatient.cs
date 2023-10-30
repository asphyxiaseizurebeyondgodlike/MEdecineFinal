using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEdecineFinal
{
    public partial class NewPatient : Form
    {
        database db = new database();
        public NewPatient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string surname = textBox2.Text;
            string otchestvo = textBox3.Text;
            string adress = textBox4.Text;
            string data = textBox5.Text;
            try
            {
                int id_disease = int.Parse(textBox8.Text);
                int id_doctor = int.Parse(textBox9.Text);

                db.OpenConnection();

                string queryOnPatient = $"insert into Patients(first_name, last_name, otchestvo, adress, data,disease_id,attending_doctor_id) values ('{name}','{surname}','{otchestvo}','{adress}','{data}',{id_disease},{id_doctor})";
                SqlCommand command = new SqlCommand(queryOnPatient, db.GetConnection());
                command.ExecuteNonQuery();

                db.CloseConnection();

                MessageBox.Show("Новый пациент добавлен!");
            }catch (Exception ex)
            {

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "select id,name_disease from name_disease_id";
            SqlDataAdapter adapter = new SqlDataAdapter(query, db.GetConnection());

            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

            string queryDoc = "select DOCTORS.id,name,surname, otchestvo, DOCTORS.uvolen from name_doctor INNER JOIN DOCTORS on name_doctor.id = DOCTORS.id WHERE DOCTORS.uvolen = 'нет'";
            SqlDataAdapter adapterDoc = new SqlDataAdapter(queryDoc, db.GetConnection());

            DataSet dataSetDoc = new DataSet();

            adapterDoc.Fill(dataSetDoc);
            dataGridView2.DataSource = dataSetDoc.Tables[0];
        }
    }
}
