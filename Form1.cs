using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Kurs
{
    public partial class Form1 : Form
    {
        public SqlConnection connection = null;

        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBKurs"].ConnectionString);
            DataSet dataSet = new DataSet();
        }

        private void RefreshList(List<string[]> list)
        {
            listView1.Items.Clear();

            foreach (string[] s in list)
            {
                listView1.Items.Add(new ListViewItem(s));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void AddButt_Click(object sender, EventArgs e)
        {
            AddFOrm AddForm = new AddFOrm();
            AddForm.Owner = this;
            AddForm.Show();
        }



        private void FinddButt_Click(object sender, EventArgs e)
        {
            FiltrFormcs FiltForm = new FiltrFormcs();
            FiltForm.Owner = this;
            FiltForm.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            listView1.Items.Clear();
            SqlDataReader reader = null;

            try
            {
                string selectstr = null;

                buttonFun bf1 = new buttonFun(selectstr);



                SqlCommand command = new SqlCommand("SELECT Id, Surname, Name, Gryppa, Phone, Email FROM TabStn", connection);
                reader = command.ExecuteReader();

                ListViewItem item = null;

                while (reader.Read())
                {
                    item = new ListViewItem(new string[] { Convert.ToString(reader["Id"]), Convert.ToString(reader["Surname"]),
                        Convert.ToString(reader["Name"]), Convert.ToString(reader["Gryppa"]),
                        Convert.ToString(reader["Phone"]),Convert.ToString(reader["Email"]) });

                    listView1.Items.Add(item);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();

                }

            }
        }

        class buttonFunc 
        {
            public SqlConnection connection = null;

            public SqlCommand command = null;

            public string buttonFun(string a)
            {
                a = "SELECT Id, Surname, Name, Gryppa, Phone, Email FROM TabStn";
                return (a);

            }
          

        }


        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}


    




