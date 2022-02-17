namespace PolymorphismExercises
{
    internal class DbCommand
    {
        public DbConnection DbConnection { get; private set; }
        public string Command { get; private set; }

        public DbCommand(DbConnection dbConnection, string command)
        {
            if (dbConnection == null)
                throw new ArgumentNullException(paramName: nameof(dbConnection), message: "DbConnection have a null reference!");
            else if (command == null || string.IsNullOrWhiteSpace(command))
                throw new ArgumentNullException(paramName: nameof(command), message: "Command is null or empty!");
            else
            {
                DbConnection = dbConnection;
                Command = command;
            }
        }

        public void Execute()
        {
            DbConnection.Open();
            Console.WriteLine(Command);
            DbConnection.Close();
        }
    }
}
