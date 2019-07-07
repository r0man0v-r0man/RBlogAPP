using Microsoft.Extensions.Configuration;

namespace RBlog.Repository
{
    public class DataBaseConfiguration : ConfigurationBase
    {
        private string DataConnectionKey = "RBlogDataConnection";

        private string AuthConnectionKey = "RBlogAuthConnection";

        public string GetDataConnectionString()
        {
            return GetConfiguration().GetConnectionString(DataConnectionKey);
        }

        public string GetAuthConnectionString()
        {
            return GetConfiguration().GetConnectionString(AuthConnectionKey);
        }
    }
}
