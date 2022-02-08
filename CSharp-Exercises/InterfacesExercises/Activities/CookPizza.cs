namespace InterfacesExercises.Activities
{
    internal class CookPizza : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("1- Turn on the oven and wait 10 minutes");
            Console.WriteLine("2- Put the pizza in the oven and wait 15 minures");
            Console.WriteLine("3- Take the pizza out from the oven");
            Console.WriteLine("4- Turn off the oven");
            Console.WriteLine("5- Eat Pizza :D");
        }
    }
}
