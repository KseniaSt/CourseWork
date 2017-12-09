using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "substitutionsDataSet.Journal". При необходимости она может быть перемещена или удалена.
          //  this.journalTableAdapter.Fill(this.substitutionsDataSet.Journal);

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("server=desktop-fpnq7im\\sqlexpress;" +
                                       "Integrated Security=SSPI; "
                                       + "database=Substitutions;");
            connection.Open();
          
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM InfoJournal3", connection);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "InfoJournal3");

            //Здесь указываешь имя нужной таблицы            
            dataGridView1.DataSource = ds.Tables["InfoJournal3"];


            MessageBox.Show("+");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        Form2 form2;
        private void button2_Click(object sender, EventArgs e)
        {
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("server=desktop-fpnq7im\\sqlexpress;" +
                                      "Integrated Security=SSPI; "
                                      + "database=Substitutions;");
            connection.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM allinfo", connection);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "allinfo");

            //Здесь указываешь имя нужной таблицы            
            dataGridView1.DataSource = ds.Tables["allinfo"];


            MessageBox.Show("+");
        }
    }
}
