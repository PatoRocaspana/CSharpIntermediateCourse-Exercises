namespace PolymorphismExercises
{
    internal class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString) { }
        public SqlConnection(string connectionString, TimeSpan timeout) : base(connectionString, timeout) { }

        public override void Open()
        {
            StartTime = DateTime.Now;
            Thread.Sleep(Timeout);

            if (Timeout.TotalMilliseconds != 0)
            {
                if ((DateTime.Now - StartTime) <= Timeout)
                    Console.WriteLine("SqlConnection was opened");
                else
                    throw new TimeoutException($"The timeout was greater than {Timeout} millisenconds");
            }
            else
            {
                Console.WriteLine("SqlConnection was opened");
            }
        }

        public override void Close()
        {
            Console.WriteLine("SqlConnection was closed");
        }
    }
}
