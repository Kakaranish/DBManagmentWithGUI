using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_with_GUI
{
    public partial class DatabaseGUI : Form
    {
        //Global variables
        public const string DB_Name = "world";

        MySqlConnection connection = new MySqlConnection();
        MySqlCommand command = null;

        //Binding sources
        BindingSource resultsBindingSource = new BindingSource();
        BindingSource tableNamesBindingSource = new BindingSource();

        List<string> tableNames = null;

        //Constructor
        public DatabaseGUI()
        {
            InitializeComponent();
            
            if(ConnectToDatabase())
                Console.WriteLine("Connected to DB!");
            else
                Console.WriteLine("Error while connecting to db");


            tableNames = LoadTableNames();
            SetBindingSourceTableNamesComboBox();

            ResetBindingSources();
        }


        private List<string> LoadTableNames()
        {
            if(!connection.Ping())
                return null;

            List<string> tableNames = new List<string>();
            string query = "show tables;";
            string colName = "tables_in_" + DB_Name;

            command = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
                tableNames.Add((string)dataReader[colName]);


            dataReader.Close();
            return tableNames;
        }
        private void SetBindingSourceTableNamesComboBox()
        {
            tableNamesBindingSource.DataSource = tableNames;
            tableNamesComboBox.DataSource = tableNamesBindingSource;
        }
        private void ResetBindingSources()
        {
            
        }
        private bool ConnectToDatabase()
        {
            MySqlConnectionStringBuilder connectionBuilder = new MySqlConnectionStringBuilder();
            connectionBuilder.SslMode = MySqlSslMode.None;
            connectionBuilder.Server = "46.41.135.103";
            connectionBuilder.Database = DB_Name;
            connectionBuilder.UserID = "application";
            connectionBuilder.Password = "baza123"; //TODO

            try
            {
                connection.ConnectionString = connectionBuilder.ToString();
                connection.Open();
                return true;
            }
            catch(MySqlException e)
            {
                Console.WriteLine("Unable to connect with DB! "+e.Message);
                return false;
            }  
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            string queryTextBoxText = queryTextBox.Text;
            List<string> queryWords = queryTextBoxText.Split(new Char[] { ' ' }).ToList();

            string query = "";
            /*
             * Get column names from table to list
             */ 
            List<string> columnNames = new List<string>();
            query = "show columns from city;";

            command = new MySqlCommand(query, connection);            
            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
                columnNames.Add((string)dataReader["field"]);

            query = "select * from city where ";

            int i = 0;
            foreach (string queryWord in queryWords)
            {
                foreach (string columnName in columnNames)
                {
                    if (i != 0)
                        query += "or ";
                    else
                        i++;
                    query += columnName + " like \'%" + queryWord + "%\' ";
                }
            }
            
            query += ";";
            dataReader.Close();


            command = new MySqlCommand(query, connection);
            Console.WriteLine(query);
            dataReader = command.ExecuteReader();
            

            
            ListViewItem listViewItem = null;

            resultsListView.Items.Clear();
            while (dataReader.Read()) {
                listViewItem = new ListViewItem(dataReader[columnNames[0]].ToString());


                for(i=1;i<columnNames.Count;i++)
                    listViewItem.SubItems.Add(dataReader[columnNames[i]].ToString());


                resultsListView.Items.Add(listViewItem);
            }

            if (listViewItem == null)
                MessageBox.Show("No entries found in database", "Information");

            dataReader.Close();
        }
    }
}
