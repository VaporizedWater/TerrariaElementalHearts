using ElementalHeartsRevivedMod.src.Hearts.Boss;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementalHeartsRevivedMod.src.NPCs.Boss {
    public class DeerNPC : NPC_Base {
        public DeerNPC()
          : base(NPCID.Deerclops, ModContent.ItemType<Deer>(), false) {
        }
    }
}
