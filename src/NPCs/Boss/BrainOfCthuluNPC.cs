using ElementalHeartsRevivedMod.src.Hearts.Boss;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementalHeartsRevivedMod.src.NPCs.Boss {
    public class BrainOfCthulhuNPC : NPC_Base {
        public BrainOfCthulhuNPC()
          : base(NPCID.BrainofCthulhu, ModContent.ItemType<BrainOfCthulhu>(), false) {
        }
    }
}
