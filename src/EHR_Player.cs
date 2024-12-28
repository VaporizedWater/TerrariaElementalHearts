using ElementalHeartsRevivedMod.lib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace ElementalHeartsRevivedMod.src {
    public class EHR_Player : ModPlayer {
        public IDictionary<string, int> used = new Dictionary<string, int>();

        public override void ResetEffects() {
            if (used == null)
                return;
            foreach (KeyValuePair<string, int> keyValuePair in (IEnumerable<KeyValuePair<string, int>>)used)
                Player.statLifeMax2 += keyValuePair.Value;
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
