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
using System.Configuration;

namespace Kurs
{
    public partial class AddFOrm : Form
    {
        public SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBKurs"].ConnectionString);

        public AddFOrm()
        {
            InitializeComponent();
        }
        private void AddFOrm_Load(object sender, EventArgs e)
        {
            connection.Open();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void Add_Butt_Click(object sender, EventArgs e)
        {
             
            SqlCommand command = new SqlCommand($"INSERT INTO [TabStn] " +
                $"(Surname, Name, Gryppa, Phone, Email) VALUES (@Surname, @Name, " +
                $"@Gryppa, @Phone, @Email)");

            command.Connection = connection;

            command.Parameters.AddWithValue("Surname", FumTB.Text);
            command.Parameters.AddWithValue("Name", NameTB.Text);
            command.Parameters.AddWithValue("Gryppa", GrTB.Text);
            command.Parameters.AddWithValue("Phone", PhTB.Text);
            command.Parameters.AddWithValue("Email", EmTB.Text);

            MessageBox.Show(command.ExecuteNonQuery().ToString());

            Close();
        }
        private void ClButt_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
