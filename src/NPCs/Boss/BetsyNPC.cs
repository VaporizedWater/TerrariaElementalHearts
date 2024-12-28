using ElementalHeartsRevivedMod.src.Hearts.Boss;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementalHeartsRevivedMod.src.NPCs.Boss {
    public class BetsyNPC : NPC_Base {
        public BetsyNPC()
          : base(NPCID.DD2Betsy, ModContent.ItemType<Betsy>(), false) {
        }
    }
}
