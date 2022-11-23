namespace Workflow
{
    public class WorkflowEngine
    {
        public void Run(IWorkflow workflow)
        {
            foreach (var activity in workflow.GetAllActivities())
            {
                activity.Execute();
            }
        }

    }
    
}