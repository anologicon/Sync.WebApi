namespace Sync.WebApi.Config
{
    public class SyncDatabaseSettings: ISyncDatabaseSettings
    {
        public string CollectionName { get; set; }
        
        public string ConnectionString { get; set; }
        
        public string DatabaseName { get; set; }
    }

    public interface ISyncDatabaseSettings
    {
        string CollectionName { get; set; }
        
        string ConnectionString { get; set; }
        
        string DatabaseName { get; set; }
    }
}