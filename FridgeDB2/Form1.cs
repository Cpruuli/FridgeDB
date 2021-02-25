using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FridgeDB2
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["FridgeDB2.Properties.Settings.FridgeDBConnectionString"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateFoodsTable();
        }

        private void PopulateFoodsTable()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM FoodType", connection))
            {
                DataTable FoodType = new DataTable();
                adapter.Fill(FoodType);

                listFoods.DisplayMember = "TypeName";
                listFoods.ValueMember = "Id";
                listFoods.DataSource = FoodType;
            }


        }

        private void listFoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateFoodNames();
        }

        private void PopulateFoodNames()
        {
            string query = "SELECT FoodInTheFridge.Name FROM FoodIntheFridge INNER JOIN FoodType ON FoodInTheFridge.TypeId = FoodType.id WHERE FoodType.id = @TypeId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@TypeId", listFoods.SelectedValue);
                DataTable FoodInTheFridge = new DataTable();
                adapter.Fill(FoodInTheFridge);

                listFoodNames.DisplayMember = "Name";
                listFoodNames.ValueMember = "Id";
                listFoodNames.DataSource = FoodInTheFridge;

            }

        }
    }
}
