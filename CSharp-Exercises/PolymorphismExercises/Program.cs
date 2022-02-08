using PolymorphismExercises;

//Exception TimeOut Case
try
{
    var dbConnection = new OracleConnection(connectionString: "Some URL", timeout: TimeSpan.FromMilliseconds(2000));
    dbConnection.Open();
    dbConnection.Close();
}
catch (TimeoutException e)
{
    Console.WriteLine($"{e.Message}");
}

//Exception ConnectionString Case
try
{
    var dbConnection = new SqlConnection(connectionString:"");
    dbConnection.Open();
    dbConnection.Close();
}
catch (ArgumentNullException e)
{
    Console.WriteLine($"{e.Message}");
}

//Happy cases!
//var dbConnection = new OracleConnection(connectionString: "Some URL");

//dbConnection.Open();
//dbConnection.Close();
