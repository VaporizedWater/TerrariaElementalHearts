using ElementalHeartsRevivedMod.src.Hearts.Boss;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementalHeartsRevivedMod.src.NPCs.Boss {
    public class SkeletronNPC : NPC_Base {
        public SkeletronNPC()
          : base(NPCID.SkeletronHead, ModContent.ItemType<Skeletron>(), false) {
        }
    }
}
