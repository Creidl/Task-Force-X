namespace Task_Force.Entities
{
    public abstract class EntityBase : IEntity
    {
        public DateTime CreateTime { get; protected set; }
        public DateTime? FinishTime { get; protected set; }
        public bool IsDone { get; protected set; }
        public string Note { get; protected set; }
        public int Id { get; set; }

        public EntityBase(string note)
        {
            CreateTime = DateTime.Now;
            FinishTime = null;
            IsDone = false;
            Note = note;
        }

        public void MakeItDone()
        {
            IsDone = true;
            FinishTime = DateTime.Now;
        }

        public abstract void MakeItUndone();      
    }
}