namespace _04_Modulo_Mas_sobre_TiposDatos.Codigo
{
    public enum TaskStatus
    {
        Completed,
        InProgress,
        NotStarted,
        Cancelled
    }

    public class CEnums
    {
        public void CodigoDelCurso()
        {
            var taskStatus = TaskStatus.Completed;

            switch(taskStatus)
            {
                case TaskStatus.Completed:
                    Console.WriteLine("Completed");
                    break;
                case TaskStatus.NotStarted:
                    Console.WriteLine("Not started");
                    break;
                case TaskStatus.Cancelled:
                    Console.WriteLine("Cancelled");
                    break;
                case TaskStatus.InProgress:
                    Console.WriteLine("In progress");
                    break;
                default:
                    Console.WriteLine("Unknow");
                break;
            }

            var taskStatusInt = (int)taskStatus;

            TaskStatus taskStatusProgress = (TaskStatus)1;

            Console.WriteLine(taskStatusProgress.ToString());
        }
    }
}
