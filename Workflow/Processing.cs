namespace Workflow
{
    public class Processing : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("Database status: Processing");
        }
    }
}