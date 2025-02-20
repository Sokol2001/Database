using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ManagedCode.Database.Core;

public interface IDBCollectionQueryableResultAsync<T>
{
    Task<List<T>> ToListAsync(CancellationToken cancellationToken = default);
    IAsyncEnumerable<T> ToAsyncEnumerable(CancellationToken cancellationToken = default);
    Task<long> LongCountAsync(CancellationToken cancellationToken = default);
    Task<int> DeleteAsync(CancellationToken cancellationToken = default);
}