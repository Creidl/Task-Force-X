using Task_Force.Data;
using Task_Force.Entities;
using Task_Force.Repositories;

var sqlRepository = new SqlRepository<ToDoOnce>(new TaskForceDbContext());

AddToDoRepeated(sqlRepository);
AddToDosOnce(sqlRepository);
WriteAllToConsole(sqlRepository);

static void AddToDosOnce(IRepository<ToDoOnce> toDosRepository)
{
    toDosRepository.Add(new ToDoOnce("pierwsze jednorazowe"));
    toDosRepository.Add(new ToDoOnce("drugie jednorazowe"));
    toDosRepository.Add(new ToDoOnce("trzecie jednorazowe"));
    toDosRepository.Save();
}

static void AddToDoRepeated(IWriteRepository<ToDoRepeated> ToDosRepository)
{
    ToDosRepository.Add(new ToDoRepeated("pierwsze powtarzalne"));
    ToDosRepository.Add(new ToDoRepeated("drugie powtarzalne"));
    ToDosRepository.Save();
}

static void WriteAllToConsole(IReadRepository<IEntity> repository)
{
    var items = repository.GetAll();
    foreach (ToDoOnce item in items)
    {
        Console.WriteLine(item);
    }
}