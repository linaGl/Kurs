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
     class Program
    {
        public SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBKurs"].ConnectionString);
        [STAThread]
        public static void Main()
        {
            //connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBKurs"].ConnectionString);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }

}
   

