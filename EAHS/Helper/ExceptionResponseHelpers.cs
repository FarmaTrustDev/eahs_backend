namespace EAHS.Helper
{
    public class ExceptionResponseHelpers
    {
        public static int GetNotFoundCode()
        {
            return (int)System.Net.HttpStatusCode.NotFound;
        }

        public static int GetConflictCode()
        {
            return (int)System.Net.HttpStatusCode.Conflict;
        }
    }
}
