namespace InterfacesExercises
{
    internal class WorkflowEngine
    {
        private readonly IActivity _activity;
        public WorkflowEngine(IActivity activity)
        {
            _activity = activity;
        }

        public void Run()
        {
            _activity.Execute();
        }
    }
}
