using ElementalHeartsRevivedMod.src.Hearts.Boss;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementalHeartsRevivedMod.src.NPCs.Boss {
    public class QueenSlimeNPC : NPC_Base {
        public QueenSlimeNPC()
          : base(NPCID.QueenSlimeBoss, ModContent.ItemType<QueenSlime>(), false) {
        }
    }
}
