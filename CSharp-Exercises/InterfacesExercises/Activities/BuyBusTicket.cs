namespace InterfacesExercises.Activities
{
    internal class BuyBusTicket : IActivity
    {        
        public void Execute()
        {
            Console.WriteLine("1- Login shopping portal.");
            Console.WriteLine("2- Select origin of travel.");
            Console.WriteLine("3- Select travel destination.");
            Console.WriteLine("4- Insert travel date.");
            Console.WriteLine("5- Insert personal and credit card information.");
            Console.WriteLine("6- logout shopping portal.");
        }
    }
}
