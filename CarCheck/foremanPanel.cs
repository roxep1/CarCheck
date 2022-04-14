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
    public partial class foremanPanel : Form
    {
        public string connStr = @"Data Source=MSI\ROXEP;Initial Catalog=CarCheckDB;Integrated Security=True";
        public foremanPanel()
        {
            InitializeComponent();
        }
        private void foremanPanel_Load(object sender, EventArgs e)
        {
            LoadModel();
            LoadCategory();
        }

        public void LoadModel()
        {
            SqlConnection connection = new SqlConnection(this.connStr);
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT model.id_model as 'ID model',[tank_volume] as 'tank volume',[speed] as 'speed' ,[amount_produced] as 'produced' FROM model", connection);
                DataSet ds2 = new DataSet();
                adapter.Fill(ds2);
                dataGridView3.DataSource = ds2.Tables[0];

                adapter.SelectCommand = new SqlCommand("SELECT * FROM model", connection);

                DataSet ds4 = new DataSet();
                adapter.Fill(ds4);
               
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
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT transport_category.id_category as 'ID cat',[name_category] as 'Название cat',[unique_char] as 'unique char' FROM transport_category", connection);
                DataSet ds2 = new DataSet();
                adapter.Fill(ds2);
         
                adapter.SelectCommand = new SqlCommand("SELECT * FROM transport_category", connection);



                DataSet ds1 = new DataSet();
                adapter.Fill(ds1);
                CBCategory4.DataSource = ds1.Tables[0];
                CBCategory4.DisplayMember = "name_category";
                CBCategory4.ValueMember = "id_category";




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



        private void btnProduce_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(this.connStr);
            if (TBProduce.Text.Contains('-'))
            {
                connection.Close();
                MessageBox.Show("Перепроверьте данные");

            }


            else
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter($"sELECT amount_produced as 'Произведено' FROM model where  model_name='{dataGridView3.SelectedRows[0].Cells[0].Value}'", connection);
                    DataSet dsam = new DataSet();
                    adapter.Fill(dsam);
                    int amount = dsam.Tables[0].Rows[0].Field<int>(0);
                    amount += int.Parse(TBProduce.Text);
                    SqlCommand cmd = new SqlCommand($"UPDATE model SET amount_produced={amount}WHERE model_name='{dataGridView3.SelectedRows[0].Cells[0].Value}'", connection);

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


        }


        private void CBCategory4_SelectedIndexChanged_1(object sender, EventArgs e)
        { 
                SqlConnection connection = new SqlConnection(this.connStr);

                connection.Open();

               

                SqlDataAdapter adapter = new SqlDataAdapter($"Select model.model_name As 'Наименование модели',amount_produced as 'Количество' From model join transport_category On transport_category.id_category = model.id_category Where transport_category.name_category = '{CBCategory4.Text}'", connection);
                DataSet ds3 = new DataSet();
                adapter.Fill(ds3);

                CBModel2.DataSource = ds3.Tables[0];
                CBModel2.DisplayMember = "Наименование модели";
                dataGridView3.DataSource = ds3.Tables[0];
               

        }
        
    }
}
