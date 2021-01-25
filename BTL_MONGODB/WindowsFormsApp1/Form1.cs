using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static DataTable ConvertListToDataTable(List<string[]> list)
        {
            // New table.
            DataTable table = new DataTable();

            // Get max columns.
            int columns = 0;
            foreach (var array in list)
            {
                if (array.Length > columns)
                {
                    columns = array.Length;
                }
            }

            // Add columns.
            for (int i = 0; i < columns; i++)
            {
                table.Columns.Add();
            }

            // Add rows.
            foreach (var array in list)
            {
                table.Rows.Add(array);
            }

            return table;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            MongoClient client = new MongoClient("mongodb://localhost:27017");
            IMongoDatabase database = client.GetDatabase("quanghaui");
            IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>("drivers");
            
            
            List<BsonDocument> documents = collection.Find(new BsonDocument()).ToList();
            lstDanhSach.Items.Clear();
            foreach (BsonDocument document in documents)
            {
                string moduleDL = document["Module Name"].AsString;
                string statusDL = document["Status"].AsString;
                string stateDL = document["State"].AsString;
                lstDanhSach.Items.Add(moduleDL + "\t" + statusDL + "\t" + stateDL);
            }
        }
    }
}
