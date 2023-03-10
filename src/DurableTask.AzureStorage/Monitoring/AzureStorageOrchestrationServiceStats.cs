//  ----------------------------------------------------------------------------------
//  Copyright Microsoft Corporation
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//  http://www.apache.org/licenses/LICENSE-2.0
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//  ----------------------------------------------------------------------------------

namespace DurableTask.AzureStorage.Monitoring
{
    using DurableTask.Core.Stats;
    using System.Collections.Concurrent;

    class AzureStorageOrchestrationServiceStats
    {
        public Counter StorageRequests { get; } = new Counter();

        public Counter MessagesSent { get; } = new Counter();

        public Counter MessagesRead { get; } = new Counter();

        public Counter MessagesUpdated { get; } = new Counter();

        public Counter TableEntitiesWritten { get; } = new Counter();

        public Counter TableEntitiesRead { get; } = new Counter();

        public Counter ActiveActivityExecutions { get; } = new Counter();

        // The standard library does not support a concurrent hashset, so use ConcurrentDictionary with the
        // value as a byte, as the value does not matter.
        public ConcurrentDictionary<string, byte> PendingOrchestratorMessages { get; } = new ConcurrentDictionary<string, byte>();
    }
}
