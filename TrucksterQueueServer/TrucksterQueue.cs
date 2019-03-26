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

        private ISet<QueueEntry> entries = new SortedSet<QueueEntry>(new QueueEntryComparer());

        /// <summary>
        /// Creates a new truckster's queue
        /// </summary>
        public TrucksterQueue() {
            
        }

        /// <summary>
        /// Adds a new entry to the queue
        /// </summary>
        /// <param name="entry">Entry to add</param>
        public void Add(QueueEntry entry) {
            entries.Add(entry);
        }

        /// <summary>
        /// Removes an entry from the queue
        /// </summary>
        /// <param name="entry">Entry to remove</param>
        public void Remove(QueueEntry entry) {
            entries.Remove(entry);
        }

    }

    /// <summary>
    /// A comparer for the queue entry
    /// </summary>
    public class QueueEntryComparer : IComparer<QueueEntry> {

        public int Compare(QueueEntry x, QueueEntry y) {
            return x.Priority.CompareTo(y.Priority);
        }

    }

}
