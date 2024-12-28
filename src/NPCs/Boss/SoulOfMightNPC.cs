using ElementalHeartsRevivedMod.src.Hearts.Boss;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementalHeartsRevivedMod.src.NPCs.Boss {
    public class SoulOfMightNPC : NPC_Base {
        public SoulOfMightNPC()
          : base(NPCID.TheDestroyer, ModContent.ItemType<SoulOfMight>(), false) {
        }
    }
}
