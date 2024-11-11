using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
        DataTable Flower;
        DataTable Clients;
        SqlDataAdapter adapterFlower;
        SqlDataAdapter adapterClients;

        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = "Data Source=DESKTOP-32EDD3P\\SQLEXPRESS;" +
                "Initial Catalog=FlowerMarket;" +
                "Integrated Security=True";
            LoadData();
        }

            private void LoadData()
            {
                
                Flower = new DataTable();
                Clients = new DataTable();

                con.Open();

                
                adapterFlower = new SqlDataAdapter("SELECT * FROM Flower", con);
                adapterClients = new SqlDataAdapter("SELECT * FROM Clients", con);

                
                adapterFlower.Fill(Flower);
                adapterClients.Fill(Clients);

               
                dataGridView1.DataSource = Flower;
                dataGridView2.DataSource = Clients;

                con.Close();
            }

        

        private void SaveChanges()
        {
            try
            {
                con.Open(); 

                SqlCommandBuilder builderFlower = new SqlCommandBuilder(adapterFlower);
                SqlCommandBuilder builderClients = new SqlCommandBuilder(adapterClients);

                adapterFlower.Update(Flower);
                adapterClients.Update(Clients);

                MessageBox.Show("Изменения сохранены успешно.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении изменений: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }
    }
}
