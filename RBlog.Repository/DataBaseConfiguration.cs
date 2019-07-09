using Microsoft.Extensions.Configuration;

namespace RBlog.Repository
{
    public class DataBaseConfiguration : ConfigurationBase
    {
        private string DataConnectionKey = "RBlogDataConnection";

        public string GetDataConnectionString()
        {
            return GetConfiguration().GetConnectionString(DataConnectionKey);
        }

    }
}
