namespace Workflow
{
    public class Email : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("Email sent with: video started processing");
        }
    }
}