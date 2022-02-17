namespace PolymorphismExercises
{
    internal abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan Timeout { get; set; }
        protected DateTime StartTime { get; set; }

        public DbConnection(string connectionString)
        {
            if (!string.IsNullOrWhiteSpace(connectionString))
            {
                ConnectionString = connectionString;
            }
            else
                throw new ArgumentNullException(paramName: nameof(connectionString), message: "ConnectionString is null or empty");
        }

        public DbConnection(string connectionString, TimeSpan timeout)
            : this(connectionString)
        {
            Timeout = timeout;
        }

        public abstract void Open();
        public abstract void Close();
    }
}
