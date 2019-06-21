using College.Comman.Interface;

namespace College.Business
{
    public class DevStudentsBusiness : IStudentsBusiness
    {
        public string SayHello()
        {
            return "I am from Dev";
        }
    }
}
