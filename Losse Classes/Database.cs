// we use these libraries
// TODO import system.data for use of dataset en datatable
using System;
using Npgsql;


// we make a class Database for our Database
public class Database
{   // we make attributes Dataset and DataTable
    private static DataSet dataSet = new DataSet();
    private static DataTable dataTable = new DataTable();

    // TODO voer checks uit op de strings doormiddel van if, else if en else om ervoor te zorgen dat de correcte SQL query is opgegeven
    // Bijvoorbeeld: if(sql[:6] == "SELECT") { next check }


    // we create the Database variables
    public Database()
    {
        string Connection = String.Format("Server = {0}; Port = {1};" + "User ID = {2}; Password = {3}; Database = {4};", "145.24.222.148", "5432", "postgres", "1kb3n33n@dm1n", "project4");
        NpgsqlConnection connectie = new NpgsqlConnection(Connection);
    }

    // we get Info from the Database 
    public DataTable getInfo(string sql)
    {
        // TODO Insert a try to catch any potential errors
        // we open the connection of our sql database
        connectie.Open();
        // we assign a new variable to store our Info
        NpgsqlDataAdapter Data = new NpgsqlDataAdapter(sql, connectie);

        // we get Info from our Database
        dataSet.Reset();
        Data.Fill(dataSet);
        dataTable = dataSet.Tables[0];

        // the connection closes
        connectie.Close();

        // we return the DataTable
        return dataTable;
    }
    // we add Info to the Database
    public void editInfo(string sql)
    {
        // TODO Insert a try to catch any potential errors
        // opens connection
        connectie.Open();

        // we create a command and we execute it
        NpgsqlCommand cmd = new NpgsqlCommand(sql, connectie);
        cmd.ExecuteNonQuery();

        // the connection closes
        connectie.Close();
    }
}