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

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {int b,c;
        public Form2()
        {
            
            InitializeComponent();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "substitutionsDataSet.Classifier". При необходимости она может быть перемещена или удалена.
            this.classifierTableAdapter.Fill(this.substitutionsDataSet.Classifier);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "substitutionsDataSet1.Journal". При необходимости она может быть перемещена или удалена.
            this.journalTableAdapter1.Fill(this.substitutionsDataSet1.Journal);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "substitutionsDataSet1.Teacher". При необходимости она может быть перемещена или удалена.
            this.teacherTableAdapter1.Fill(this.substitutionsDataSet1.Teacher);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "substitutionsDataSet1.Discipline". При необходимости она может быть перемещена или удалена.
            this.disciplineTableAdapter1.Fill(this.substitutionsDataSet1.Discipline);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "substitutionsDataSet.Mode". При необходимости она может быть перемещена или удалена.
            this.modeTableAdapter.Fill(this.substitutionsDataSet.Mode);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "substitutionsDataSet.Class". При необходимости она может быть перемещена или удалена.
            this.classTableAdapter.Fill(this.substitutionsDataSet.Class);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "substitutionsDataSet.Discipline". При необходимости она может быть перемещена или удалена.
            this.disciplineTableAdapter.Fill(this.substitutionsDataSet.Discipline);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "substitutionsDataSet.Cause". При необходимости она может быть перемещена или удалена.
            this.causeTableAdapter.Fill(this.substitutionsDataSet.Cause);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "substitutionsDataSet.Teacher". При необходимости она может быть перемещена или удалена.
            this.teacherTableAdapter.Fill(this.substitutionsDataSet.Teacher);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "substitutionsDataSet.Journal". При необходимости она может быть перемещена или удалена.
            this.journalTableAdapter.Fill(this.substitutionsDataSet.Journal);
             SqlConnection connection = new SqlConnection("server=desktop-fpnq7im\\sqlexpress;" +
                                         "Integrated Security=SSPI; "
                                         + "database=Substitutions;");
             connection.Open();
             SqlDataAdapter da = new SqlDataAdapter("select * from Class", connection);
             DataTable tbl = new DataTable();
            /*
             da.Fill(tbl);
             comboBox4.DataSource = tbl;
             comboBox4.DisplayMember = "Number";
           
             comboBox4.ValueMember = "id";
              */
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
        

            /*int selectedIndex = teach1.SelectedIndex;
            Object selectedItem = teach1.SelectedItem;
            MessageBox.Show(selectedIndex.ToString());*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox5.ValueMember);

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime d = dateTimePicker1.Value.Date;
            string date = d.ToString("yyyy/MM/dd"); 
           // string d2 = d.ToShortDateString();

            SqlConnection connection = new SqlConnection("server=desktop-fpnq7im\\sqlexpress;" +
                                        "Integrated Security=SSPI; "
                                        + "database=Substitutions;");
            connection.Open();
            /*
            int a = Convert.ToInt32(comboBox4.Text);
            char b = Convert.ToChar(comboBox5.Text);
            */
            /*
            SqlCommand findclass = new SqlCommand("SELECT @cl = Class.id from Class where Number = @a AND Letter = @b;", connection);
            
            findclass.Parameters.Add("@cl", SqlDbType.Int);

            findclass.Parameters.Add("@a", SqlDbType.Int);
            findclass.Parameters["@a"].Value = comboBox4.Text;
            findclass.Parameters.Add("@b", SqlDbType.Char);
            findclass.Parameters["@b"].Value = comboBox5.Text;
            findclass.ExecuteNonQuery();
            */
            //DECLARE @cl INT; "+ label9.Text +" = Class.id from Class where Number = " + a + " AND Letter = '" + b + ";
            SqlCommand fillCustomersCommand = new SqlCommand("INSERT INTO [Journal]" +
                    "([DateSubs], [TeachShedule], [Cause], [SubShedule], [Class], [TeachSubs],[SubjSubs],[TypeSubs],[Mode])" +
                    "VALUES ('" + date + "', '"
                    + ((teach1.SelectedIndex)   + 1) + "', '"
                    + ((cause.SelectedIndex) + 1) + "', '"
                    + ((sub1.SelectedIndex) + 1) + "', "
                    + comboBox2.Text + ", '" 
                    + ((teach2.SelectedIndex) + 1) + "', '"
                    + ((sub2.SelectedIndex) +1) + "', '"
                    + ((type.SelectedIndex)+1)+ "', '"
                    + 1 + "');", connection);
    
            
fillCustomersCommand.ExecuteNonQuery();
           
            MessageBox.Show("Запис додано"); 
            
            //MessageBox.Show(d2.ToString());
            //MessageBox.Show(teach2.SelectedIndex.ToString()); 
            //MessageBox.Show(sub1.SelectedIndex.ToString()); 
            //MessageBox.Show(sub2.SelectedIndex.ToString()); 
           

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }



        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*SqlConnection connection = new SqlConnection("server=desktop-fpnq7im\\sqlexpress;" +
                                        "Integrated Security=SSPI; "
                                        + "database=Substitutions;");
            connection.Open();
            */
            //MessageBox.Show(comboBox4.ValueMember);
            
            SqlConnection connection = new SqlConnection("server=desktop-fpnq7im\\sqlexpress;" +
                                        "Integrated Security=SSPI; "
                                        + "database=Substitutions;");
            connection.Open();
            string whereStr = String.Format("where Number='{0}'", this.comboBox4.Text);

            string queryString2 = String.Format("select * from Class "
              + " {0}", whereStr);
            
                SqlCommand cmd2 = new SqlCommand(queryString2, connection); //=
                DataTable tbl2 = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd2); //=
                da.Fill(tbl2);

            string queryString3 = String.Format("select id from Class where Number = {0} AND Letter = {1}",
                comboBox4.Text, comboBox1.Text);

            SqlCommand cmd3 = new SqlCommand(queryString3, connection);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable tbl3 = new DataTable();
            da2.Fill(tbl3);
            comboBox2.DataSource = tbl3;
            comboBox1.DisplayMember = "id";
            comboBox2.ValueMember = "id";
            comboBox1.DataSource = tbl2;
            comboBox1.DisplayMember = "Letter";// столбец для отображения
            comboBox1.ValueMember = "id";//столбец с id
           
            /* string w = String.Format("where Letter='{0}'", this.comboBox4.ValueMember);

             string queryString3 = String.Format("declare @id INT;select id from Class "
               + " {0}", w);
               */

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            b = comboBox1.SelectedIndex;
            MessageBox.Show(b.ToString());
            

        }

        private void cause_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            //MessageBox.Show("+");
        }
    }
}
