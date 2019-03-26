using CitizenFX.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrucksterQueueShared;

namespace TrucksterQueueServer {



    /// <summary>
    /// Server part of the queue script
    /// </summary>
    public class TrucksterQueueServer : BaseScript {

        // The truckster's queue
        private TrucksterQueue queue = new TrucksterQueue();

        public TrucksterQueueServer() {
            // Add some event handlers that we will need
            EventHandlers[QueueEvents.PLAYER_CONNECTED] += new Action<Player>(PlayerActivated);
        }

        /// <summary>
        /// Called when player is activated
        /// </summary>
        private void PlayerActivated([FromSource] Player source) {

        }

    }

}
