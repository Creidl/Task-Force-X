namespace Task_Force.Entities
{
    public interface IEntity
    {
        int Id { get; set; }
        DateTime CreateTime { get; }
        DateTime? FinishTime { get; }
        bool IsDone { get; }
        string Note { get; }

        void MakeItDone();
        void MakeItUndone();
    }
}
