// we use these libraries
using System;
using Npgsql;


// we make a class Database for our Database
public class Database
{   // we make attributes Dataset and DataTable
    private static DataSet dataSet = new DataSet();
    private static DataTable dataTable = new DataTable();


    // we create the Database variables
	public Database()
	{
        string Connection = String.Format("Server = {0}; Port = {1};" + "User ID = {2}; Password = {3}; Database = {4};", "145.24.222.148", "5432", "postgres", "1kb3n33n@dm1n", "project4");
        NpgsqlConnection connectie = new NpgsqlConnection(Connection);
	}

    // we get Info from the Database 
    public DataTable getInfo(string sql)
    {
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
        return DataTable;
    }
    // we add Info to the Database
    public void addInfo(string sql)
    {   
        // opens connection
        connectie.Open();

        // we create a command and we execute it
        NpgsqlCommand cmd = new NpgsqlCommand(sql, connectie);
        cmd.ExecuteNonQuery();

        // the connection closes
        connectie.Close();
    }
}
