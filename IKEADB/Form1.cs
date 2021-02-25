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
using System.Configuration;
using System.Data;

namespace IKEADB
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["IKEADB.Properties.Settings.IKEAConnectionString"].ConnectionString;
        }

        private void PopulateRoomsTable()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Room", connection))
            {
                DataTable roomTable = new DataTable();
                adapter.Fill(roomTable);

                listRooms.DisplayMember = "RoomName";
                listRooms.ValueMember = "Id";
                listRooms.DataSource = roomTable;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateRoomsTable();
        }

        private void PopulateSeriesNames()
        {
            string query = "SELECT Series.SeriesName FROM Room INNER JOIN Series ON Series.RoomId WHERE Room.Id = @RoomId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@RoomId", listRooms.SelectedValue);
                DataTable SeriesTable = new DataTable();
                adapter.Fill(SeriesTable);

                listSeries.DisplayMember = "SeriesName";
                listSeries.ValueMember = "RoomId";
                listSeries.DataSource = SeriesTable;
                
            }
        }

        private void listRooms_electedIndexChanged(object sender, EventArgs e)
        {
            PopulateSeriesNames();
        }

        //private void listRooms(object sender, EventArgs e)
        //{

        //}
    }
}
