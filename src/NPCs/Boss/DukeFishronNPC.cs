using ElementalHeartsRevivedMod.src.Hearts.Boss;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementalHeartsRevivedMod.src.NPCs.Boss {
    public class DukeFishronNPC : NPC_Base {
        public DukeFishronNPC()
          : base(NPCID.DukeFishron, ModContent.ItemType<DukeFishron>(), false) {
        }
    }
}
