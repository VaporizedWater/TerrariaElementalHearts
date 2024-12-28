using ElementalHeartsRevivedMod.src.Hearts.Boss;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementalHeartsRevivedMod.src.NPCs.Boss {
    public class KingSlimeNPC : NPC_Base {
        public KingSlimeNPC()
          : base(NPCID.KingSlime, ModContent.ItemType<KingSlime>(), false) {
        }
    }
}
