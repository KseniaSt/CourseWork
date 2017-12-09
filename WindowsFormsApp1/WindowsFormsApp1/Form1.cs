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
        }

        private void journalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.journalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.substitutionsDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "substitutionsDataSet.Journal". При необходимости она может быть перемещена или удалена.
            this.journalTableAdapter.Fill(this.substitutionsDataSet.Journal);

        }

        private void journalDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("server=desktop-fpnq7im\\sqlexpress;" +
                                       "Integrated Security=SSPI; "
                                       + "database=Substitutions;");
            connection.Open();
            

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Journal", connection);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "Journal");

            dataGridView1.DataSource = ds.Tables[0];
            MessageBox.Show("+");
        }
    }
}
