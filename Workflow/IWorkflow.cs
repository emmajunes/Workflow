namespace Workflow
{
        public interface IWorkflow
        {
        public void Add(IActivities activities);
        public void Remove(IActivities activities);

        List<IActivities> GetAllActivities();

    }
   
}