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

namespace CarCheck
{
    public partial class AuthorizationWindow : Form
    {
        public string connStr = @"Data Source=MSI\ROXEP;Initial Catalog=CarCheckDB;Integrated Security=True"; SqlDataAdapter dataAdapter;
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

       
        
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (TBEmailAuth.Text != "" && TBPasswordAuth.Text != "")
            {
                SqlConnection connection = new SqlConnection(this.connStr);
                try
                {
                    connection.Open();
                    dataAdapter = new SqlDataAdapter($"select id_role from [employee] WHERE email = '{TBEmailAuth.Text}' and password = '{TBPasswordAuth.Text}'", connection);
                    DataSet ds = new DataSet();
                    dataAdapter.Fill(ds);
                    if (ds.Tables[0].Rows[0].Field<string>(ds.Tables[0].Columns[0]) == "B")
                    {
                        
                        foremanPanel fun1 = new foremanPanel();
                        fun1.Show();

                    }
                    if (ds.Tables[0].Rows[0].Field<string>(ds.Tables[0].Columns[0]) == "A")

                    {
                        
                        adminPanel fun = new adminPanel();
                        fun.Show();
                    }
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Неверные данные!");
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Неверные данные!");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            adminPanel fun = new adminPanel();
            fun.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foremanPanel fun1 = new foremanPanel();
            fun1.Show();
        }
    }
}
