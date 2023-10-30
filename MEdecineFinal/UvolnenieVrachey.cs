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
    public partial class UvolnenieVrachey : Form
    {
        database db = new database();
        public UvolnenieVrachey()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select DOCTORS.id,name,surname, otchestvo, DOCTORS.uvolen from name_doctor INNER JOIN DOCTORS on name_doctor.id = DOCTORS.id";
            SqlDataAdapter adapter = new SqlDataAdapter(query, db.GetConnection());

            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idDocOnUvol = int.Parse(textBox1.Text);

            string query = $"UPDATE DOCTORS SET uvolen = 'Уволен' WHERE id = {idDocOnUvol}";
            try
            {
                db.OpenConnection();
                SqlCommand sqlCommand = new SqlCommand(query, db.GetConnection());
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Доктор успешно уволен!");
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                db.CloseConnection();
                MessageBox.Show("Произошла Ошибка");
                Console.WriteLine(ex.Message);
            }

        }
    }
}
