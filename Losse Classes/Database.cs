using System;

public class Database
{
    private static DataSet dataSet = new DataSet();
    private static DataTable dataTable = new DataTable();

	public Database()
	{
        string Connection = String.Format("Server = {0}; Port = {1};" + "User ID = {2}; Password = {3}; Database = {4};", "145.24.222.148", "5432", "postgres", "1kb3n33n@dm1n", "project4");
        NpgsqlConnection connectie = new NpgsqlConnection(Connection);
	}

    public DataTable getInfo(string sql)
    {
        connectie.Open();
        NpgsqlDataAdapter Data = new NpgsqlDataAdapter(sql, connectie);

        dataSet.Reset();
        Data.Fill(dataSet);
        dataTable = dataSet.Tables[0];

        connectie.Close();
        return DataTable;
    }
}
