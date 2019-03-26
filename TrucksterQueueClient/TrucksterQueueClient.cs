using CitizenFX.Core;
using CitizenFX.Core.Native;
using System;
using System.Threading.Tasks;
using TrucksterQueueShared;

namespace TrucksterQueueClient {

    /// <summary>
    /// Client part of the queue script
    /// </summary>
    public class TrucksterQueueClient : BaseScript {

        public TrucksterQueueClient() {
            // Client ticking
            Tick += Connected;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private async Task Connected() {

            try {

                // Ensures that if player isn't yet connected, then we wait
                while (!API.NetworkIsPlayerConnected(API.PlayerId())) {
                    await Delay(1000);
                }

                TriggerServerEvent(QueueEvents.PLAYER_CONNECTED);
                API.SendNuiMessage($@"{{ ""resname"" : ""{API.GetCurrentResourceName()}"" }}");
                Tick -= Connected;

            } catch (Exception e) {
                Debug.WriteLine("An error occured: " + e.Message);
            }

        }

    }

}
