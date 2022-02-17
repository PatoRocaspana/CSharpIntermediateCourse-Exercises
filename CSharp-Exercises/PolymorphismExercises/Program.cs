using PolymorphismExercises;

Console.WriteLine("First part of the exercise");

//Exception TimeOut Case
try
{
    var dbConnectionOne = new OracleConnection(connectionString: "Some URL", timeout: TimeSpan.FromMilliseconds(2000));
    dbConnectionOne.Open();
    dbConnectionOne.Close();
}
catch (TimeoutException e)
{
    Console.WriteLine($"{e.Message}");
}

//Exception ConnectionString Case
try
{
    var dbConnectionOne = new SqlConnection(connectionString:"");
    dbConnectionOne.Open();
    dbConnectionOne.Close();
}
catch (ArgumentNullException e)
{
    Console.WriteLine($"{e.Message}");
}

//Happy cases!
var dbConnectionOk = new OracleConnection(connectionString: "Some URL");

dbConnectionOk.Open();
dbConnectionOk.Close();

Console.WriteLine("\nSecond Part of the exercise");

//Happy case!
var dbConnectionSQL = new SqlConnection(connectionString: "some Url");
var dbConnectionOracle = new OracleConnection(connectionString: "some Url");

var dbCommand = new DbCommand(dbConnection: dbConnectionSQL, command: "SELECT * FROM STACK");
dbCommand.Execute();

//Exception Case
try
{
    var dbCommandTest = new DbCommand(dbConnection: dbConnectionOracle, command: "");
    dbCommand.Execute();
}
catch (ArgumentNullException e)
{
    Console.WriteLine(e.Message);
}


