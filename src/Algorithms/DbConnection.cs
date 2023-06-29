namespace C__Algorithm;

public abstract class DbConnection
{
    public string? ConnectionString { get; set; }
    public TimeSpan TimeOut { get; set; }

    public DbConnection(string connectionString)
    {
        if (string.IsNullOrEmpty(connectionString))
        {
            throw new InvalidOperationException("Connection string cannot be empty");
        }
        ConnectionString = connectionString;   
    }

    public abstract void Open();
    public abstract void Close();
}

public class SqlConnection : DbConnection
{
    public SqlConnection(string connectionString) : base(connectionString)
    {
    }

    public override void Close()
    {
        throw new NotImplementedException(); // Console.WriteLine("Sql Connection closed.");
    }

    public override void Open()
    {
        throw new NotImplementedException(); // Console.WriteLine("Sql Connection opened.");
    }

}

public class OracleConnection : DbConnection
{
    public OracleConnection(string connectionString) : base(connectionString)
    {
    }

    public override void Close()
    {
        throw new NotImplementedException(); // Console.WriteLine("Oracle Connection closed.");
    }

    public override void Open()
    {
        throw new NotImplementedException(); // Console.WriteLine("Oracle Connection opened.");
    }
}