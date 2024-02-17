namespace EAHS.Infrastructure
{
    public class AppConfiguration
    {
        public string JwtSecretKey { get; set; }
        public static string Version { get; set; }

        public static bool CollectionDependOnLogistic { get; set; }

        public static string CGTAPIGateway { get; set; }
        public static string NotificationAPI { get; set; }

    }
}
