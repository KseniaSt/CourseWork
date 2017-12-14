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
            
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "substitutionsDataSet2.Teacher". При необходимости она может быть перемещена или удалена.
            this.teacherTableAdapter.Fill(this.substitutionsDataSet2.Teacher);
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
            dataGridView1.DataSource = ds.Tables["InfoJournal3"];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2;
            form2 = new Form2();
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
            SqlConnection connection = new SqlConnection("server=desktop-fpnq7im\\sqlexpress;" +
                                      "Integrated Security=SSPI; "
                                      + "database=Substitutions;");
            connection.Open();
            if (comboBox1.SelectedIndex == 0)
            {
                
                SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT * FROM AllinfoMonth(1)", connection);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds, "AllinfoMonth(1)");

                //Здесь указываешь имя нужной таблицы            
                dataGridView1.DataSource = ds.Tables["AllinfoMonth(1)"];
                MessageBox.Show("______+");
            }
            if (comboBox1.SelectedIndex == 1)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT * FROM AllinfoMonth(2)", connection);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds, "AllinfoMonth(2)");

                //Здесь указываешь имя нужной таблицы            
                dataGridView1.DataSource = ds.Tables["AllinfoMonth(2)"];
                MessageBox.Show("______+");
            }
            if (comboBox1.SelectedIndex == 2)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT * FROM AllinfoMonth(3)", connection);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds, "AllinfoMonth(3)");

                //Здесь указываешь имя нужной таблицы            
                dataGridView1.DataSource = ds.Tables["AllinfoMonth(3)"];
                MessageBox.Show("______+");
            }
            if (comboBox1.SelectedIndex == 3)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT * FROM AllinfoMonth(4)", connection);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds, "AllinfoMonth(4)");         
                dataGridView1.DataSource = ds.Tables["AllinfoMonth(4)"];
                MessageBox.Show("______+");
            }
            if (comboBox1.SelectedIndex == 5)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT * FROM AllinfoMonth(6)", connection);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds, "AllinfoMonth(6)");

                //Здесь указываешь имя нужной таблицы            
                dataGridView1.DataSource = ds.Tables["AllinfoMonth(6)"];
                MessageBox.Show("______+");
            }
            if (comboBox1.SelectedIndex == 6)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT * FROM AllinfoMonth(7)", connection);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds, "AllinfoMonth(7)");

                //Здесь указываешь имя нужной таблицы            
                dataGridView1.DataSource = ds.Tables["AllinfoMonth(7)"];
                MessageBox.Show("______+");
            }
            if (comboBox1.SelectedIndex == 7)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT * FROM AllinfoMonth(8)", connection);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds, "AllinfoMonth(8)");

                //Здесь указываешь имя нужной таблицы            
                dataGridView1.DataSource = ds.Tables["AllinfoMonth(8)"];
                MessageBox.Show("______+");
            }
                if (comboBox1.SelectedIndex == 8)
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT * FROM AllinfoMonth(9)", connection);
                    SqlCommandBuilder cb = new SqlCommandBuilder(da);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "AllinfoMonth(9)");

                    //Здесь указываешь имя нужной таблицы            
                    dataGridView1.DataSource = ds.Tables["AllinfoMonth(9)"];
                    MessageBox.Show("______+");
                }
                if (comboBox1.SelectedIndex == 9)
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT * FROM AllinfoMonth(10)", connection);
                    SqlCommandBuilder cb = new SqlCommandBuilder(da);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "AllinfoMonth(10)");

                    //Здесь указываешь имя нужной таблицы            
                    dataGridView1.DataSource = ds.Tables["AllinfoMonth(10)"];
                    MessageBox.Show("______+");
                }
                if (comboBox1.SelectedIndex == 10)
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT * FROM AllinfoMonth(11)", connection);
                    SqlCommandBuilder cb = new SqlCommandBuilder(da);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "AllinfoMonth(11)");

                    //Здесь указываешь имя нужной таблицы            
                    dataGridView1.DataSource = ds.Tables["AllinfoMonth(11)"];
                    MessageBox.Show("______+");
                }
                if (comboBox1.SelectedIndex == 11)
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT * FROM AllinfoMonth(12)", connection);
                    SqlCommandBuilder cb = new SqlCommandBuilder(da);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "AllinfoMonth(12)");

                    //Здесь указываешь имя нужной таблицы            
                    dataGridView1.DataSource = ds.Tables["AllinfoMonth(12)"];
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 form3;
            form3 = new Form3();
            form3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("server=desktop-fpnq7im\\sqlexpress;" +
                                     "Integrated Security=SSPI; "
                                     + "database=Substitutions;");
            connection.Open();

            

                SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT * FROM AllInfoTeach(" + (comboBox2.SelectedIndex + 1) + ")", connection);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
            da.Fill(ds, "AllinfoTeach("+ (comboBox2.SelectedIndex + 1)+")");
         
            dataGridView1.DataSource = ds.Tables["AllInfoTeach(" + (comboBox2.SelectedIndex + 1) + ")"];
            /*
            da.Fill(ds, "AllInfoTeach(" + (comboBox2.SelectedIndex + 1) + ");");
            
                dataGridView1.DataSource = ds.Tables["AllInfoTeach(" + (comboBox2.SelectedIndex + 1) + "')'"];
    */            
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("server=desktop-fpnq7im\\sqlexpress;" +
                                                  "Integrated Security=SSPI; "
                                                  + "database=Substitutions;");
            connection.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TopSubs", connection);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "TopSubs");

            //Здесь указываешь имя нужной таблицы            
            dataGridView1.DataSource = ds.Tables["TopSubs"];


        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.button10.BackColor = Color.White;
            SqlConnection connection = new SqlConnection("server=desktop-fpnq7im\\sqlexpress;" +
                                                 "Integrated Security=SSPI; "
                                                 + "database=Substitutions;");
            connection.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HoursNowF()", connection);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "HoursNowF()");       
            dataGridView1.DataSource = ds.Tables["HoursNowF()"];
            this.button10.BackColor = Color.Red;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.button10.BackColor = Color.White;
            SqlConnection connection = new SqlConnection("server=desktop-fpnq7im\\sqlexpress;" +
                                                 "Integrated Security=SSPI; "
                                                 + "database=Substitutions;");
            connection.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HourSubsClass", connection);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "HourSubsClass");
            dataGridView1.DataSource = ds.Tables["HourSubsClass"];
            this.button10.BackColor = Color.Red;
        }
    }
}
