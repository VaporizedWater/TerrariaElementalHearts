using ElementalHeartsRevivedMod.lib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace ElementalHeartsRevivedMod.src {
    public class EHR_Player : ModPlayer {
        /// <summary>
        /// The amount of health the player has gained from consuming hearts. <br></br><br></br>
        /// The max hearts cap checks if this stored total bonusHP of the heart is greater than <br></br>
        /// or equal to the bonus HP that heart provides times the max hearts per heart.
        /// </summary>
        public IDictionary<string, int> used = new Dictionary<string, int>();

        /// <summary>
        /// Not much information on the docs about <i>when</i> or <i>how frequently</i> this is called, but Copilot says this is run every tick. <br></br>
        /// So I assume that the statLifeMax2 is recalculated every tick... So no need to worry about if changing the values of the <br></br>
        /// bonuses will end up breaking a character on a legacy save.
        /// </summary>
        public override void ResetEffects() {
            if (used == null)
                return;
            Player.statLifeMax2 += used.Values.Sum();
        }

        public override void SyncPlayer(int toWho, int fromWho, bool newPlayer) {
            ModPacket packet = Mod.GetPacket(256);
            packet.Write(Player.statLifeMax2);
            packet.Send(toWho, fromWho);
        }

        public override void SaveData(TagCompound tag) {
            foreach (KeyValuePair<string, int> keyValuePair in (IEnumerable<KeyValuePair<string, int>>)used)
                tag.Add(keyValuePair.Key, keyValuePair.Value);
        }

        public override void PostSavePlayer() {
            if (!ModContent.GetInstance<Config>().RoamingLogsEnabled)
                return;


            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string str = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString();
            File.WriteAllLines(folderPath + "/EHTracker-" + str + ".txt", used.Select(x => "[" + x.Key + " " + x.Value.ToString() + "]").ToArray());
            File.WriteAllLines(folderPath + "/EHTrackerLast.txt", used.Select(x => "[" + x.Key + " " + x.Value.ToString() + "]").ToArray());
        }

        public override void LoadData(TagCompound tag) {
            used = tag.AsEnumerable().ToDictionary(x => x.Key, x => int.Parse(x.Value.ToString()));
        }
    }
}
