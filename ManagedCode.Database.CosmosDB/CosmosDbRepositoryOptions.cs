using Microsoft.Azure.Cosmos;

namespace ManagedCode.Database.CosmosDB;

public class CosmosDbRepositoryOptions
{
    public string ConnectionString { get; set; }
    public string DatabaseName { get; set; }
    public string CollectionName { get; set; }
    public CosmosClientOptions CosmosClientOptions { get; set; }
    public bool SplitByType { get; set; } = true;
    public bool UseItemIdAsPartitionKey { get; set; } = true;
}