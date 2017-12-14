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
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void teach3_SelectedIndexChanged(object sender, EventArgs e)
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


            //SqlCommand findclass = new SqlCommand("DECLARE @cl INT; SELECT @cl = Class.id from Class where Number = " + a + " AND Letter = '" + b + "';", connection);
            //findclass.ExecuteNonQuery();
            SqlCommand fillCustomersCommand1 = new SqlCommand("INSERT INTO [Journal]" +
                    "([DateSubs], [TeachShedule], [Cause], [SubShedule], [Class], [TeachSubs],[SubjSubs],[TypeSubs],[Mode])" +
                    "VALUES ('" + date + "', '"
                    + ((teach3.SelectedIndex)+1)  + "', '"
                    + ((cause1.SelectedIndex) + 1) + "', '"
                    + 6 + "', '"
                    + 8 + "', '"
                    + 6 + "', '"
                    + 6 +  "', '"
                    + 3 + "', '"
                    + 2 + "');", connection);
            fillCustomersCommand1.ExecuteNonQuery();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.causeTableAdapter.Fill(this.substitutionsDataSet.Cause);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "substitutionsDataSet.Teacher". При необходимости она может быть перемещена или удалена.
            this.teacherTableAdapter.Fill(this.substitutionsDataSet.Teacher);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "substitutionsDataSet.Journal". При необходимости она может быть перемещена или удалена.
           

        }

        private void teach3_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
