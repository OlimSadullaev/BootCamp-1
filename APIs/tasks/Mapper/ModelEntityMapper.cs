using System.Threading.Tasks;
namespace tasks.Mapper
{
    public static class ModelEntityMapper
    {
        public static Entity.Task ToTaskEntity(this Model.NewTask newTask)
        {
            return new Entity.Task(
                title: newTask.Title,
                description: newTask.Description,
                tags: string.Join(',', newTask.Tags),
                location: string.Format($"{newTask.Location.Latitude},{newTask.Location.Longitude}"),
                atATime: newTask.AtATime,
                onADay: newTask.OnADay,
                repeat: newTask.Repeat.Value.ToEntityEtaskRepeat()
                 
            );
        }


        public static Entity.ETaskRepeat ToEntityEtaskRepeat(this Model.ETaskRepeat repeat)
        {
            return repeat switch
            {
                Model.EtaskRepeat.Daily => Entity.ETaskRepeat.Daily,
                _ => Entity.ETaskRepeat.Never
            };
        }
    }
}