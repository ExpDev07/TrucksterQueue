using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucksterQueueServer {

    /// <summary>
    /// Truckster's queue
    /// </summary>
    public class TrucksterQueue {

        /// <summary>
        /// Entries in queue
        /// </summary>
        public ISet<QueueEntry> Entries { get; } = new SortedSet<QueueEntry>(new QueueEntryComparer());

        /// <summary>
        /// Creates a new truckster's queue
        /// </summary>
        public TrucksterQueue() {
            
        }

    }

    /// <summary>
    /// A comparer for the queue entry
    /// </summary>
    public class QueueEntryComparer : IComparer<QueueEntry> {

        public int Compare(QueueEntry x, QueueEntry y) {
            // Compare the priority of the two entries
            return x.Priority.CompareTo(y.Priority);
        }

    }

}
