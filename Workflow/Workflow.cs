namespace Workflow
{
    public class Workflow : IWorkflow
    {

        private List<IActivities> _activities = new List<IActivities>();

        public void Add(IActivities activities)
        {
            _activities.Add(activities);
        }

        public List<IActivities> GetAllActivities()
        {
            return _activities;
        }

        public void Remove(IActivities activities)
        {
            _activities.Remove(activities);
        }

     
    }
    
}