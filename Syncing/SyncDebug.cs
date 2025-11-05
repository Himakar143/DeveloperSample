using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeveloperSample.Syncing
{
    public class SyncDebug
    {
        public async Task<List<string>> InitializeList(IEnumerable<string> items)
        {
            var processingTasks = items.Select(item => Task.Run(() => item));
            var processedItems = await Task.WhenAll(processingTasks);
            return processedItems.ToList();
        }

        public async Task<Dictionary<int, string>> InitializeDictionary(Func<int, string> getItem)
        {
            var itemsToInitialize = Enumerable.Range(0, 100).ToList();
            var itemsDictionary = new ConcurrentDictionary<int, string>();
            await Task.Run(() =>
            {
                Parallel.ForEach(itemsToInitialize, index =>
                {
                    itemsDictionary.TryAdd(index, getItem(index));
                });
            });
            return itemsDictionary.ToDictionary(pair => pair.Key, pair => pair.Value);
        }
    }
}