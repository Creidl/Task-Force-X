namespace Task_Force.Entities
{
    public class ToDoRepeated : ToDoOnce
    {
        public ToDoRepeated(string note) : base(note)
        {
        }

        public override void MakeItUndone()
        {            
        }
    }
}
