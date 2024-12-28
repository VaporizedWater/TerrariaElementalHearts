using ElementalHeartsRevivedMod.src.Hearts.Boss;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementalHeartsRevivedMod.src.NPCs.Boss {
    public class SoulOfSightNPC : NPC_Base {
        public SoulOfSightNPC()
          : base(NPCID.Retinazer, ModContent.ItemType<SoulOfSight>(), false) {
        }
    }
}
