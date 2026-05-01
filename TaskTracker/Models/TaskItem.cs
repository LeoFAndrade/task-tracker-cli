namespace TaskTracker.Models
{

    //Enum is a type of data, here it is defining the fixed possible states for a task.
    public enum TaskStatus
    {
        Todo,
        InProgress,
        Done
    }

    public class TaskItem
    {
        //Private Field and the Access Interface (property) 
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _description = string.Empty;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        //Uses enum TaskStatus data type as variable  
        private TaskStatus _status;
        public TaskStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        private DateTime _createdAt = DateTime.Now;
        public DateTime CreatedAt
        {
            get { return _createdAt; }
            set { _createdAt = value; }
        }

        private DateTime _updatedAt = DateTime.Now;
        public DateTime UpdatedAt
        {
            get { return _updatedAt; }
            set { _updatedAt = value; }
        }
    }
}