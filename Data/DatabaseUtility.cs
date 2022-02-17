using Npgsql;

namespace AddressBook2.Data
{
    public class DatabaseUtility
    {
        public static String GetConnectionString(IConfiguration configuration)
        {
            var databaseUrl = Environment.GetEnvironmentVariable("DATABASE_URL");
            return String.IsNullOrEmpty(databaseUrl) ? configuration.GetConnectionString("DefaultConnection") : GetNpgsqlConnectionString(databaseUrl);
        }
        public static String GetNpgsqlConnectionString(String databaseUrl)
        {
            var databaseUri = new Uri(databaseUrl);
            var userInfo = databaseUri.UserInfo.Split(':');

            var builder = new NpgsqlConnectionStringBuilder
            {
                Host = databaseUri.Host,
                Port = databaseUri.Port,
                Username = userInfo[0],
                Password = userInfo[1],
                SslMode = SslMode.Prefer,
                Database = databaseUri.LocalPath.TrimStart('/'),
                TrustServerCertificate = true
            };

            return builder.ToString();
        }
    }
}
