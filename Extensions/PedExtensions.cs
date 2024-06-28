using GTA;
using GTA.Native;
using System.Collections.Generic;

namespace MaskFix.Extensions
{
    public static class PedExtensions
    {
        #region Fields

        private static readonly Dictionary<int, string> Models = new Dictionary<int, string>
        {
            { Function.Call<int>(Hash.GET_HASH_KEY, "mp_m_freemode_01"), "mp_m_freemode_01" },
            { Function.Call<int>(Hash.GET_HASH_KEY, "mp_f_freemode_01"), "mp_f_freemode_01" }
        };

        #endregion

        /// <summary>
        /// Checks if the player character is using a freemode model.
        /// </summary>
        /// <param name="playerPed">The player character.</param>
        /// <returns>True if the player character is using a freemode model; otherwise, false.</returns>
        public static bool IsFreemodeModel(this Ped playerPed)
        {
            return Models.ContainsKey(playerPed.Model.Hash);
        }
    }
}
