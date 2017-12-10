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
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

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

            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT * FROM AllInfo()", connection);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "AllInfo()");

            //Здесь указываешь имя нужной таблицы            
            dataGridView1.DataSource = ds.Tables["AllInfo()"];


            MessageBox.Show("+");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                SqlConnection connection = new SqlConnection("server=desktop-fpnq7im\\sqlexpress;" +
                                      "Integrated Security=SSPI; "
                                      + "database=Substitutions;");
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT * FROM AllinfoMonth(11)", connection);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds, "AllinfoMonth(11)");

                //Здесь указываешь имя нужной таблицы            
                dataGridView1.DataSource = ds.Tables["AllinfoMonth(11)"];
                MessageBox.Show("______+");
            }
        }
       

        private void button5_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //Книга.
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 1, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            //Вызываем нашу созданную эксельку.
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }
    }
}
