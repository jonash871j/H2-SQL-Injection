using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DataAccess
{
    private SqlConnection connection;
    private SqlCommand command;

    public DataAccess(string connectionString)
    {
        connection = new SqlConnection(connectionString);
        Restart();
    }

    public void Delete()
    {
        try
        {
            command = new SqlCommand("DROP TABLE TestTable", connection);

            connection.Open();
            command.ExecuteNonQuery();
        }
        catch
        {

        }
        finally
        {
            connection.Close();
        }
    }
    public void Restart()
    {
        Delete();

        try
        {
            command = new SqlCommand("CREATE TABLE TestTable( " +
                "Id INTEGER PRIMARY KEY IDENTITY(1,1), " +
                "Text TEXT" +
                ")", connection
            );

            connection.Open();
            command.ExecuteNonQuery();

        }
        finally
        {
            connection.Close();
        }

        AddDataSecure("Jonas");
        AddDataSecure("DummyUser");
        AddDataSecure("TestUser");
        AddDataSecure("SomeUser");
    }
    public void AddDataUnsecure(string data)
    {
        try
        {
            if (string.IsNullOrEmpty(data))
                throw new Exception("Empty string");

            command = new SqlCommand("INSERT INTO TestTable(Text) VALUES('" + "'); DROP TABLE TestTable; INSERT INTO TestTable(Text) VALUES('Dummy" + "'); ", connection);

            connection.Open();
            command.ExecuteNonQuery();
        }
        finally
        {
            connection.Close();
        }
    }
    public void AddDataSecure(string data)
    {
        try
        {
            if (string.IsNullOrEmpty(data))
                throw new Exception("Empty string");

            command = new SqlCommand("INSERT INTO TestTable(Text) VALUES(@Data); ", connection);
            command.Parameters.AddWithValue("@Data", data);

            connection.Open();
            command.ExecuteNonQuery();

        }
        finally
        {
            connection.Close();
        }
    }
    public List<string> GetTable()
    {
        List<string> users = new List<string>();

        try
        {
            command = new SqlCommand("SELECT * FROM TestTable;", connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                users.Add(reader.GetString(1));
            }
        }
        finally
        {
            connection.Close();
        }

        return users;
    }
}
