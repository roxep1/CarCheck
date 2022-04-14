using Microsoft.Toolkit;
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
    public partial class adminPanel : Form
    {
        public string connStr = @"Data Source=MSI\ROXEP;Initial Catalog=CarCheckDB;Integrated Security=True";
        public adminPanel()
        {
            InitializeComponent();
        }
        private void adminPanel_Load(object sender, EventArgs e)
        {
            LoadEmployee();
            LoadRole();
            LoadCategory();
            LoadModel();
        }

        public void LoadEmployee()
        {
            SqlConnection connection = new SqlConnection(this.connStr);
            try
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT employee.id_employee as 'ID сотрудника',[email] as 'почта',[password] as 'пароль',[id_role] as 'ID роли' FROM employee", connection);
                DataSet ds2 = new DataSet();
                adapter.Fill(ds2);
                dataGridView1.DataSource = ds2.Tables[0];

                adapter.SelectCommand = new SqlCommand("SELECT * FROM employee", connection);

                DataSet ds = new DataSet();
                adapter.Fill(ds);
                //listBox1.DataSource = ds.Tables[0];
                //listBox1.DisplayMember = "email";
                //listBox1.ValueMember = "id_employee";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void LoadRole()
        {
            SqlConnection connection = new SqlConnection(this.connStr);
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT role.id_role as 'ID роли',[role_name] as 'Название рoли' FROM role", connection);
                DataSet ds2 = new DataSet();
                adapter.Fill(ds2);
                //dataGridView1.DataSource = ds2.Tables[0];
                adapter.SelectCommand = new SqlCommand("SELECT * FROM role", connection);

                DataSet ds1 = new DataSet();
                adapter.Fill(ds1);
                CBRole.DataSource = ds1.Tables[0];
                CBRole.DisplayMember = "role_name";
                CBRole.ValueMember = "id_role";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void LoadModel()
        {
            SqlConnection connection = new SqlConnection(this.connStr);
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT model.id_model as 'ID модели',model_name as 'Название модели',[tank_volume] as 'Объём бака',[speed] as 'Скорость' ,[amount_produced] as 'Произведено' FROM model", connection);
                DataSet ds2 = new DataSet();
                adapter.Fill(ds2);

                dataGridView2.DataSource = ds2.Tables[0];
                dataGridView3.DataSource = ds2.Tables[0];
                adapter.SelectCommand = new SqlCommand("SELECT * FROM model", connection);
                DataSet ds4 = new DataSet();
                adapter.Fill(ds4);
                CBModel.DataSource = ds4.Tables[0];
                CBModel.DisplayMember = "model_name";
                CBModel.ValueMember = "id_model";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void LoadCategory()
        {
            SqlConnection connection = new SqlConnection(this.connStr);
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT transport_category.id_category as 'ID категории',[name_category] as 'Название категории' FROM transport_category", connection);
                DataSet ds2 = new DataSet();
                adapter.Fill(ds2);
                adapter.SelectCommand = new SqlCommand("SELECT * FROM transport_category", connection);

                DataSet ds1 = new DataSet();
                adapter.Fill(ds1);
                CBCategory2.DataSource = ds1.Tables[0];
                CBCategory2.DisplayMember = "name_category";
                CBCategory2.ValueMember = "id_category";

                DataSet ds3 = new DataSet();
                adapter.Fill(ds3);
                CBCategory3.DataSource = ds3.Tables[0];
                CBCategory3.DisplayMember = "name_category";
                CBCategory3.ValueMember = "id_category";

                DataSet ds4 = new DataSet();
                adapter.Fill(ds4);
                CBCategory.DataSource = ds4.Tables[0];
                CBCategory.DisplayMember = "name_category";
                CBCategory.ValueMember = "id_category";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

    


        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (TBEmail.Text.Contains('@') && TBEmail.Text.Contains('.') && TBPassword.TextLength >= 6)
                {
                    SqlConnection connection = new SqlConnection(this.connStr);
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand($"INSERT INTO employee (email, password,id_role) VALUES ('{TBEmail.Text}','{TBPassword.Text}','{CBRole.SelectedValue}')", connection);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                LoadEmployee();
                LoadRole();
            }
            
        }
            else
            {
                MessageBox.Show("Перепроверьте данные");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(this.connStr);
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand($"INSERT INTO model (model_name,tank_volume,speed,id_category,amount_produced) VALUES ('{TBModel.Text}',{TBChar1.Text},{TBChar2.Text},{CBCategory2.SelectedValue},{0})", connection);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                LoadModel();
                LoadCategory();
            }
        }

        private void btnDeleteModel_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(this.connStr);
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand($"DELETE FROM model WHERE model_name='{dataGridView3.SelectedRows[0].Cells[0].Value}'", connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                LoadModel();
                LoadCategory();
            }
        }

        

        private void btnShowTech_Click(object sender, EventArgs e)
        {

            
                SqlConnection connection = new SqlConnection(this.connStr);

                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter($"Select model.model_name As 'Наименование', model.tank_volume As 'Объем бака', model.speed As 'Скорость', model.amount_produced As 'Количество' From model join transport_category On transport_category.id_category = model.id_category Where transport_category.name_category = '{CBCategory.Text}'", connection);
                DataSet ds2 = new DataSet();
                adapter.Fill(ds2);
              
                adapter.SelectCommand = new SqlCommand("SELECT * FROM transport_category", connection);
                dataGridView4.DataSource = ds2.Tables[0];


           
        }

        private void CBCategory3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(this.connStr);

            connection.Open();

            

            SqlDataAdapter adapter = new SqlDataAdapter($"Select model.model_name As 'Наименование модели' From model join transport_category On transport_category.id_category = model.id_category Where transport_category.name_category = '{CBCategory3.Text}'", connection);
            DataSet ds3 = new DataSet();
            adapter.Fill(ds3);
            
            CBModel.DataSource = ds3.Tables[0];
            CBModel.DisplayMember = "Наименование модели";
            dataGridView3.DataSource = ds3.Tables[0];


        }

       

        private void TBPassword_TextChanged(object sender, EventArgs e)
        {



            if (TBPassword.TextLength < 6)
            {
                btnAddUser.Enabled = false;
            }
            else
            {
                btnAddUser.Enabled = true;
            }
        }

       

        private void TBEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            TabPage tb = tabControl1.SelectedTab;
            TextBox txt = (TextBox)sender;
            foreach (var c in tb.Controls.OfType<Button>())
                if (StringExtensions.IsEmail(txt.Text))
                {
                    c.Enabled = true;
                }
               


            else if (TBPassword.Text.Length<6)
            {
                c.Enabled = false;
            }
        }
    }
}
