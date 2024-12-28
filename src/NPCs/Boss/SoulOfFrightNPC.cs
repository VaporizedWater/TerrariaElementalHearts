using ElementalHeartsRevivedMod.src.Hearts.Boss;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementalHeartsRevivedMod.src.NPCs.Boss {
    public class SoulOfFrightNPC : NPC_Base {
        public SoulOfFrightNPC()
          : base(NPCID.SkeletronPrime, ModContent.ItemType<SoulOfFright>(), false) {
        }
    }
}
