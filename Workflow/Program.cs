using System.ComponentModel;

namespace Workflow
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var workflow = new Workflow();
            var workflowEngine = new WorkflowEngine();
            var processing = new Processing();
            var email = new Email();
            var upload = new Upload();
            var webservices = new WebService();

            workflow.Add(upload);
            workflow.Add(webservices);
            workflow.Add(email);
            workflow.Add(processing);

            workflowEngine.Run(workflow);

        }
    }
}