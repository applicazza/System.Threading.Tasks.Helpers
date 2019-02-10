namespace System.Threading.Tasks.Helpers
{
    public class AsyncLock : IDisposable
    {
        private readonly SemaphoreSlim _semaphoreSlim = new SemaphoreSlim(1, 1);
 
        public async Task<AsyncLock> LockAsync(CancellationToken token = default(CancellationToken))
        {
            await _semaphoreSlim.WaitAsync(token);
            return this;
        }
 
        public void Dispose()
        {
            _semaphoreSlim.Release();
        }
    }
}