namespace PolymorphismExercises
{
    internal class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString) { }
        public OracleConnection(string connectionString, TimeSpan timeout) : base(connectionString, timeout) { }

        public override void Open()
        {
            StartTime = DateTime.Now;
            Thread.Sleep(Timeout);

            if (Timeout.TotalMilliseconds != 0)
            {
                if ((DateTime.Now - StartTime) <= Timeout)
                    Console.WriteLine("OracleConnection was opened");
                else
                    throw new TimeoutException($"The timeout was greater than {Timeout} millisenconds");
            }
            else
            {
                Console.WriteLine("OracleConnection was opened");
            }
        }

        public override void Close()
        {
            Console.WriteLine("OracleConnection was closed");
        }
    }
}
