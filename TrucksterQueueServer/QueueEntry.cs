using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucksterQueueServer {

    /// <summary>
    /// An entry in truckster's queue
    /// </summary>
    public class QueueEntry {

        public string Identifier { get; }
        public int Priority { get; }

        /// <summary>
        /// Creates a new entry with an identifier and specified priority
        /// </summary>
        /// <param name="identifier">Identifier</param>
        /// <param name="priority">Priority (low -> high) </param>
        public QueueEntry(string identifier, int priority) {
            this.Identifier = identifier;
            this.Priority = priority;
        }

        /// <summary>
        /// Creates a new entry with an identifier and default priority
        /// </summary>
        /// <param name="identifier">Identifier</param>
        public QueueEntry(string identifier) : this(identifier, 0) {}

    }
}
