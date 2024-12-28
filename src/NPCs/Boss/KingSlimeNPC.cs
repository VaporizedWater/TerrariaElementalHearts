using ElementalHeartsRevivedMod.src.Hearts.Boss;
using Terraria.ModLoader;

namespace ElementalHeartsRevivedMod.src.NPCs.Boss {
    public class KingSlimeNPC : NPC_Base {
        public KingSlimeNPC()
          : base(50, ModContent.ItemType<KingSlime>(), false) {
        }
    }
}
