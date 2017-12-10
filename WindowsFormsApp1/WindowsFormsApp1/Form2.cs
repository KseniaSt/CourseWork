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
    {
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

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("server=desktop-fpnq7im\\sqlexpress;" +
                                     "Integrated Security=SSPI; "
                                     + "database=Substitutions;");
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("INSERT * FROM Journal", connection);

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
            SqlCommand fillCustomersCommand = new SqlCommand("INSERT INTO [Journal]" +
                    "([DateSubs], [TeachShedule], [Cause], [SubShedule], [Class], [TeachSubs],[SubjSubs],[TypeSubs],[Mode])" +
                    "VALUES ('" + date + "', '" 
                    + (teach1.SelectedIndex)+1 + "', '" 
                    + (cause.SelectedIndex)+1 + "', '" 
                    + (sub1.SelectedIndex)+1 + "', '" 
                    + 1 + "', '" 
                    + (teach1.SelectedIndex) + 1 + "', '"
                    + (sub2.SelectedIndex) +1 + "', '"
                    + (type.SelectedIndex)+1+ "', '"
                    + 1 + "');", connection);

            
fillCustomersCommand.ExecuteNonQuery();
           
            //MessageBox.Show(teach1.SelectedIndex.ToString()); // 
            
            //MessageBox.Show(d2.ToString());
            //MessageBox.Show(teach2.SelectedIndex.ToString()); 
            //MessageBox.Show(sub1.SelectedIndex.ToString()); 
            //MessageBox.Show(sub2.SelectedIndex.ToString()); 
            MessageBox.Show(date.ToString()); 

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }



        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            MessageBox.Show(comboBox4.ValueMember);
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

        }
    }
}
