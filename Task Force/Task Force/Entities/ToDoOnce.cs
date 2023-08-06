namespace Task_Force.Entities
{
    public class ToDoOnce : EntityBase
    {
        public ToDoOnce(string note) : base(note)
        {
        }

        public override string ToString() => $"{CreateTime} >> {Note}";

        public override void MakeItUndone()
        {
            IsDone = false;
            FinishTime = null;
        }
    }
}