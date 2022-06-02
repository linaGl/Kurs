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
using System.Text.RegularExpressions;

namespace Kurs
{
    public partial class FiltrFormcs : Form
    {
        private SqlConnection connection = null;

        private List<string[]> rows = null;
        private List<string[]> filtredList = null;

        public FiltrFormcs()
        {
            InitializeComponent();
        }

        private void FiltrFormcs_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBKurs"].ConnectionString);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            listFind.Items.Clear();

            rows = new List<string[]>();

            string[] row = null;

            SqlDataReader dreader = null;
            //ListViewItem item = null;

            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM TabStn", connection);
                dreader = command.ExecuteReader();

                while (dreader.Read())
                {
                    row = new string[]
                    {
                        Convert.ToString(dreader["Id"]),
                        Convert.ToString(dreader["Surname"]),
                        Convert.ToString(dreader["Name"]),
                        Convert.ToString(dreader["Gryppa"]),
                        Convert.ToString(dreader["Phone"]),
                        Convert.ToString(dreader["Email"])
                    };

                    rows.Add(row);
                    RefreshList(rows);

                }
                
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

            finally
            {
                if (dreader != null && !dreader.IsClosed)
                {

                    dreader.Close();

                }
            }

            RefreshList(rows);
        }

        private void RefreshList(List<string[]> list)
        {

            listFind.Items.Clear();

            foreach (string[] s in list)
            {
                listFind.Items.Add(new ListViewItem(s));
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void idButt_Click(object sender, EventArgs e)
        {
            filtredList = rows.Where((x) => x[0].ToLower().Contains(textBox1.Text.ToLower())).ToList();

            RefreshList(filtredList);
        }

        private void famButt_Click(object sender, EventArgs e)
        {
            filtredList = rows.Where((x) => x[1].ToLower().Contains(textBox1.Text.ToLower())).ToList();

            RefreshList(filtredList);
        }

        private void nameButt_Click(object sender, EventArgs e)
        {
            filtredList = rows.Where((x) => x[2].ToLower().Contains(textBox1.Text.ToLower())).ToList();

            RefreshList(filtredList);
        }

        private void grButtF_Click(object sender, EventArgs e)
        {
            filtredList = rows.Where((x) => x[3].ToLower().Contains(textBox1.Text.ToLower())).ToList();

            RefreshList(filtredList);
        }

        private void phButtf_Click(object sender, EventArgs e)
        {
            filtredList = rows.Where((x) => x[4].ToLower().Contains(textBox1.Text.ToLower())).ToList();

            RefreshList(filtredList);
        }

        private void emButtF_Click(object sender, EventArgs e)
        {
            filtredList = rows.Where((x) => x[5].ToLower().Contains(textBox1.Text.ToLower())).ToList();

            RefreshList(filtredList);
        }
      
    }
    
}
